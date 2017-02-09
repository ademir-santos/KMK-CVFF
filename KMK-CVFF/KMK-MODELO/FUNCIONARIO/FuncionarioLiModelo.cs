// [KMKCONSULTORIA] \\
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.FUNCIONARIO
{
    public class FuncionarioLiModelo
    {
        ////// [Variaveis Privadas] \\\\\\
        // Tabela Funcionario
        private int id_funcionario = 0;
        private string login = null;
        private string senha = null;
        private string consenha = null;
        private int funcao = 0;
        // Tabela Pessoa
        private int id_pessoa = 0;
        private string nome = null;
        private DateTime aniversario;
        // Tabela Endereco
        private int id_endereco = 0;
        private int estado = 0;
        private string estadovl = null;
        private string cidade = null;
        private string bairro = null;
        private string logradouro = null;
        private string numero_end = null;
        private string complemento = null;
        // Tabela Funcionario_Empresa
        private int id_func_emp = 0;
        private int id_empresa = 0;
        // Tabela Telefone_Pessoa
        private int id_tel_pes = 0;
        // Tabela Telefone
        private int id_telefone = 0;
        private int tipo = 0;
        private string numero_tel = null;
        private string numero_cel = null;
        // Tabela Empresa
        private string razao = null;

        ////// [Construtor] \\\\\\
        // TABELA FUNCIONARIO 
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

        public string ConSenha
        {
            get { return this.consenha; }
            set { this.consenha = value; }
        }

        public int Funcao
        {
            get { return this.funcao; }
            set { this.funcao = value; }
        }
        // TABELA FUNCIONARIO 

        // TABELA PESSOA 
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

        public DateTime Aniversario
        {
            get { return this.aniversario; }
            set { this.aniversario = value; }
        }
        // TABELA PESSOA 

        // TABELA ENDERECO 
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

        public string Complemento
        {
            get { return this.complemento; }
            set { this.complemento = value; }
        }
        // TABELA ENDERECO 

        // TABELA FUNCIONARIO_EMPRESA 
        public int IDFuncEmp
        {
            get { return this.id_func_emp; }
            set { this.id_func_emp = value; }
        }

        public int IDEmpresa
        {
            get { return this.id_empresa; }
            set { this.id_empresa = value; }
        }
        // TABELA FUNCIONARIO_EMPRESA 

        // TABELA TELEFONE_PESSOA 
        public int IDTelPes
        {
            get { return this.id_tel_pes; }
            set { this.id_tel_pes = value; }
        }
        // TABELA TELEFONE_PESSOA 

        // TABELA TELEFONE
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
        // TABELA TELEFONE 

        // TABELA EMPRESA
        public string Razao
        {
            get { return this.razao; }
            set { this.razao = value; }
        }
        // TABELA EMPRESA
    }
}
// [KMKCONSULTORIA] \\