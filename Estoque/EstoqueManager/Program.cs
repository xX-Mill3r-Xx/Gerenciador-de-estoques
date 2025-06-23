using EstoqueManager.Data;
using EstoqueManager.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool configuracoesBDCarregadas = StringConnection.CarregarConfiguracoes();

            if (!configuracoesBDCarregadas || !StringConnection.TestarConexao())
            {
                using (FrmConfiguracaoDataBase frm = new FrmConfiguracaoDataBase())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        if (!configuracoesBDCarregadas)
                        {
                            MessageBox.Show("É necessário configurar o banco de dados para usar o sistema.",
                                "Configuração nessesária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            Application.Run(new MainForm());
        }
    }
}
