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
        ProdutoController _produtoController;
        CategoriaController _categoriaController;

        public MainForm()
        {
            InitializeComponent();
            _produtoController = new ProdutoController();
            _categoriaController = new CategoriaController();
        }

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
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir um produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            cbCategoria.DataSource = categorias.ToList();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
        }
    }
}
