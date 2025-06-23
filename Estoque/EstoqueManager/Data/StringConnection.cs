using EstoqueManager.Models.Configuracoes;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace EstoqueManager.Data
{

    public class StringConnection
    {
        public static string Servidor { get; set; } = "";
        public static string BaseDados { get; set; } = "";

        public static string Conexao()
        {
            string conexao = $@"Server={Servidor};Database={BaseDados};Trusted_Connection=True;";
            return conexao;
        }

        public static bool SalvarConfiguracoees()
        {
            try
            {
                ConfiguracaoBD config = new ConfiguracaoBD
                {
                    Servidor = Servidor,
                    BaseDados = BaseDados,
                };
                XmlSerializer serializer = new XmlSerializer(typeof(ConfiguracaoBD));
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_bd.xml");

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, config);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CarregarConfiguracoes()
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_bd.xml");

                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ConfiguracaoBD));

                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        ConfiguracaoBD config = (ConfiguracaoBD)serializer.Deserialize(reader);
                        Servidor = config.Servidor;
                        BaseDados = config.BaseDados;
                    }

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool TestarConexao()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao()))
                {
                    connection.Open();
                    return connection.State == System.Data.ConnectionState.Open;
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}
