﻿using EstoqueManager.Data;
using EstoqueManager.Data.Repositories;
using EstoqueManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Controller
{
    public class ProdutoController
    {
        #region Properties

        private ProdutoRepository _produtoRepository;

        #endregion

        #region Constructors

        public ProdutoController()
        {
            _produtoRepository = new ProdutoRepository(StringConnection.Conexao());
        }

        #endregion

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _produtoRepository.ObterTodos();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorCategoria(int categoriaId)
        {
            return await _produtoRepository.ObterPorCategoria(categoriaId);
        }

        public async Task<Produto> ObterProdutosPorId(int id)
        {
            return await _produtoRepository.ObterPorId(id);
        }

        public async Task<Produto> ObterProdutosPorNome(string nome)
        {
            return await _produtoRepository.ObterPorNome(nome);
        }

        public async Task SalvarProduto(Produto produto)
        {
            await _produtoRepository.Inserir(produto);
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            return await _produtoRepository.Atualizar(produto);
        }

        public async Task<Produto> DeletarProduto(int id)
        {
            return await _produtoRepository.Deletar(id);
        }

        public async Task<bool> ProdutoPossuiMovimentacoes(int produtoId)
        {
            return await _produtoRepository.PossuiMovimentacoes(produtoId);
        }
    }
}
