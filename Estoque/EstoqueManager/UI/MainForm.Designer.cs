﻿namespace EstoqueManager
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnBarraSuperior = new System.Windows.Forms.Panel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnLatera = new System.Windows.Forms.Panel();
            this.pnControles = new System.Windows.Forms.Panel();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.pnDataGrid = new System.Windows.Forms.Panel();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnProdutos = new System.Windows.Forms.Panel();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnInserirCategoria = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnBarraSuperior.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnLatera.SuspendLayout();
            this.pnControles.SuspendLayout();
            this.pnDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.pnProdutos.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnBarraSuperior, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnLatera, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnProdutos, 1, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.tlpPrincipal.Size = new System.Drawing.Size(893, 701);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnBarraSuperior
            // 
            this.tlpPrincipal.SetColumnSpan(this.pnBarraSuperior, 2);
            this.pnBarraSuperior.Controls.Add(this.tlpTop);
            this.pnBarraSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBarraSuperior.Location = new System.Drawing.Point(3, 3);
            this.pnBarraSuperior.Name = "pnBarraSuperior";
            this.pnBarraSuperior.Size = new System.Drawing.Size(887, 38);
            this.pnBarraSuperior.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
            this.tlpTop.ColumnCount = 7;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.008827F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.99117F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpTop.Controls.Add(this.btnMaximizar, 3, 0);
            this.tlpTop.Controls.Add(this.btnClose, 5, 0);
            this.tlpTop.Controls.Add(this.lbTitulo, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(887, 38);
            this.tlpTop.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(5, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(287, 38);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Gerenciamento de estoque";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnLatera
            // 
            this.pnLatera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(149)))), ((int)(((byte)(158)))));
            this.pnLatera.Controls.Add(this.btnConfig);
            this.pnLatera.Controls.Add(this.btnRelatorios);
            this.pnLatera.Controls.Add(this.btnSaida);
            this.pnLatera.Controls.Add(this.btnEntradas);
            this.pnLatera.Controls.Add(this.btnProdutos);
            this.pnLatera.Controls.Add(this.btnDashBoard);
            this.pnLatera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLatera.Location = new System.Drawing.Point(3, 47);
            this.pnLatera.Name = "pnLatera";
            this.tlpPrincipal.SetRowSpan(this.pnLatera, 2);
            this.pnLatera.Size = new System.Drawing.Size(164, 651);
            this.pnLatera.TabIndex = 1;
            // 
            // pnControles
            // 
            this.pnControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.tlpProdutos.SetColumnSpan(this.pnControles, 2);
            this.pnControles.Controls.Add(this.btnInserirCategoria);
            this.pnControles.Controls.Add(this.btnNovoProduto);
            this.pnControles.Controls.Add(this.lbCategoria);
            this.pnControles.Controls.Add(this.cbCategoria);
            this.pnControles.Controls.Add(this.lbPreco);
            this.pnControles.Controls.Add(this.txtPreco);
            this.pnControles.Controls.Add(this.txtQuantidade);
            this.pnControles.Controls.Add(this.lbQuantidade);
            this.pnControles.Controls.Add(this.btnAdicionar);
            this.pnControles.Controls.Add(this.btnProcurar);
            this.pnControles.Controls.Add(this.txtProdutos);
            this.pnControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControles.Location = new System.Drawing.Point(3, 3);
            this.pnControles.Name = "pnControles";
            this.pnControles.Size = new System.Drawing.Size(711, 144);
            this.pnControles.TabIndex = 2;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNovoProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.Location = new System.Drawing.Point(3, 8);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(95, 29);
            this.btnNovoProduto.TabIndex = 11;
            this.btnNovoProduto.Text = "Novo Produto";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(3, 64);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(81, 21);
            this.lbCategoria.TabIndex = 10;
            this.lbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "",
            "Eletronicos"});
            this.cbCategoria.Location = new System.Drawing.Point(107, 56);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(420, 29);
            this.cbCategoria.TabIndex = 9;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(3, 93);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(79, 21);
            this.lbPreco.TabIndex = 8;
            this.lbPreco.Text = "Preço R$:";
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Location = new System.Drawing.Point(107, 91);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(82, 23);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(246, 91);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(47, 23);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(195, 93);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(45, 21);
            this.lbQuantidade.TabIndex = 5;
            this.lbQuantidade.Text = "Qte.:";
            // 
            // txtProdutos
            // 
            this.txtProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutos.Location = new System.Drawing.Point(107, 8);
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(420, 29);
            this.txtProdutos.TabIndex = 0;
            this.txtProdutos.TextChanged += new System.EventHandler(this.txtProdutos_TextChanged);
            // 
            // pnDataGrid
            // 
            this.pnDataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.tlpProdutos.SetColumnSpan(this.pnDataGrid, 2);
            this.pnDataGrid.Controls.Add(this.dgvRegistros);
            this.pnDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataGrid.Location = new System.Drawing.Point(3, 153);
            this.pnDataGrid.Name = "pnDataGrid";
            this.pnDataGrid.Size = new System.Drawing.Size(711, 495);
            this.pnDataGrid.TabIndex = 3;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistros.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(711, 495);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            this.dgvRegistros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellEndEdit);
            this.dgvRegistros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegistros_KeyDown);
            // 
            // pnProdutos
            // 
            this.pnProdutos.Controls.Add(this.tlpProdutos);
            this.pnProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProdutos.Location = new System.Drawing.Point(173, 47);
            this.pnProdutos.Name = "pnProdutos";
            this.tlpPrincipal.SetRowSpan(this.pnProdutos, 2);
            this.pnProdutos.Size = new System.Drawing.Size(717, 651);
            this.pnProdutos.TabIndex = 4;
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 2;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProdutos.Controls.Add(this.pnControles, 0, 0);
            this.tlpProdutos.Controls.Add(this.pnDataGrid, 0, 1);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(0, 0);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 2;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProdutos.Size = new System.Drawing.Size(717, 651);
            this.tlpProdutos.TabIndex = 4;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::EstoqueManager.Properties.Resources.Redimensionar;
            this.btnMaximizar.Location = new System.Drawing.Point(790, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(32, 32);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::EstoqueManager.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(836, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Image = global::EstoqueManager.Properties.Resources.Relatorios;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(9, 208);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(151, 40);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnSaida
            // 
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Image = global::EstoqueManager.Properties.Resources.Saida;
            this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.Location = new System.Drawing.Point(9, 162);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(151, 40);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Saidas";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Image = global::EstoqueManager.Properties.Resources.Entrada;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Location = new System.Drawing.Point(9, 116);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(151, 40);
            this.btnEntradas.TabIndex = 2;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Image = global::EstoqueManager.Properties.Resources.Products;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(9, 70);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(151, 40);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Image = global::EstoqueManager.Properties.Resources.Dashboard;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(9, 24);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(151, 40);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "Dashboard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnInserirCategoria
            // 
            this.btnInserirCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirCategoria.FlatAppearance.BorderSize = 0;
            this.btnInserirCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInserirCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInserirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirCategoria.Image = global::EstoqueManager.Properties.Resources.adicionar;
            this.btnInserirCategoria.Location = new System.Drawing.Point(533, 52);
            this.btnInserirCategoria.Name = "btnInserirCategoria";
            this.btnInserirCategoria.Size = new System.Drawing.Size(33, 33);
            this.btnInserirCategoria.TabIndex = 12;
            this.btnInserirCategoria.UseVisualStyleBackColor = true;
            this.btnInserirCategoria.Click += new System.EventHandler(this.btnInserirCategoria_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = global::EstoqueManager.Properties.Resources.Salvar;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(618, 77);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(74, 57);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Image = global::EstoqueManager.Properties.Resources.Procurar;
            this.btnProcurar.Location = new System.Drawing.Point(533, 5);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(32, 32);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::EstoqueManager.Properties.Resources.configuracoes;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(10, 602);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(151, 40);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "Config.";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 701);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pnBarraSuperior.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.pnLatera.ResumeLayout(false);
            this.pnControles.ResumeLayout(false);
            this.pnControles.PerformLayout();
            this.pnDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.pnProdutos.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnBarraSuperior;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnLatera;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.Panel pnDataGrid;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnInserirCategoria;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnProdutos;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnConfig;
    }
}

