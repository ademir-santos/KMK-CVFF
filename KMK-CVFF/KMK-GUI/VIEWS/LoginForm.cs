using KMK_BLL.LOGIN;
using KMK_DAL.CONEXAO;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /*<OBJETO>*/
        private void btnLgEntrar_Click(object sender, EventArgs e)
        {
            this.ValidarAcesso();
        }

        private void btnLgSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        /*</OBJETO>*/

        /*<FUNCAO>*/
        private void ValidarAcesso()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            LoginBLL lgBLL = new LoginBLL(cx);
            string @login = txtLgLogin.Text;
            string @senha = txtLgSenha.Text;

            if (lgBLL.ValidarAcesso(@login, @senha) != 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha Invalido!");
            }
        }




        /*<FUNCAO>*/
    }
}
