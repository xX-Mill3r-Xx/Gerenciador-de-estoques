using EstoqueManager.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EstoqueManager.Configuracoes
{
    public static class ConfiguracoesDataGridView
    {
        #region Estilização

        private static DataGridView EstilizacaoDataGrid(DataGridView dgvRegistros)
        {
            dgvRegistros.Cursor = Cursors.Hand;
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistros.BorderStyle = BorderStyle.None;
            dgvRegistros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvRegistros.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvRegistros.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvRegistros.DefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dgvRegistros.DefaultCellStyle.ForeColor = Color.White;
            dgvRegistros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 104, 196);
            dgvRegistros.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRegistros.EnableHeadersVisualStyles = false;
            dgvRegistros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvRegistros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRegistros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRegistros.RowHeadersVisible = false;
            dgvRegistros.GridColor = Color.FromArgb(50, 50, 50);
            dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistros.MultiSelect = false;

            return dgvRegistros;
        }

        #endregion

        public static DataGridView ConfiguracoesdgvRegistrosProdutos(DataGridView dgvRegistros, List<Produto> produtos)
        {
            dgvRegistros.DataSource = produtos.ToList();
            dgvRegistros = EstilizacaoDataGrid(dgvRegistros);
            dgvRegistros.Columns["Preco"].DefaultCellStyle.Format = "N2";
            return dgvRegistros;
        }

        public static DataGridView ConfiguracoesdgvRegistrosCategoria(DataGridView dgvRegistros, List<Categorias> categorias)
        {
            dgvRegistros.DataSource = categorias.ToList();
            dgvRegistros = EstilizacaoDataGrid(dgvRegistros);
            return dgvRegistros;
        }

        public static void AdicionarColunaExcluir(DataGridView dgvRegistros)
        {
            if (!dgvRegistros.Columns.Contains("Excluir"))
            {
                var colunaExcluir = new DataGridViewImageColumn();
                colunaExcluir.Name = "Excluir";
                colunaExcluir.HeaderText = "Excluir";
                colunaExcluir.Width = 35;
                colunaExcluir.Image = Properties.Resources.Deletar;
                colunaExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colunaExcluir.ToolTipText = "Excluir";

                dgvRegistros.Columns.Add(colunaExcluir);
            }
        }
    }
}
