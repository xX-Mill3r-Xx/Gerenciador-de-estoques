using EstoqueManager.Configuracoes;
using EstoqueManager.Controller;
using EstoqueManager.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager
{
    public partial class MainForm : Form
    {
        #region Properties

        ProdutoController _produtoController;
        CategoriaController _categoriaController;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            _produtoController = new ProdutoController();
            _categoriaController = new CategoriaController();
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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var categorias = await _categoriaController.ObterCategorias();
            cbCategoria = ConfiguracoesComboBox.ConfiguracoesComboboxCategoria(cbCategoria, categorias.ToList());
        }

        private async void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                await BuscarTodosProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os produtos: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task BuscarTodosProdutos()
        {
            var produtos = await _produtoController.ObterProdutos();
            dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosProdutos(dgvRegistros, produtos.ToList());
        }
    }
}
