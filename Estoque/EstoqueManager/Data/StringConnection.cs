namespace EstoqueManager.Data
{
    public static class StringConnection
    {
        public static string Conexao()
        {
            string conexao = @"Server=DESKTOP-P27GR0I\SQLEXPRESS;Database=ESTOQUE;Trusted_Connection=True;";
            return conexao;
        }
    }
}
