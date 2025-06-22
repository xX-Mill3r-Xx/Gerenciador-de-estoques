using EstoqueManager.Configuracoes;
using EstoqueManager.Controller;
using EstoqueManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.UI
{
    public partial class FrmCategoriasCadastro : Form
    {
        #region Properties

        CategoriaController _categoriaController;

        #endregion

        #region Constructors

        public FrmCategoriasCadastro()
        {
            InitializeComponent();
            _categoriaController = new CategoriaController();
        }

        #endregion

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
    }
}
