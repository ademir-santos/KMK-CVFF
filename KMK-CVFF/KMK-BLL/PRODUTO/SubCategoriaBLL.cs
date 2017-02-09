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
    public class SubCategoriaBLL
    {
        private ConexaoDAL Conexao;

        public SubCategoriaBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirSubCategoria(CategoriaInModelo CatInMd = null)
        {
            bool ret = false;
            SubCategoriaDAL SubCatDAL = new SubCategoriaDAL(this.Conexao);

            ret = SubCatDAL.IncluirSubCategoria(CatInMd);

            return ret;
        }

        public DataTable DtgrSubCategoria()
        {
            DataTable tabela = new DataTable();

            SubCategoriaDAL SubCatDAL = new SubCategoriaDAL(this.Conexao);

            tabela = SubCatDAL.DtgrSubCategoria();

            return tabela;
        }

        public DataTable LocalizarSubCategoria(int @categoria = 0)
        {
            DataTable tabela = new DataTable();

            SubCategoriaDAL SubCatDAL = new SubCategoriaDAL(this.Conexao);

            tabela = SubCatDAL.LocalizarSubCategoria(@categoria);

            return tabela;
        }
    }
}
