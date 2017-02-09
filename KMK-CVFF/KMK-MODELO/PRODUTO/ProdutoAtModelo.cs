using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.PRODUTO
{
    public class ProdutoAtModelo
    {
        private int id_produto = 0;
        private string produto = null;
        private decimal preco = 0;
        private int id_subcategoria = 0;
        private int id_funcionario = 0;
        private DateTime data_criacao;
        private int id_unidadevenda = 0;

        public int IDProduto
        {
            get { return this.id_produto; }
            set { this.id_produto = value; }
        }

        public string Produto
        {
            get { return this.produto; }
            set { this.produto = value; }
        }

        public decimal Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public int IDSubCategoria
        {
            get { return this.id_subcategoria; }
            set { this.id_subcategoria = value; }
        }

        public int IDFuncionario
        {
            get { return this.id_funcionario; }
            set { this.id_funcionario = value; }
        }

        private DateTime DataCriada
        {
            get { return this.data_criacao; }
            set { this.data_criacao = value; }
        }

        private int IDUnidadeVenda
        {
            get { return this.id_unidadevenda; }
            set { this.id_unidadevenda = value; }
        }
    }
}
