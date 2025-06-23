using System;

namespace EstoqueManager.Models.Configuracoes
{
    [Serializable]
    public class ConfiguracaoBD
    {
        public string Servidor { get; set; }
        public string BaseDados { get; set; }

        public ConfiguracaoBD()
        {
            Servidor = string.Empty;
            BaseDados = string.Empty;
        }
    }
}
