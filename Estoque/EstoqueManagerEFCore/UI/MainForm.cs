using EstoqueManagerEFCore.Controllers;
using System.Threading.Tasks;

namespace EstoqueManagerEFCore
{
    public partial class MainForm : Form
    {
        #region Properties

        ProdutoController _produtoController;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            _produtoController = new ProdutoController();
        }

        #endregion

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var listaProdutos = await _produtoController.ObterProdutos();
            dgvRegistros.DataSource = listaProdutos;
        }
    }
}
