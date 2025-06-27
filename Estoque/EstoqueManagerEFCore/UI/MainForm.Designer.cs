namespace EstoqueManagerEFCore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            pnPrincipal = new Panel();
            pnFundoTitulo = new Panel();
            tlpTitulo = new TableLayoutPanel();
            lbTitulo = new Label();
            pnOpcoes = new Panel();
            tcprincipal = new TabControl();
            tpCadastro = new TabPage();
            tpConsulta = new TabPage();
            dgvRegistros = new DataGridView();
            tlpPrincipal.SuspendLayout();
            pnPrincipal.SuspendLayout();
            pnFundoTitulo.SuspendLayout();
            tlpTitulo.SuspendLayout();
            tcprincipal.SuspendLayout();
            tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.Controls.Add(pnPrincipal, 0, 1);
            tlpPrincipal.Controls.Add(pnFundoTitulo, 0, 0);
            tlpPrincipal.Controls.Add(pnOpcoes, 1, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPrincipal.Size = new Size(598, 450);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnPrincipal
            // 
            tlpPrincipal.SetColumnSpan(pnPrincipal, 2);
            pnPrincipal.Controls.Add(tcprincipal);
            pnPrincipal.Dock = DockStyle.Fill;
            pnPrincipal.Location = new Point(3, 43);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(592, 364);
            pnPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            tlpPrincipal.SetColumnSpan(pnFundoTitulo, 2);
            pnFundoTitulo.Controls.Add(tlpTitulo);
            pnFundoTitulo.Dock = DockStyle.Fill;
            pnFundoTitulo.Location = new Point(3, 3);
            pnFundoTitulo.Name = "pnFundoTitulo";
            pnFundoTitulo.Size = new Size(592, 34);
            pnFundoTitulo.TabIndex = 1;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lbTitulo, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(592, 34);
            tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(176, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(240, 21);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Gerenciador de estoque EFcore";
            // 
            // pnOpcoes
            // 
            pnOpcoes.Dock = DockStyle.Fill;
            pnOpcoes.Location = new Point(302, 413);
            pnOpcoes.Name = "pnOpcoes";
            pnOpcoes.Size = new Size(293, 34);
            pnOpcoes.TabIndex = 2;
            // 
            // tcprincipal
            // 
            tcprincipal.Controls.Add(tpCadastro);
            tcprincipal.Controls.Add(tpConsulta);
            tcprincipal.Dock = DockStyle.Fill;
            tcprincipal.Location = new Point(0, 0);
            tcprincipal.Name = "tcprincipal";
            tcprincipal.SelectedIndex = 0;
            tcprincipal.Size = new Size(592, 364);
            tcprincipal.TabIndex = 0;
            // 
            // tpCadastro
            // 
            tpCadastro.Location = new Point(4, 24);
            tpCadastro.Name = "tpCadastro";
            tpCadastro.Padding = new Padding(3);
            tpCadastro.Size = new Size(584, 336);
            tpCadastro.TabIndex = 0;
            tpCadastro.Text = "Cadastros";
            tpCadastro.UseVisualStyleBackColor = true;
            // 
            // tpConsulta
            // 
            tpConsulta.Controls.Add(dgvRegistros);
            tpConsulta.Location = new Point(4, 24);
            tpConsulta.Name = "tpConsulta";
            tpConsulta.Padding = new Padding(3);
            tpConsulta.Size = new Size(584, 336);
            tpConsulta.TabIndex = 1;
            tpConsulta.Text = "Consultas";
            tpConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Dock = DockStyle.Fill;
            dgvRegistros.Location = new Point(3, 3);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.Size = new Size(578, 330);
            dgvRegistros.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 450);
            Controls.Add(tlpPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += MainForm_Load;
            tlpPrincipal.ResumeLayout(false);
            pnPrincipal.ResumeLayout(false);
            pnFundoTitulo.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tcprincipal.ResumeLayout(false);
            tpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private Panel pnPrincipal;
        private Panel pnFundoTitulo;
        private Panel pnOpcoes;
        private TableLayoutPanel tlpTitulo;
        private Label lbTitulo;
        private TabControl tcprincipal;
        private TabPage tpCadastro;
        private TabPage tpConsulta;
        private DataGridView dgvRegistros;
    }
}
