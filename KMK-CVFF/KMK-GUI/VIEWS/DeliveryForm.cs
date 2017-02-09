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
    public partial class DeliveryForm : Form
    {
        /*</OBJETOS>**/
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void btnMDDeliverySair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /*</OBJETOS>**/

        /*<FUNCAO>**/
        private void CarregarLabelMesa()
        {

        }
        /*<FUNCAO>**/
    }
}
