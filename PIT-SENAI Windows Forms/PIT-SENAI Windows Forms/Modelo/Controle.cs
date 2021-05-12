﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_Windows_Forms.DAL;

namespace PIT_SENAI_Windows_Forms.Modelo
{
    public class Controle
    {
        public bool acesso, firstLogin, ultimoPerfilMusico, temPerfilMusico, temPerfilOrganizador;
        public string mensagem = "";
        public string id,usuario;
        public bool acessar(String Login, String Senha)
        {
            Logar logar = new Logar();
            acesso = logar.verificarLogin(Login, Senha);
            if (!logar.mensagem.Equals(""))
            {
                this.mensagem = logar.mensagem;
            }
            this.firstLogin = logar.firstLogin;
            this.ultimoPerfilMusico = logar.ultimoPerfilMusico;
            this.temPerfilMusico = logar.temPerfilMusico;
            this.temPerfilOrganizador = logar.temPerfilOrganizador;
            return acesso;
        }

        public String cadastrar(String nome, String usuario, String senha, String email, String cpf)
        {
            Cadastrar cadastrar = new Cadastrar(nome, usuario, senha, email, cpf);

            this.mensagem = cadastrar.mensagem;

            return mensagem;
        }
    }
}
