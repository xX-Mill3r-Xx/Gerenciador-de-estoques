namespace EstoqueManagerEFCore.UI
{
    partial class FrmConfiguracaoDataBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            pnFundoTitulo = new Panel();
            tlpTitulo = new TableLayoutPanel();
            lbTitulo = new Label();
            pnPrincipal = new Panel();
            tcPrincipal = new TabControl();
            tpConexao = new TabPage();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnTestar = new Button();
            lbBaseDados = new Label();
            txtBaseDados = new TextBox();
            lbServidor = new Label();
            txtServidor = new TextBox();
            tpLog = new TabPage();
            rtbLogInfo = new RichTextBox();
            tlpPrincipal.SuspendLayout();
            pnFundoTitulo.SuspendLayout();
            tlpTitulo.SuspendLayout();
            pnPrincipal.SuspendLayout();
            tcPrincipal.SuspendLayout();
            tpConexao.SuspendLayout();
            tpLog.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.Controls.Add(pnFundoTitulo, 0, 0);
            tlpPrincipal.Controls.Add(pnPrincipal, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(317, 231);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            pnFundoTitulo.BackColor = Color.FromArgb(36, 192, 235);
            tlpPrincipal.SetColumnSpan(pnFundoTitulo, 2);
            pnFundoTitulo.Controls.Add(tlpTitulo);
            pnFundoTitulo.Dock = DockStyle.Fill;
            pnFundoTitulo.Location = new Point(3, 3);
            pnFundoTitulo.Name = "pnFundoTitulo";
            pnFundoTitulo.Size = new Size(311, 34);
            pnFundoTitulo.TabIndex = 0;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTitulo.Controls.Add(lbTitulo, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(0, 0);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(311, 34);
            tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Location = new Point(18, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(248, 21);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Configurações da base de dados";
            lbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnPrincipal
            // 
            tlpPrincipal.SetColumnSpan(pnPrincipal, 2);
            pnPrincipal.Controls.Add(tcPrincipal);
            pnPrincipal.Dock = DockStyle.Fill;
            pnPrincipal.Location = new Point(3, 43);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(311, 185);
            pnPrincipal.TabIndex = 1;
            // 
            // tcPrincipal
            // 
            tcPrincipal.Controls.Add(tpConexao);
            tcPrincipal.Controls.Add(tpLog);
            tcPrincipal.Dock = DockStyle.Fill;
            tcPrincipal.Location = new Point(0, 0);
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(311, 185);
            tcPrincipal.TabIndex = 0;
            // 
            // tpConexao
            // 
            tpConexao.Controls.Add(btnCancelar);
            tpConexao.Controls.Add(btnSalvar);
            tpConexao.Controls.Add(btnTestar);
            tpConexao.Controls.Add(lbBaseDados);
            tpConexao.Controls.Add(txtBaseDados);
            tpConexao.Controls.Add(lbServidor);
            tpConexao.Controls.Add(txtServidor);
            tpConexao.Location = new Point(4, 24);
            tpConexao.Name = "tpConexao";
            tpConexao.Padding = new Padding(3);
            tpConexao.Size = new Size(303, 157);
            tpConexao.TabIndex = 0;
            tpConexao.Text = "Conexão";
            tpConexao.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(202, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 26);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(108, 110);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 26);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnTestar
            // 
            btnTestar.Cursor = Cursors.Hand;
            btnTestar.FlatStyle = FlatStyle.Flat;
            btnTestar.Location = new Point(14, 110);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(88, 26);
            btnTestar.TabIndex = 4;
            btnTestar.Text = "Testar";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // lbBaseDados
            // 
            lbBaseDados.AutoSize = true;
            lbBaseDados.Location = new Point(14, 63);
            lbBaseDados.Name = "lbBaseDados";
            lbBaseDados.Size = new Size(82, 15);
            lbBaseDados.TabIndex = 3;
            lbBaseDados.Text = "Base de dados";
            // 
            // txtBaseDados
            // 
            txtBaseDados.Location = new Point(14, 81);
            txtBaseDados.Name = "txtBaseDados";
            txtBaseDados.Size = new Size(276, 23);
            txtBaseDados.TabIndex = 2;
            // 
            // lbServidor
            // 
            lbServidor.AutoSize = true;
            lbServidor.Location = new Point(14, 16);
            lbServidor.Name = "lbServidor";
            lbServidor.Size = new Size(50, 15);
            lbServidor.TabIndex = 1;
            lbServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(14, 34);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(276, 23);
            txtServidor.TabIndex = 0;
            // 
            // tpLog
            // 
            tpLog.Controls.Add(rtbLogInfo);
            tpLog.Location = new Point(4, 24);
            tpLog.Name = "tpLog";
            tpLog.Padding = new Padding(3);
            tpLog.Size = new Size(303, 157);
            tpLog.TabIndex = 1;
            tpLog.Text = "Log";
            tpLog.UseVisualStyleBackColor = true;
            // 
            // rtbLogInfo
            // 
            rtbLogInfo.BorderStyle = BorderStyle.FixedSingle;
            rtbLogInfo.Dock = DockStyle.Fill;
            rtbLogInfo.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbLogInfo.Location = new Point(3, 3);
            rtbLogInfo.Name = "rtbLogInfo";
            rtbLogInfo.ReadOnly = true;
            rtbLogInfo.Size = new Size(297, 151);
            rtbLogInfo.TabIndex = 0;
            rtbLogInfo.Text = "";
            // 
            // FrmConfiguracaoDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(317, 231);
            Controls.Add(tlpPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmConfiguracaoDataBase";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmConfiguracaoDataBase_Load;
            tlpPrincipal.ResumeLayout(false);
            pnFundoTitulo.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            pnPrincipal.ResumeLayout(false);
            tcPrincipal.ResumeLayout(false);
            tpConexao.ResumeLayout(false);
            tpConexao.PerformLayout();
            tpLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpPrincipal;
        private Panel pnFundoTitulo;
        private Panel pnPrincipal;
        private TabControl tcPrincipal;
        private TabPage tpConexao;
        private TabPage tpLog;
        private RichTextBox rtbLogInfo;
        private TableLayoutPanel tlpTitulo;
        private Label lbTitulo;
        private Label lbBaseDados;
        private TextBox txtBaseDados;
        private Label lbServidor;
        private TextBox txtServidor;
        private Button btnSalvar;
        private Button btnTestar;
        private Button btnCancelar;
    }
}