namespace EstoqueManager.Data
{
    public static class StringConnection
    {
        public static string Conexao()
        {
            string conexao = @"Server=[SEU SERVIDOR];Database=ESTOQUE;Trusted_Connection=True;";
            return conexao;
        }
    }
}
