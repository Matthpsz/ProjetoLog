﻿using ProjetoLog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLog.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;

        }
        public string cadastrar(String email, String senha, string confSenha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if(loginDao.tem)
            {
                this.tem = true;    
            }
            return mensagem;
        }
    }
}
