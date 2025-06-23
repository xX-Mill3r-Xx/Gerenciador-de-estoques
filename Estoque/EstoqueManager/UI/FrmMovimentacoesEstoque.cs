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
    public partial class FrmMovimentacoesEstoque : Form
    {
        #region Properties

        private ProdutoController _produtoController;
        private MovimentacoesController _movimentacoesController;
        private readonly char _tipoMovimentacao;


        #endregion

        #region Events

        public event EventHandler EstoqueAlterado;

        #endregion

        #region Constructors

        public FrmMovimentacoesEstoque(char tipoMovimentacao)
        {
            InitializeComponent();

            _produtoController = new ProdutoController();
            _movimentacoesController = new MovimentacoesController();
            _tipoMovimentacao = tipoMovimentacao;
        }

        #endregion

        private async void FrmMovimentacoesEstoque_Load(object sender, EventArgs e)
        {
            if (_tipoMovimentacao == 'E')
            {
                rbEntrada.Checked = true;
                rbSaida.Enabled = false;
            }
            else if (_tipoMovimentacao == 'S')
            {
                rbSaida.Checked = true;
                rbEntrada.Enabled = false;
            }

            var produtos = await _produtoController.ObterProdutos();
            cbProdutos.DataSource = produtos.ToList();
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "Id";
            cbProdutos.SelectedIndex = -1;
        }

        private async void cbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdutos.SelectedItem is Produto produto)
                await CarregarHistorico(produto.Id);
        }

        private async Task CarregarHistorico(int produtoId)
        {
            var historico = await _movimentacoesController.ObterHistorico(produtoId)
                ?? new List<Movimentacoes>();
            dgvregristros.DataSource = historico.ToList();
            ConfiguracoesDataGridView.ConfiguracoesDgvHistorico(dgvregristros);
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            var produto = cbProdutos.SelectedItem as Produto;
            var quantidade = (int)nudQuantidade.Value;
            if (produto == null || quantidade <= 0)
            {
                MessageBox.Show("Selecione um produto e informe uma quantidade válida!");
                return;
            }

            if (rbEntrada.Checked)
                await _movimentacoesController.RegistrarEntrada(produto.Id, quantidade);
            else if(rbSaida.Checked)
                await _movimentacoesController.RegistrarSaida(produto.Id, quantidade);

            MessageBox.Show("Movimentação registrada com sucesso!");
            EstoqueAlterado?.Invoke(this, EventArgs.Empty);
            await CarregarHistorico(produto.Id);
            await Task.Delay(1000);
            Close();
        }
    }
}
