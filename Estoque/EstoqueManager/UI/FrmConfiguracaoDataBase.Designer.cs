namespace EstoqueManager.UI
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnFundoTitulo = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.lbBaseDados = new System.Windows.Forms.Label();
            this.lbServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBaseDados = new System.Windows.Forms.TextBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Controls.Add(this.pnFundoTitulo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnPrincipal, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.37793F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.62207F));
            this.tlpPrincipal.Size = new System.Drawing.Size(503, 299);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(497, 34);
            this.pnFundoTitulo.TabIndex = 0;
            // 
            // pnPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnPrincipal, 2);
            this.pnPrincipal.Controls.Add(this.pictureBox1);
            this.pnPrincipal.Controls.Add(this.btnTestarConexao);
            this.pnPrincipal.Controls.Add(this.btnSalvar);
            this.pnPrincipal.Controls.Add(this.btnCancelar);
            this.pnPrincipal.Controls.Add(this.lbBaseDados);
            this.pnPrincipal.Controls.Add(this.lbServidor);
            this.pnPrincipal.Controls.Add(this.txtServidor);
            this.pnPrincipal.Controls.Add(this.txtBaseDados);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(3, 43);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(497, 253);
            this.pnPrincipal.TabIndex = 1;
            // 
            // lbBaseDados
            // 
            this.lbBaseDados.AutoSize = true;
            this.lbBaseDados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseDados.Location = new System.Drawing.Point(9, 92);
            this.lbBaseDados.Name = "lbBaseDados";
            this.lbBaseDados.Size = new System.Drawing.Size(84, 15);
            this.lbBaseDados.TabIndex = 10;
            this.lbBaseDados.Text = "Base de Dados";
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServidor.Location = new System.Drawing.Point(9, 33);
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(51, 15);
            this.lbServidor.TabIndex = 9;
            this.lbServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(12, 51);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(302, 23);
            this.txtServidor.TabIndex = 7;
            // 
            // txtBaseDados
            // 
            this.txtBaseDados.Location = new System.Drawing.Point(12, 110);
            this.txtBaseDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBaseDados.Name = "txtBaseDados";
            this.txtBaseDados.Size = new System.Drawing.Size(302, 23);
            this.txtBaseDados.TabIndex = 8;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestarConexao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.Location = new System.Drawing.Point(17, 158);
            this.btnTestarConexao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(88, 27);
            this.btnTestarConexao.TabIndex = 11;
            this.btnTestarConexao.Text = "Testar";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(116, 158);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 27);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(215, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tlpTitulo
            // 
            this.tlpTitulo.ColumnCount = 3;
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitulo.Location = new System.Drawing.Point(0, 0);
            this.tlpTitulo.Name = "tlpTitulo";
            this.tlpTitulo.RowCount = 1;
            this.tlpTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitulo.Size = new System.Drawing.Size(497, 34);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(18, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(249, 21);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Configurações da base de Dados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstoqueManager.Properties.Resources.cadeado_fechado;
            this.pictureBox1.Location = new System.Drawing.Point(381, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConfiguracaoDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 299);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmConfiguracaoDataBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmConfiguracaoDataBase_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbBaseDados;
        private System.Windows.Forms.Label lbServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBaseDados;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}