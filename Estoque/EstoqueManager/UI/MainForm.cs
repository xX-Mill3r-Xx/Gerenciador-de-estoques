using EstoqueManager.Configuracoes;
using EstoqueManager.Controller;
using EstoqueManager.Funcoes;
using EstoqueManager.Models;
using EstoqueManager.UI;
using EstoqueManager.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private List<int> _produtosBloqueados = new List<int>();

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
            toolTip = FuncaoToolTip.RetornaToolTip(btnAdicionar, Mensagens.Salvarproduto);
            toolTip = FuncaoToolTip.RetornaToolTip(btnClose, Mensagens.FecharAplicacao);
            toolTip = FuncaoToolTip.RetornaToolTip(btnInserirCategoria, Mensagens.NovaCategoria);
            toolTip = FuncaoToolTip.RetornaToolTip(btnProcurar, Mensagens.BuscarProdutos);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (_categoriaController == null)
                _categoriaController = new CategoriaController();

            await AtualizarComboBoxCategorias();
            PainelDesabilitado(pnProdutos);
        }

        private Panel PainelDesabilitado(Panel pn)
        {
            pn.Visible = false;
            pn.Enabled = false;
            return pn;
        }

        private Panel PainelHabilitado(Panel pn)
        {
            pn.Visible = true;
            pn.Enabled = true;
            return pn;
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
                MessageBox.Show(Mensagens.ErroAoInserir(ex), 
                    Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarProduto()
        {
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtPreco.Text, out decimal preco) ||
                cbCategoria.SelectedValue == null)
            {
                MessageBox.Show(Mensagens.VerifiqueOsDadosInseridos, 
                    Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Produto produto = new Produto
            {
                Nome = txtProdutos.Text,
                Quantidade = int.Parse(txtQuantidade.Text),
                CategoriaId = (int)cbCategoria.SelectedValue,
                Preco = decimal.Parse(txtPreco.Text)
            };

            await _produtoController.SalvarProduto(produto);
            MessageBox.Show(Mensagens.ProdutoSalvoComSucesso, Mensagens.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(Mensagens.ErroDeBusca(ex), 
                    Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task BuscarTodosProdutos()
        {
            var produtos = await Buscar();

            await AtualizarListaProdutosBloqueados(produtos);
            dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, produtos);
            ConfiguracoesDataGridView.AdicionarColunaBloqueada(dgvRegistros, _produtosBloqueados);
        }

        private async Task<List<Produto>> Buscar()
        {
            string termo = txtProdutos.Text.Trim();
            var categoriaSelecionada = cbCategoria.SelectedItem as Categorias;

            if (categoriaSelecionada != null && categoriaSelecionada.Id > 0)
            {
                var produtos = await _produtoController.ObterProdutosPorCategoria(categoriaSelecionada.Id);
                dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, produtos.ToList());
                return produtos.ToList();
            }
            if (string.IsNullOrWhiteSpace(termo))
            {
                var produtos = await _produtoController.ObterProdutos();
                dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, produtos.ToList());
                return produtos.ToList();
            }
            else if (int.TryParse(termo, out int id))
            {
                var produto = await _produtoController.ObterProdutosPorId(id);
                if (produto != null)
                {
                    var lista = new List<Produto> { produto };
                    dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, lista);
                    return lista;
                }
                else
                {
                    MessageBox.Show(Mensagens.NenhumRegistroLocalizado, 
                        Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new List<Produto>();
                } 
            }
            else
            {
                var produto = await _produtoController.ObterProdutosPorNome($"%{termo}%");
                if (produto != null)
                {
                    var lista = new List<Produto> { produto };
                    dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, lista);
                    return lista;
                }

                MessageBox.Show(Mensagens.NenhumRegistroLocalizado, 
                    Mensagens.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Produto>();
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
            if (dgvRegistros.Columns.Contains("Excluir") &&
                e.ColumnIndex == dgvRegistros.Columns["Excluir"].Index 
                && e.RowIndex >= 0)
            {
                var produto = dgvRegistros.Rows[e.RowIndex].DataBoundItem as Produto;
                if (produto != null) 
                {
                    if (!await ValidaExclusaoDeProdutoMovimentado(produto.Id))
                        return;

                    var confirma = MessageBox.Show(Mensagens.ExcluirItem(produto.Nome),
                        Mensagens.Confirma,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        var resultado = await _produtoController.DeletarProduto(produto.Id);
                        if (resultado != null)
                        {
                            MessageBox.Show(Mensagens.ExclusaoCompleta(produto.Nome),
                                Mensagens.Sucesso,MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BuscarTodosProdutos();
                            ConfiguracoesDataGridView.AdicionarColunaExcluir(dgvRegistros);
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
                    if (!await ValidaExclusaoDeProdutoMovimentado(produto.Id))
                        return;

                    var confirma = MessageBox.Show(Mensagens.ExcluirItem(produto.Nome),
                        Mensagens.Confirma, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        var resultado = await _produtoController.DeletarProduto(produto.Id);
                        if (resultado != null)
                        {
                            MessageBox.Show(Mensagens.ExclusaoCompleta(produto.Nome), 
                                Mensagens.Sucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await BuscarTodosProdutos();
                        }
                    }
                }
            }
        }

        private async Task<bool> ValidaExclusaoDeProdutoMovimentado(int produtoId)
        {
            bool possuiMovimentacao = await _produtoController.ProdutoPossuiMovimentacoes(produtoId);
            if (possuiMovimentacao)
            {
                MessageBox.Show(Mensagens.ProdutoBloqueadoParaExclusao(produtoId),
                    Mensagens.AcaoNaoPermitida, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async Task AtualizarListaProdutosBloqueados(IEnumerable<Produto> produtos)
        {
            _produtosBloqueados.Clear();
            foreach (var produto in produtos) 
            {
                bool bloqueado = await _produtoController.ProdutoPossuiMovimentacoes(produto.Id);
                if (bloqueado)
                    _produtosBloqueados.Add(produto.Id);
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
                        MessageBox.Show(Mensagens.AtualizadoComSucesso, 
                            Mensagens.Sucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Mensagens.ErroDeAtualizacao, 
                            Mensagens.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ChamarTelaMovimentacoes(char tipo)
        {
            FrmMovimentacoesEstoque frmMovimentacoesEstoque = new FrmMovimentacoesEstoque(tipo);

            frmMovimentacoesEstoque.EstoqueAlterado += async (s, args) =>
            {
                await BuscarTodosProdutos();
            };

            frmMovimentacoesEstoque.Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            ChamarTelaMovimentacoes('E');
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            ChamarTelaMovimentacoes('S');
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            PainelDesabilitado(pnProdutos);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            PainelHabilitado(pnProdutos);
        }
    }
}
