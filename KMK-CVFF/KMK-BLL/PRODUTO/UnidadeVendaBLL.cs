using KMK_DAL.CONEXAO;
using KMK_MODELO.PRODUTO;
using KMK_DAL.PRODUTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KMK_BLL.PRODUTO
{
    public class UnidadeVendaBLL
    {
        private ConexaoDAL Conexao;

        public UnidadeVendaBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public DataTable LocalizarUnidadeVenda(string @sigla = null, string @unidade = null)
        {
            DataTable tabela = new DataTable();

            UnidadeVendaDAL UnVdDal = new UnidadeVendaDAL(this.Conexao);

            tabela = UnVdDal.LocalizarUnidadeVenda(@sigla, @unidade);

            return tabela;
        }

        public DataTable DtgrUnidadeVenda()
        {
            DataTable tabela = new DataTable();

            UnidadeVendaDAL UnVdDal = new UnidadeVendaDAL(this.Conexao);

            tabela = UnVdDal.DtgrUnidadeVenda();

            return tabela;
        }
    }
}
