/*[KMKCONSULTORIA]*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KMK_MODELO.BALCAO
{
    public class BalcaoAtModelo
    {
        private int id_vdbalcao = 0;
        private int nfiscal = 0;
        private decimal total = 0;
        private int status = 0;
        private int id_tppagamento = 0;
        private DateTime dtvenda = DateTime.Now;

        private int id_pclvendabll = 0;
        private decimal parcelasblc_valor = 0;
        private DateTime parcelasblc_datapg;
        private DateTime parcelasblc_vencimento;

        private string tipo_pg = null;

        private int id_prodvendabl = 0;
        private int id_produto = 0;

        public int IDVendaBalcao
        {
            get { return this.id_vdbalcao; }
            set { this.id_vdbalcao = value; }
        }

        public int NFiscal
        {
            get { return this.nfiscal; }
            set { this.nfiscal = value; }
        }

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public int Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int IDTipoPagamento
        {
            get { return this.id_tppagamento; }
            set { this.id_tppagamento = value; }
        }

        public DateTime DataVenda
        {
            get { return this.dtvenda; }
            set { this.dtvenda = value; }
        }

        public int IDParcelaVendaBl
        {
            get { return this.id_pclvendabll; }
            set { this.id_pclvendabll = value; }
        }

        public decimal ParcelaBlValor
        {
            get { return this.parcelasblc_valor; }
            set { this.parcelasblc_valor = value; }
        }

        public DateTime ParcBlDataPagt
        {
            get { return this.parcelasblc_datapg; }
            set { this.parcelasblc_datapg = value; }
        }

        public DateTime ParcBlDataVenc
        {
            get { return this.parcelasblc_vencimento; }
            set { this.parcelasblc_vencimento = value; }
        }

        public string TipoPagto
        {
            get { return this.tipo_pg; }
            set { this.tipo_pg = value; }
        }

        public int IDProdVendaBl
        {
            get { return this.id_prodvendabl; }
            set { this.id_prodvendabl = value; }
        }

        public int IDProduto
        {
            get { return this.id_produto; }
            set { this.id_produto = value; }
        }
    }
}
/*[KMKCONSULTORIA]*/
