using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLog.DAL
{
     class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from tb_usuarios where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
            }
            catch(SqlException) 
            {
                this.mensagem = "Erro com o banco de dados!";
            }   
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco
            return mensagem;
        }
    }
}
