using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_MODELO.PRODUTO
{
    public class CategoriaInModelo
    {
        private int id_subcategoria = 0;
        private int categoria = 0;
        private string subcategoria = null;

        public int IDSubCategoria
        {
            get { return this.id_subcategoria; }
            set { this.id_subcategoria = value; }
        }

        public int Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string SubCategoria
        {
            get { return this.subcategoria; }
            set { this.subcategoria = value; }
        }
    }
}
