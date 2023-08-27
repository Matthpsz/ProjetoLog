using ProjetoLog.Forms;

namespace ProjetoLog
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}