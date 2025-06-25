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

        public static DataGridView ConfiguracoesDgvHistorico(DataGridView dgvRegistros)
        {
            if (dgvRegistros.Columns.Count > 0)
            {
                dgvRegistros.Columns["ProdutoId"].Visible = false;
                dgvRegistros.Columns["Id"].Visible = false;
                dgvRegistros.Columns["Tipo"].HeaderText = "Tipo";
                dgvRegistros.Columns["Quantidade"].HeaderText = "Qtd.";
                dgvRegistros.Columns["DataMovimento"].HeaderText = "Data";
                dgvRegistros.Columns["DataMovimento"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                dgvRegistros = EstilizacaoDataGrid(dgvRegistros);
            }

            return dgvRegistros;
        }

        public static void AdicionarColunaExcluir(DataGridView dgvRegistros)
        {
            if (!dgvRegistros.Columns.Contains("Excluir"))
            {
                var colunaExcluir = new DataGridViewImageColumn
                {
                    Name = "Excluir",
                    HeaderText = "Excluir",
                    Width = 35,
                    Image = Properties.Resources.Deletar,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    ToolTipText = "Excluir"
                };

                colunaExcluir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvRegistros.Columns.Add(colunaExcluir);
            }
        }

        public static void AdicionarColunaBloqueada(DataGridView dgvRegistros, List<int> produtosBloqueados)
        {
            if (dgvRegistros.Columns.Contains("Excluir"))
                dgvRegistros.Columns.Remove("Excluir");

            var coluna = new DataGridViewImageColumn
            {
                Name = "Excluir",
                HeaderText = "Excluir",
                Width = 35,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dgvRegistros.Columns.Add(coluna);

            foreach (DataGridViewRow linha in dgvRegistros.Rows)
            {
                var produto = linha.DataBoundItem as Produto;
                if (produto != null && produtosBloqueados.Contains(produto.Id))
                {
                    linha.Cells["Excluir"].Value = Properties.Resources.Bloqueado;
                    linha.Cells["Excluir"].ToolTipText = "Produto bloqueado para exclusão";
                }
                else
                {
                    linha.Cells["Excluir"].Value = Properties.Resources.Deletar;
                    linha.Cells["Excluir"].ToolTipText = "Excluir produto";
                }
            }
        }
    }
}
