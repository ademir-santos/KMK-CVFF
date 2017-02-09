using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_GUI.VIEWS.SUB_FORMS.FORM_PADRAO
{
    public partial class VendaModeloForm : Form
    {
        public VendaModeloForm()
        {
            InitializeComponent();
        }

        private void btnVDMDFRMExcluir_Click(object sender, EventArgs e)
        {
            this.lstVDMDFRMProdutos.ClearSelected();
        }

        private void btnVDMDFRMCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a Lista?", "Pedido de Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                
                this.DialogResult = DialogResult.OK;
            }         
        }

        private void btnVDMDFRMConcluir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AlterarBotaoExcluir()
        {
            if (this.lstVDMDFRMProdutos.SelectedValue != null)
            {
                this.btnVDMDFRMExcluir.Enabled = true;
            }
        }

        private void AlterarBotoes() 
        {
            this.btnVDMDFRMExcluir.Enabled = false;
            this.btnVDMDFRMCancelar.Enabled = false;
            this.btnVDMDFRMConcluir.Enabled = false;
        }
    }
}
