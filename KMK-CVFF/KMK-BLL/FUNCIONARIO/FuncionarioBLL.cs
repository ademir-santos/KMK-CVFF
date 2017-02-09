using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMK_MODELO.FUNCIONARIO;
using KMK_DAL.FUNCIONARIO;
using KMK_DAL.CONEXAO;
using System.Data;

namespace KMK_BLL.FUNCIONARIO
{
    public class FuncionarioBLL
    {
        private ConexaoDAL Conexao;

        public FuncionarioBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirFuncionario(FuncionarioInModelo fc)
        {
            bool ret = false;
            FuncionarioDAL fcdl = new FuncionarioDAL(this.Conexao);

            ret = fcdl.IncluirFuncionario(fc);

            return ret;
        }

        public bool AtualizarFuncionario(FuncionarioAtModelo fcMD)
        {
            bool ret = false;
            FuncionarioDAL fcdl = new FuncionarioDAL(this.Conexao);

            ret = fcdl.AtualizarFuncionario(fcMD);

            return ret;
        }

        public DataTable DtgrMDCadFuncionario()
        {
            FuncionarioDAL fcdal = new FuncionarioDAL(this.Conexao);
            DataTable tabela = new DataTable();
            tabela = fcdal.DtgrMDCadFuncionario();

            return tabela;
        }

        public DataTable ComboBoxEmpresa(string @form = null, string @razao = null)
        {
            FuncionarioDAL fcdal = new FuncionarioDAL(this.Conexao);
            DataTable tabela = new DataTable();
            tabela = fcdal.ComboBoxEmpresa(@form, @razao);

            return tabela;
        }

        public void ExcluirFuncionario(FuncionarioInModelo fc)
        {
            FuncionarioDAL fcdl = new FuncionarioDAL(this.Conexao);
            fcdl.ExcluirFuncionario(fc);
        }

        public FuncionarioPaModelo ParametrosAtualizaFunForm(string @login, string @nome, int @indice)
        {
            FuncionarioDAL fcdl = new FuncionarioDAL(this.Conexao);
            return fcdl.ParametrosAtualizaFunForm(@login, @nome, @indice);
        }

    }
}
