using EstoqueManager.Configuracoes;
using EstoqueManager.Controller;
using EstoqueManager.Models;
using EstoqueManager.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager
{
    public partial class MainForm : Form
    {
        #region Properties

        private System.Timers.Timer _timer;
        private bool _modoInsercaoAtivo = false;
        private bool _enterPressionado = false;
        ProdutoController _produtoController;
        CategoriaController _categoriaController;
        private Produto _produtoEditado;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            _produtoController = new ProdutoController();
            _categoriaController = new CategoriaController();

            InicializarToolTips();
        }

        #endregion

        #region Configurações Iniciais

        private void InicializarToolTips()
        {
            toolTip.SetToolTip(btnAdicionar, "Salvar produto");
            toolTip.SetToolTip(btnClose, "Fechar Aplicação");
            toolTip.SetToolTip(btnInserirCategoria, "Nova categoria");
            toolTip.SetToolTip(btnProcurar, "Buscar Produto(s)");
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (_categoriaController == null)
                _categoriaController = new CategoriaController();

            await AtualizarComboBoxCategorias();
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                _modoInsercaoAtivo = false;
                await SalvarProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir um produto: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarProduto()
        {
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtPreco.Text, out decimal preco) ||
                cbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Verifique os dados inseridos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Produto produto = new Produto
            {
                Nome = txtProdutos.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                CategoriaId = (int)cbCategoria.SelectedValue,
                Preco = decimal.Parse(txtPreco.Text)
            };

            await _produtoController.SalvarProduto(produto);
            MessageBox.Show("Produto salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                await BuscarTodosProdutos();
                ConfiguracoesDataGridView.AdicionarColunaExcluir(dgvRegistros);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os produtos: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task BuscarTodosProdutos()
        {
            await Buscar();
        }

        private async Task Buscar()
        {
            string termo = txtProdutos.Text.Trim();

            if (string.IsNullOrWhiteSpace(termo))
            {
                var produtos = await _produtoController.ObterProdutos();
                dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, produtos.ToList());
            }
            else if (int.TryParse(termo, out int id))
            {
                var produto = await _produtoController.ObterProdutosPorId(id);
                if (produto != null)
                    dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, new List<Produto> { produto });
                else
                    MessageBox.Show("Produto não encontrado pelo ID informado","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var produto = await _produtoController.ObterProdutosPorNome($"%{termo}%");
                if (produto != null)
                    dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, new List<Produto> { produto });
                else
                    MessageBox.Show("Produto com este nome não foi encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscaDinamica()
        {
            if (_timer != null)
                _timer.Stop();
            _timer = new System.Timers.Timer(500);
            _timer.Elapsed += (s, args) =>
            {
                _timer.Stop();
                this.Invoke(new Action(async () =>
                {
                    await Buscar();
                }));
            };

            _timer.Start();
        }

        private void txtProdutos_TextChanged(object sender, EventArgs e)
        {
            if (_modoInsercaoAtivo)
                return;
            BuscaDinamica();
        }

        private async void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRegistros.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                var produto = dgvRegistros.Rows[e.RowIndex].DataBoundItem as Produto;
                if (produto != null) 
                {
                    var confirma = MessageBox.Show($"Deseja realmente excluir o produto \"{produto.Nome}\"?",
                        "Confirmar?",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        var resultado = await _produtoController.DeletarProduto(produto.Id);
                        if (resultado != null)
                        {
                            MessageBox.Show("Produto excluido com sucesso","Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BuscarTodosProdutos();
                        }
                    }
                }
            }
        }

        private async void dgvRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRegistros.IsCurrentCellInEditMode)
            {
                e.SuppressKeyPress = true;
                dgvRegistros.EndEdit();
            }

            if (e.KeyCode == Keys.Delete && dgvRegistros.SelectedRows.Count > 0)
            {
                var produto = dgvRegistros.SelectedRows[0].DataBoundItem as Produto;
                if (produto != null)
                {
                    var confirma = MessageBox.Show($"Deseja realmente excluir o produto \"{produto.Nome}\"?",
                        "Confirmar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        var resultado = await _produtoController.DeletarProduto(produto.Id);
                        if (resultado != null)
                        {
                            MessageBox.Show("Produto excluido com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BuscarTodosProdutos();
                        }
                    }
                }
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            _modoInsercaoAtivo = true;

            txtProdutos.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cbCategoria.SelectedIndex = -1;

            txtProdutos.Focus();
        }

        private async void dgvRegistros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _produtoEditado = dgvRegistros.Rows[e.RowIndex].DataBoundItem as Produto;

                if (_produtoEditado != null)
                {
                    var resultado = await _produtoController.AtualizarProduto(_produtoEditado);
                    if (resultado != null)
                    {
                        MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnInserirCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasCadastro cadastroCategoria = new FrmCategoriasCadastro();

            cadastroCategoria.CategoriasAlteradas += async (s, args) =>
            {
                await AtualizarComboBoxCategorias();
            };

            cadastroCategoria.Show();
        }

        private async Task AtualizarComboBoxCategorias()
        {
            var categorias = await _categoriaController.ObterCategorias();
            cbCategoria = ConfiguracoesComboBox.ConfiguracoesComboboxCategoria(cbCategoria, categorias.ToList());
        }
    }
}
