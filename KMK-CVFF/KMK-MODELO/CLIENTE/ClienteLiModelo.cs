using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.CLIENTE
{
    public class ClienteLiModelo
    {
        ////// [Variaveis Privadas] \\\\\\
        /*<TABELA CLIENTE>*/
        private int id_cliente = 0;
        private string codigo = null;
        /*</TABELA CLIENTE>*/

        /*<TABELA PESSOA>*/
        private int id_pessoa = 0;
        private string nome = null;
        private DateTime aniversario;
        /*</TABELA PESSOA>*/

        /*<TABELA ENDERECO>*/
        private int id_endereco = 0;
        private int estado = 0;
        private string estadovl = null;
        private string cidade = null;
        private string bairro = null;
        private string logradouro = null;
        private string numero_end = null;
        /*</TABELA ENDERECO>*/

        /*<TABELA TELEFONE>*/
        private int id_telefone = 0;
        private string numero_tel = null;
        private string numero_cel = null;
        /*</TABELA TELEFONE>*/

        /*<TABELA PROMOCAO CLIENTE>*/
        private int id_prmc_clint = 0;
        /*</TABELA PROMOCAO CLIENTE>*/

        /*<TABELA PROMOCAO>*/
        private int id_promocao = 0;
        private string promocao = null;
        /*</TABELA PROMOCAO>*/

        ////// [Construtor] \\\\\\

        /*<TABELA CLIENTE>*/
        public int IDCliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        /*</TABELA CLIENTE>*/

        /*<TABELA PESSOA>*/
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
        /*</TABELA PESSOA>*/

        /*<TABELA ENDERECO>*/
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
        /*</TABELA ENDERECO>*/

        /*<TABELA TELEFONE>*/
        public int IDTelefone
        {
            get { return this.id_telefone; }
            set { this.id_telefone = value; }
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
        /*</TABELA TELEFONE>*/

        /*<TABELA PROMOCAO CLIENTE>*/
        public int IDPrmcClint
        {
            get { return this.id_prmc_clint; }
            set { this.id_prmc_clint = value; }
        }
        /*</TABELA PROMOCAO CLIENTE>*/

        /*<TABELA PROMOCAO>*/
        public int IDPromocao
        {
            get { return this.id_promocao; }
            set { this.id_prmc_clint = value; }
        }

        public string Promocao
        {
            get { return this.promocao; }
            set { this.promocao = value; }
        }
        /*</TABELA PROMOCAO>*/
    }
}
