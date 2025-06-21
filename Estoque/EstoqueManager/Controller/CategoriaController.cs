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
    }
}
