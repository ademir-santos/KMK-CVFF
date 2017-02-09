//using KMK_GUI.VIEW.SUB_FORMS.BALCAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_GUI.VIEWS
{
    public partial class BalcaoForm : Form
    {
        public BalcaoForm()
        {
            InitializeComponent();
        }

        private void btnMDBalcaoSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PreencherLabelMesa()
        {
            //this.lbMDBCtxt_1.Text = "testeteste";
            //this.lbMDBCtxt_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void btnMDBalcaoPedido_Click(object sender, EventArgs e)
        {
            /*
            if (MeusFormularios.VDBLCForm == null)
                MeusFormularios.VDBLCForm = new VendaModeloForm1();

            MeusFormularios.VDBLCForm.ShowDialog();

            if (MeusFormularios.VDBLCForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.VDBLCForm.Close();
                MeusFormularios.VDBLCForm = null;
            }
             * */
        }
    }
}
