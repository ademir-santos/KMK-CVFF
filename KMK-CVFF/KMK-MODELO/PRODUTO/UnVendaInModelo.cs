using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.PRODUTO
{
    public class UnVendaInModelo
    {
        private int id_unidadevenda = 0;
        private string sigla = null;
        private string unidade_venda = null;

        public int IDUnidadeVenda
        {
            get { return this.id_unidadevenda; }
            set { this.id_unidadevenda = value; }
        }

        public string Sigla
        {
            get { return this.sigla; }
            set { this.sigla = value; }
        }

        public string UnidadeVenda
        {
            get { return this.unidade_venda; }
            set { this.unidade_venda = value; }
        }
    }
}
