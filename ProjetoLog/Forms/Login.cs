using ProjetoLog.Forms;
using ProjetoLog.Modelo;
using System.ComponentModel.Design;

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

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(tb_login.Text, tb_senha.Text);
            if (controle.mensagem.Equals(""))
                if (controle.tem)
                {
                    MessageBox.Show("logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal principal = new Principal();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}