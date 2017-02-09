using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.LOGIN
{
    public class LoginPaModelo
    {
        private string login = null;
        private string senha = null;
        private int id_endereco = 0;
        private int id_pessoa = 0;
        private int id_telefone = 0;
        private int id_funcionario = 0;
        private int id_empresa = 0;
        private int funcao = 0;

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public int IDEndereco
        {
            get { return this.id_endereco; }
            set { this.id_endereco = value; }
        }

        public int IDPessoa
        {
            get { return this.id_pessoa; }
            set { this.id_pessoa = value; }
        }

        public int IDTelefone
        {
            get { return this.id_telefone; }
            set { this.id_telefone = value; }
        }

        public int IDFuncionario
        {
            get { return this.id_funcionario; }
            set { this.id_funcionario = value; }
        }

        public int IDEmpresa
        {
            get { return this.id_empresa; }
            set { this.id_empresa = value; }
        }

        public int Funcao
        {
            get { return this.funcao; }
            set { this.funcao = value; }
        }
    }
}
