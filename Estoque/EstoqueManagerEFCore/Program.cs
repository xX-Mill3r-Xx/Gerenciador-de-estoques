using EstoqueManagerEFCore.Data;
using EstoqueManagerEFCore.UI;
using EstoqueManagerEFCore.Util;

namespace EstoqueManagerEFCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            bool configuracoesBDCarregadas = StringConnection.CarregarConfiguracoes();

            if (!configuracoesBDCarregadas || !StringConnection.TestarConexao())
            {
                using (FrmConfiguracaoDataBase frm = new FrmConfiguracaoDataBase())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        if (!configuracoesBDCarregadas)
                        {
                            MessageBox.Show(Mensagens.ConfigurarDataBase,
                                Mensagens.ConfiguracaoObrigatoria, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            Application.Run(new MainForm());
        }
    }
}