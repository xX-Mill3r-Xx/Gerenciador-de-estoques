using EstoqueManager.Models;
using System;

namespace EstoqueManager.Util
{
    public static class Mensagens
    {
        #region ToolTips

        public static string Salvarproduto => "Salvar produto";
        public static string FecharAplicacao => "Fechar Aplicação";
        public static string NovaCategoria => "Nova categoria";
        public static string BuscarProdutos => "Buscar Produto(s)";

        #endregion

        #region Informações

        public static string Atencao => "Atencao";
        public static string Erro => "Erro";
        public static string Aviso => "Aviso";
        public static string Sucesso => "Sucesso!";
        public static string Confirma => "Confirma?";
        public static string AcaoNaoPermitida => "Ação não permitida";

        #endregion

        #region Retorno dos produtos

        public static string VerifiqueOsDadosInseridos => "Verifique os dados inseridos!";
        public static string ProdutoSalvoComSucesso => "Produto salvo com sucesso!";

        #endregion

        #region Comum

        public static string NenhumRegistroLocalizado => "Nenhum registro encontrado com este Id";
        public static string AtualizadoComSucesso => "Registro atualizado com sucesso!";
        public static string ErroDeAtualizacao => "Erro ao atualizar registro!";

        #endregion

        public static string ErroAoInserir(Exception ex)
        {
            string mensagem = $"Erro ao inserir: {ex.Message}";
            return mensagem;
        }

        public static string ErroDeBusca(Exception ex)
        {
            string mensagem = $"Erro ao buscar registros: {ex.Message}";
            return mensagem;
        }

        public static string ExclusaoCompleta(string item)
        {
            string mensagem = $"{item} excluido com sucesso!";
            return mensagem;
        }

        public static string ExcluirItem(string item)
        {
            string mensagem = $"Deseja realmente excluir \"{item}\"?";
            return mensagem;
        }

        public static string ProdutoBloqueadoParaExclusao(int produtoId)
        {
            string mensagem = $"Produto {produtoId} não pode ser excluido pois possui movimentações";
            return mensagem;
        }
    }
}
