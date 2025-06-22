using EstoqueManager.Data;
using EstoqueManager.Data.Repositories;
using EstoqueManager.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Controller
{
    public class MovimentacoesController
    {
        #region Properties

        private readonly MovimentacoesRepository _movimentoRepository;

        #endregion

        #region Constructors

        public MovimentacoesController()
        {
            _movimentoRepository = new MovimentacoesRepository(StringConnection.Conexao());
        }

        #endregion

        public async Task RegistrarEntrada(int produtoId, int Quantidade)
        {
            var movimento = new Movimentacoes
            {
                ProdutoId = produtoId,
                Quantidade = Quantidade,
                Tipo = 'E',
                DataMovimento = DateTime.Now,
            };

            await _movimentoRepository.RegistrarMovimento(movimento);
        }

        public async Task RegistrarSaida(int produtoId, int quantidade)
        {
            var movimento = new Movimentacoes
            {
                ProdutoId = produtoId,
                Quantidade = quantidade,
                Tipo = 'S',
                DataMovimento = DateTime.Now
            };

            await _movimentoRepository.RegistrarMovimento(movimento);
        }

        public async Task<IEnumerable<Movimentacoes>> ObterHistorico(int produtoId)
        {
            return await _movimentoRepository.ObterPorProduto(produtoId);
        }
    }
}
