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
                conn.desconectar();
                dr.Close();
            }
            catch(SqlException) 
            {
                this.mensagem = "Erro com o banco de dados!";
            }   
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            tem = false;
            //comandos para inserir no banco
            if(senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into tb_usuarios values (@e, @s)";
                cmd.Parameters.AddWithValue("@e",email);
                cmd.Parameters.AddWithValue("@s",senha);

                try
                {
                 cmd.Connection = conn.conectar();
                    cmd.ExecuteNonQuery();
                    conn.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException) 
                {
                    this.mensagem = "Erro com Banco de dados";
                }
            }else
            {
                this.mensagem = "Senhas não correspondem!";
            }
           
            return mensagem;
        }
    }
}
