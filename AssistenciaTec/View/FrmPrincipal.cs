using AssistenciaTec.Data;

namespace AssistenciaTec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemConectar_Click(object sender, EventArgs e)
        {
            Conexao.GetConexao();
        }

    }
}
