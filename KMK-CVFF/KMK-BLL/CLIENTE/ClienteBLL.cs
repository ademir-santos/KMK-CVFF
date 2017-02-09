/*[K.M.K CONSULTORIA]**/
using KMK_DAL.CLIENTE;
using KMK_DAL.CONEXAO;
using KMK_MODELO.CLIENTE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_BLL.CLIENTE
{
    public class ClienteBLL
    {
        private ConexaoDAL Conexao;


        public ClienteBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirCliente(ClienteInModelo CliInMd, string @form = null)
        {
            bool ret = false;

            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);

            ret = CliDAL.IncluirCliente(CliInMd, @form);

            return ret;
        }

        public bool AtualizarCliente(ClienteAtModelo CliAtMD)
        {
            bool ret = false;
            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);

            ret = CliDAL.AtualizarCliente(CliAtMD);

            return ret;
        }

        public bool ValidarCliente(string @nome = null, string @form = null)
        {
            bool ret = false;

            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);

            ret = CliDAL.ValidarCliente();

            return ret;
        }

        public DataTable ListarPessoa()
        {
            DataTable tabela = new DataTable();

            ClienteDAL empDAL = new ClienteDAL(this.Conexao);

            tabela = empDAL.ListarPessoa();

            return tabela;
        }

        public DataTable DtgrMDCliente()
        {
            DataTable tabela = new DataTable();

            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);

            tabela = CliDAL.DtgrMDCliente();

            return tabela;
        }

        public DataTable LocalizarCliente(string @nome = null)
        {
            DataTable tabela = new DataTable();

            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);

            tabela = CliDAL.LocalizarCliente(@nome);

            return tabela;
        }

        public ClientePaModelo ParametrosAtualizaClienteForm(string @nome = null)
        {
            ClienteDAL CliDAL = new ClienteDAL(this.Conexao);
            return CliDAL.ParametrosAtualizaCliForm(@nome);
        }
    }
}
/*[K.M.K CONSULTORIA]**/
