using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueManager.Funcoes
{
    public static class FuncaoToolTip
    {
        public static ToolTip RetornaToolTip(Button btn, string descricao)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn, descricao);
            return toolTip;
        }
    }
}
