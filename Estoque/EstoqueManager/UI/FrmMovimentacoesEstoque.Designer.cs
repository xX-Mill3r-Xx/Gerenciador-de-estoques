namespace EstoqueManager.UI
{
    partial class FrmMovimentacoesEstoque
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
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.lbListaProdutos = new System.Windows.Forms.Label();
            this.tlpTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbHistorico = new System.Windows.Forms.GroupBox();
            this.dgvregristros = new System.Windows.Forms.DataGridView();
            this.tlpPrincipal.SuspendLayout();
            this.pnFundoTitulo.SuspendLayout();
            this.pnPrincipal.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tlpTitulo.SuspendLayout();
            this.gbHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregristros)).BeginInit();
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
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(547, 410);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnFundoTitulo
            // 
            this.pnFundoTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
            this.tlpPrincipal.SetColumnSpan(this.pnFundoTitulo, 2);
            this.pnFundoTitulo.Controls.Add(this.tlpTitulo);
            this.pnFundoTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFundoTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnFundoTitulo.Name = "pnFundoTitulo";
            this.pnFundoTitulo.Size = new System.Drawing.Size(541, 24);
            this.pnFundoTitulo.TabIndex = 0;
            // 
            // pnPrincipal
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnPrincipal, 2);
            this.pnPrincipal.Controls.Add(this.gbHistorico);
            this.pnPrincipal.Controls.Add(this.gbProdutos);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(3, 33);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(541, 374);
            this.pnPrincipal.TabIndex = 1;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.btnConfirmar);
            this.gbProdutos.Controls.Add(this.lbListaProdutos);
            this.gbProdutos.Controls.Add(this.rbSaida);
            this.gbProdutos.Controls.Add(this.rbEntrada);
            this.gbProdutos.Controls.Add(this.nudQuantidade);
            this.gbProdutos.Controls.Add(this.cbProdutos);
            this.gbProdutos.Location = new System.Drawing.Point(9, 3);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(523, 85);
            this.gbProdutos.TabIndex = 0;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // cbProdutos
            // 
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(6, 56);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(358, 23);
            this.cbProdutos.TabIndex = 0;
            this.cbProdutos.SelectedIndexChanged += new System.EventHandler(this.cbProdutos_SelectedIndexChanged);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(370, 55);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(66, 23);
            this.nudQuantidade.TabIndex = 1;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEntrada.Location = new System.Drawing.Point(393, 22);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(65, 19);
            this.rbEntrada.TabIndex = 2;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSaida.Location = new System.Drawing.Point(464, 22);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(53, 19);
            this.rbSaida.TabIndex = 3;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saida";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // lbListaProdutos
            // 
            this.lbListaProdutos.AutoSize = true;
            this.lbListaProdutos.Location = new System.Drawing.Point(7, 37);
            this.lbListaProdutos.Name = "lbListaProdutos";
            this.lbListaProdutos.Size = new System.Drawing.Size(98, 15);
            this.lbListaProdutos.TabIndex = 4;
            this.lbListaProdutos.Text = "Lista de Produtos";
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
            this.tlpTitulo.Size = new System.Drawing.Size(541, 24);
            this.tlpTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(18, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(213, 21);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Movimentações de Estoque";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Location = new System.Drawing.Point(442, 55);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbHistorico
            // 
            this.gbHistorico.Controls.Add(this.dgvregristros);
            this.gbHistorico.Location = new System.Drawing.Point(9, 94);
            this.gbHistorico.Name = "gbHistorico";
            this.gbHistorico.Size = new System.Drawing.Size(523, 271);
            this.gbHistorico.TabIndex = 1;
            this.gbHistorico.TabStop = false;
            this.gbHistorico.Text = "Histórico";
            // 
            // dgvregristros
            // 
            this.dgvregristros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregristros.Location = new System.Drawing.Point(6, 22);
            this.dgvregristros.Name = "dgvregristros";
            this.dgvregristros.Size = new System.Drawing.Size(511, 243);
            this.dgvregristros.TabIndex = 0;
            // 
            // FrmMovimentacoesEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 410);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMovimentacoesEstoque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMovimentacoesEstoque_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnFundoTitulo.ResumeLayout(false);
            this.pnPrincipal.ResumeLayout(false);
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tlpTitulo.ResumeLayout(false);
            this.tlpTitulo.PerformLayout();
            this.gbHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregristros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnFundoTitulo;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.TableLayoutPanel tlpTitulo;
        private System.Windows.Forms.Label lbListaProdutos;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbHistorico;
        private System.Windows.Forms.DataGridView dgvregristros;
    }
}