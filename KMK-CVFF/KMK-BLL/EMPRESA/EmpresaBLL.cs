using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMK_MODELO.EMPRESA;
using KMK_DAL.EMPRESA;
using KMK_DAL.CONEXAO;
using System.Data;

namespace KMK_BLL.EMPRESA
{

    public class EmpresaBLL
    {
        private ConexaoDAL Conexao;

        public EmpresaBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirEmpresa(EmpresaInModelo EmpInc = null)
        {
            bool ret = false;
            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            ret = empDAL.IncluirEmpresa(EmpInc);

            return ret;
        }

        public bool AtualizarEmpresa(EmpresaAtModelo EmpAtMD)
        {
            bool ret = false;
            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            ret = empDAL.AtualizarEmpresa(EmpAtMD);

            return ret;
        }

        public DataTable LocalizarPessoa(string MsForms, int id = 0)
        {
            DataTable tabela = new DataTable();

            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            tabela = empDAL.LocalizarPessoa(MsForms, id);

            return tabela;
        }

        public int ValidarPessoa(int id = 0)
        {
            int valor = 0;
            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            valor = empDAL.ValidarPessoa(id);

            return valor;
        }

        public DataTable DtgrMDEmpresa()
        {
            DataTable tabela = new DataTable();

            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            tabela = empDAL.DtgrMDEmpresa();

            return tabela;
        }

        public DataTable LocalizarEmpresa(string razao = null)
        {
            DataTable tabela = new DataTable();

            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            tabela = empDAL.LocalizarEmpresa();

            return tabela;
        }

        public EmpresaPaModelo ParametrosAtualizaEmpForm(string @razao, int @indice)
        {
            EmpresaPaModelo EmpUpMd = new EmpresaPaModelo();
            EmpresaDAL empDAL = new EmpresaDAL(this.Conexao);

            EmpUpMd = empDAL.ParametrosAtualizaEmpForm(@razao, @indice);

            return EmpUpMd;
        }


    }
}

