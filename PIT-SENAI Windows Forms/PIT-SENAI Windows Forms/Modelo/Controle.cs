using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_Windows_Forms.DAL;

namespace PIT_SENAI_Windows_Forms.Modelo
{
    public class Controle
    {
        public bool acesso;
        public string mensagem = "";
        public bool acessar(String Login, String Senha)
        {
            Logar logar = new Logar();
            acesso = logar.verificarLogin(Login, Senha);
            if (!logar.mensagem.Equals(""))
            {
                this.mensagem = logar.mensagem;
            }
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
