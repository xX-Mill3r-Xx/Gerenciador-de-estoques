using EstoqueManagerEFCore.Data;

namespace EstoqueManagerEFCore.UI
{
    public partial class FrmConfiguracaoDataBase : Form
    {
        public FrmConfiguracaoDataBase()
        {
            InitializeComponent();
        }

        private void FrmConfiguracaoDataBase_Load(object sender, EventArgs e)
        {
            StringConnection.CarregarConfiguracoes();

            txtServidor.Text = StringConnection.Servidor;
            txtBaseDados.Text = StringConnection.BaseDados;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            StringConnection.Servidor = txtServidor.Text.Trim();
            StringConnection.BaseDados = txtBaseDados.Text.Trim();

            if (StringConnection.TestarConexao())
            {
                MessageBox.Show("Conexão estabelecida com sucesso", "Teste de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não foi possivel estabelecer conexão com a base de dados. Verifique as informações e tente novamente",
                    "Teste de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServidor.Text) || string.IsNullOrWhiteSpace(txtBaseDados.Text))
            {
                MessageBox.Show("Por favor, preencha os campos necessários para se conectar",
                   "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringConnection.Servidor = txtServidor.Text.Trim();
            StringConnection.BaseDados = txtBaseDados.Text.Trim();

            if (StringConnection.SalvarConfiguracoees())
            {
                MessageBox.Show("Configurações salvas com sucesso!", "Salvar Configurações",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar as configurações. Verifique as informações e tente novamente",
                    "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
