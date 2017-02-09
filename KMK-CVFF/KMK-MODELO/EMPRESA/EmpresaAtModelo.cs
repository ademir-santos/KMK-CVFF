using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.EMPRESA
{
    public class EmpresaAtModelo
    {
        // <TABELA EMPRESA> \\
        private int id_empresa = 0;
        private string razao = null;
        // <TABELA EMPRESA> \\ 

        // <TABELA FUNCIONARIO> \\
        private int id_funcionario = 0;
        private string login = null;
        private string senha = null;
        private int funcao = 0;
        // </TABELA FUNCIONARIO> \\

        // <TABELA PESSOA> \\
        private int id_pessoa = 0;
        private string nome = null;
        // </TABELA PESSOA> \\



        // <TABELA ENDERECO> \\ 
        private int id_endereco = 0;
        private int estado = 0;
        private string estadovl = null;
        private string cidade = null;
        private string bairro = null;
        private string logradouro = null;
        private string numero_end = null;
        // </TABELA ENDERECO> \\ 

        // <TABELA TELEFONE> \\
        private int id_telefone = 0;
        private int tipo = 0;
        private string numero_tel = null;
        private string numero_cel = null;
        private string numero_com = null;
        private string numero_fax = null;
        // </TABELA TELEFONE> \\

        /**/
        private int id_func_emp = 0;
        /**/

        // <TABELA EMPRESA> \\
        public int IDEmpresa
        {
            get { return this.id_empresa; }
            set { this.id_empresa = value; }
        }

        public string Razao
        {
            get { return this.razao; }
            set { this.razao = value; }
        }
        // </TABELA EMPRESA> \\

        // <TABELA FUNCIONARIO> \\ 
        public int IDFuncionario
        {
            get { return this.id_funcionario; }
            set { this.id_funcionario = value; }
        }

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

        public int Funcao
        {
            get { return this.funcao; }
            set { this.funcao = value; }
        }
        // </TABELA FUNCIONARIO> \\ 

        // <TABELA PESSOA> \\ 
        public int IDPessoa
        {
            get { return this.id_pessoa; }
            set { this.id_pessoa = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        // </TABELA PESSOA> \\ 

        // <TABELA ENDERECO> \\ 
        public int IDEnd
        {
            get { return this.id_endereco; }
            set { this.id_endereco = value; }
        }

        public int Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string EstadoVL
        {
            get { return this.estadovl; }
            set { this.estadovl = value; }
        }

        public string Cidade
        {
            get { return this.cidade; }
            set { this.cidade = value; }
        }

        public string Bairro
        {
            get { return this.bairro; }
            set { this.bairro = value; }
        }

        public string Logradouro
        {
            get { return this.logradouro; }
            set { this.logradouro = value; }
        }

        public string NumeroEnd
        {
            get { return this.numero_end; }
            set { this.numero_end = value; }
        }
        // </TABELA ENDERECO> \\

        // <TABELA TELEFONE> \\
        public int IDTelefone
        {
            get { return this.id_telefone; }
            set { this.id_telefone = value; }
        }

        public int Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public string NumeroTel
        {
            get { return this.numero_tel; }
            set { this.numero_tel = value; }
        }

        public string NumeroCel
        {
            get { return this.numero_cel; }
            set { this.numero_cel = value; }
        }

        public string NumeroCom
        {
            get { return this.numero_com; }
            set { this.numero_com = value; }
        }

        public string NumeroFax
        {
            get { return this.numero_fax; }
            set { this.numero_fax = value; }
        }
        // </TABELA TELEFONE> \\ 

        public int IDFuncEmp
        {
            get { return this.id_func_emp; }
            set { this.id_func_emp = value; }
        }
    }
}
