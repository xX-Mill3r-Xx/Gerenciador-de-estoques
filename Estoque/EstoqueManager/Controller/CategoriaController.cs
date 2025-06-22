using EstoqueManager.Data;
using EstoqueManager.Data.Repositories;
using EstoqueManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueManager.Controller
{
    public class CategoriaController
    {
        #region Properties

        private CategoriaRepository _categoriaRepository;

        #endregion

        #region Constructors

        public CategoriaController()
        {
            _categoriaRepository = new CategoriaRepository(StringConnection.Conexao());
        }

        #endregion

        public async Task<IEnumerable<Categorias>> ObterCategorias()
        {
            return await _categoriaRepository.ObterTodos();
        }

        public async Task<Categorias> ObterCategoriasPorId(int id)
        {
            return await _categoriaRepository.ObterPorId(id);
        }

        public async Task<Categorias> ObterCategoriasPorNome(string nome)
        {
            return await _categoriaRepository.ObterPorNome(nome);
        }

        public async Task SalvarCategoria(Categorias categoria)
        {
            await _categoriaRepository.Inserir(categoria);
        }

        public async Task<Categorias> AtualizarCategorias(Categorias categoria)
        {
            return await _categoriaRepository.Atualizar(categoria);
        }

        public async Task<Categorias> DeletarCategoria(int id)
        {
            return await _categoriaRepository.Deletar(id);
        }
    }
}
