using KMK_DAL.CONEXAO;
using KMK_DAL.PRODUTO;
using KMK_MODELO.PRODUTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_BLL.PRODUTO
{
    public class ProdutoBLL
    {
        private ConexaoDAL Conexao;

        public ProdutoBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirProduto(ProdutoInModelo ProdInMd = null)
        {
            bool ret = false;
            ProdutoDAL ProdDAL = new ProdutoDAL(this.Conexao);

            ret = ProdDAL.IncluirProduto(ProdInMd);

            return ret;
        }

        public DataTable DtgrMDProduto()
        {
            DataTable tabela = new DataTable();

            ProdutoDAL ProdDAL = new ProdutoDAL(this.Conexao);

            tabela = ProdDAL.DtgrProduto();

            return tabela;
        }
    }
}
