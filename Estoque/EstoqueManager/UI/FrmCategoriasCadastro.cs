using EstoqueManager.Configuracoes;
using EstoqueManager.Controller;
using EstoqueManager.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.UI
{
    public partial class FrmCategoriasCadastro : Form
    {
        #region Properties

        CategoriaController _categoriaController;
        private Categorias _categoriaEditada;

        #endregion

        #region Constructors

        public FrmCategoriasCadastro()
        {
            InitializeComponent();
            _categoriaController = new CategoriaController();
        }

        #endregion

        #region Eventos

        public event EventHandler CategoriasAlteradas;

        #endregion

        private void OnCategoriasAlteradas()
        {
            CategoriasAlteradas?.Invoke(this, EventArgs.Empty);
        }

        private async void FrmCategoriasCadastro_Load(object sender, EventArgs e)
        {
            await CarregarDgvRegistros();
        }

        private async Task CarregarDgvRegistros()
        {
            var categorias = await _categoriaController.ObterCategorias();
            dgvRegistros.DataSource = categorias;
            ConfiguracoesDataGridView.AdicionarColunaExcluir(dgvRegistros);
            dgvRegistros = ConfiguracoesDataGridView.ConfiguracoesdgvRegistrosCategoria(dgvRegistros, categorias.ToList());
        }

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                await SalvarCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir nova categoria: {ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarCategoria()
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Categorias categoria = new Categorias
                {
                    Nome = txtNome.Text
                };

                await _categoriaController.SalvarCategoria(categoria);
                MessageBox.Show("Categoria salva com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                await CarregarDgvRegistros();
                tcPrincipal.SelectedTab = tpConsultar;

                OnCategoriasAlteradas();
            }
            else
            {
                MessageBox.Show("Verifique os dados inseridos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            tcPrincipal.SelectedTab = tpConsultar;
            await CarregarDgvRegistros();
        }

        private async void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRegistros.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                var categoria = dgvRegistros.Rows[e.RowIndex].DataBoundItem as Categorias;
                var confirma = MessageBox.Show($"Deseja realmente excluir a categoria \"{categoria.Nome}\"?",
                        "Confirmar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (confirma == DialogResult.Yes)
                {
                    var resultado = await _categoriaController.DeletarCategoria(categoria.Id);
                    if (resultado != null)
                    {
                        MessageBox.Show("Categoria excluida com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarDgvRegistros();

                        OnCategoriasAlteradas();
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
                var categoria = dgvRegistros.SelectedRows[0].DataBoundItem as Categorias;
                if (categoria != null)
                {
                    var confirma = MessageBox.Show($"Deseja realmente excluir a categoria \"{categoria.Nome}\"?",
                        "Confirmar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (confirma == DialogResult.Yes)
                    {
                        var resultado = await _categoriaController.DeletarCategoria(categoria.Id);
                        if (resultado != null)
                        {
                            MessageBox.Show("Categoria excluida com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await CarregarDgvRegistros();

                            OnCategoriasAlteradas();
                        }
                    }
                }
            }
        }

        private async void dgvRegistros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _categoriaEditada = dgvRegistros.Rows[e.RowIndex].DataBoundItem as Categorias;
                if (_categoriaEditada != null)
                {
                    var resultado = await _categoriaController.AtualizarCategorias(_categoriaEditada);
                    if (resultado != null)
                    {
                        MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OnCategoriasAlteradas();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
