using EstoqueManager.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstoqueManager.Configuracoes
{
    public static class ConfiguracoesComboBox
    {
        public static ComboBox ConfiguracoesComboboxCategoria(ComboBox cbCategoria, List<Categorias> categorias)
        {
            cbCategoria.Cursor = Cursors.Hand;
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Id";
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.SelectedIndex = -1;

            return cbCategoria;
        }
    }
}
