using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMK_GUI.VIEWS;
using KMK_MODELO.LOGIN;

namespace KMK_GUI
{
    public partial class PrincipalForm : Form
    {

        static string frm = null;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        /*<OBJETOS>*/
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            frm = "login";
            this.CarregarForm();
        }

        private void btnMDDelivery_Click(object sender, EventArgs e)
        {
            frm = null;
            frm = "dlv";
            this.CarregarForm();
        }

        private void btnMDBalcao_Click(object sender, EventArgs e)
        {
            frm = null;
            frm = "blc";
            this.CarregarForm();
        }

        private void btnMDParSis_Click(object sender, EventArgs e)
        {
            frm = null;
            frm = "prsm";
            this.CarregarForm();
        }
        /*</OBJETOS>*/

        /*<FUNCAO>*/
        private void CarregarForm()
        {
            if (frm == "login")
            {
                if (MeusFormularios.LGNForm == null)
                    MeusFormularios.LGNForm = new LoginForm();

                MeusFormularios.LGNForm.ShowDialog();

                if (MeusFormularios.LGNForm.DialogResult.Equals(DialogResult.OK))
                {
                    this.SecaoUsuario();
                    MeusFormularios.LGNForm.Close();
                    MeusFormularios.LGNForm = null;
                }
                else
                {
                    MeusFormularios.LGNForm.Close();
                    MeusFormularios.LGNForm = null;
                    this.Close();
                }
            }
            else if (frm == "dlv")
            {
                if (MeusFormularios.DLVForm == null)
                    MeusFormularios.DLVForm = new DeliveryForm();

                MeusFormularios.DLVForm.ShowDialog();

                if (MeusFormularios.DLVForm.DialogResult.Equals(DialogResult.OK))
                {
                    MeusFormularios.DLVForm.Close();
                    MeusFormularios.DLVForm = null;
                }

            }
            else if (frm == "blc")
            {
                if (MeusFormularios.BLCForm == null)
                    MeusFormularios.BLCForm = new BalcaoForm();

                MeusFormularios.BLCForm.ShowDialog();

                if (MeusFormularios.BLCForm.DialogResult.Equals(DialogResult.OK))
                {
                    MeusFormularios.BLCForm.Close();
                    MeusFormularios.BLCForm = null;
                }

            }
            else if (frm == "prsm")
            {
                if (MeusFormularios.PDSSForm == null)
                    MeusFormularios.PDSSForm = new PadroesSistemaForm();

                MeusFormularios.PDSSForm.ShowDialog();

                if (MeusFormularios.PDSSForm.DialogResult.Equals(DialogResult.OK))
                {
                    MeusFormularios.PDSSForm.Close();
                    MeusFormularios.PDSSForm = null;
                }
            }

        }

        private void btnPrncFrmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SecaoUsuario()
        {
            this.lbSecaoUsuario.Text = LoginSecaoModelo.login;
            this.lbSecaoUsuario.ForeColor = System.Drawing.Color.Aquamarine;
        }






        /*</FUNCAO>*/


    }
}
