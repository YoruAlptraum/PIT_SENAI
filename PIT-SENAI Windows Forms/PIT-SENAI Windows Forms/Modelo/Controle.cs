using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_Windows_Forms.DAL;

namespace PIT_SENAI_Windows_Forms.Modelo
{
    public class Controle
    {
        public bool acesso, cadastrado;
        public static bool firstLogin, ultimoPerfilMusico, temPerfilMusico, temPerfilOrganizador,PMusicoPublico;
        public string mensagem = "";
        public static string usuario;
        public static int id;

        AlterarPerfil ap = new AlterarPerfil();
        CadastrarOrganizador co = new CadastrarOrganizador();
        CadastrarMusico cm = new CadastrarMusico();
        Eventos eventos = new Eventos();

        public bool acessar(String Login, String Senha)
        {
            Logar logar = new Logar();
            acesso = logar.verificarLogin(Login, Senha);
            if (!logar.mensagem.Equals(""))
            {
                this.mensagem = logar.mensagem;
            }
            firstLogin = logar.firstLogin;
            ultimoPerfilMusico = AlterarPerfil.ultimoPerfilMusico;
            temPerfilMusico = logar.temPerfilMusico;
            temPerfilOrganizador = logar.temPerfilOrganizador;
            PMusicoPublico = logar.PMusicoPublico;
            id = Logar.userid;
            usuario = Logar.usuario;
            return acesso;
        }

        public String cadastrar(String nome, String usuario, String senha, String email, String cpf)
        {
            Cadastrar cadastrar = new Cadastrar(nome, usuario, senha, email, cpf);

            this.mensagem = cadastrar.mensagem;

            return mensagem;
        }

        public String cadastrarOrganizador(string regiao,string descriçao)
        {
            co.Cadastrar(regiao, descriçao);
            this.mensagem = co.coMensagem;
            this.cadastrado = co.cadastrado;

            firstLogin = co.firstLogin;
            ultimoPerfilMusico = AlterarPerfil.ultimoPerfilMusico;
            temPerfilOrganizador = co.temPerfilOrganizador;

            return mensagem;
        }

        public String cadastrarMusico(List<int> instrumentosID, List<int> estilosID, string regiao, string descriçao, bool publico)
        {
            cm.Cadastrar(instrumentosID,estilosID,regiao,descriçao,publico);
            this.mensagem = cm.cmMensagem;
            this.cadastrado = cm.cadastrado;

            firstLogin = cm.firstLogin;
            ultimoPerfilMusico = AlterarPerfil.ultimoPerfilMusico;
            temPerfilOrganizador = cm.temPerfilMusico;

            return mensagem;
        }

        public DataTable getInstrumentos()
        {
            return cm.getInstrumentos();
        }

        public DataTable getEstilos()
        {
            return cm.getEstilos();
        }
        public void AlterarUltimoPerfil(bool upm)
        {
            //alterar no banco de dados o ultimo perfil acessado, se o ultimo for musico altera para true
            ap.AlterarUltimoPerfil(upm);
            ultimoPerfilMusico = upm;
        }

        public DataTable EventosDosOrganizadores()
        {
            return eventos.EventosDosOrganizadores();
        }

        public DataTable ListaDeEventos()
        {
            return eventos.ListaDeEventos();
        }
    }
}
