using KMK_MODELO.EMPRESA;
using KMK_DAL.CONEXAO;
using KMK_BLL.EMPRESA;
using KMK_GUI.VIEWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_GUI.VIEWS.SUB_FORMS.EMPRESA
{
    public partial class AtualizarEmpresaForm : Form
    {
        /*<OBJETO>**/
        static EmpresaAtModelo EmpAtMd = new EmpresaAtModelo();
        static int vlEmpAtl = 0;
        
        public AtualizarEmpresaForm(string @razao, int @indice)
        {
            InitializeComponent();

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL Empbll = new EmpresaBLL(cx);

            this.CarregarCampos(Empbll.ParametrosAtualizaEmpForm(@razao, @indice));
        }
        
        private void AtualizarEmpresaForm_Load(object sender, EventArgs e)
        {
            vlEmpAtl = 0;
            this.AlterarCampos();
        }

        private void btnATLEmpEditar_Click(object sender, EventArgs e)
        {
            if (vlEmpAtl == 0)
            {
                vlEmpAtl = 1;
                this.AlterarCampos();
            }
            else
            {
                this.AtualizarEmpresa();
            }
        }

        private void btnATLEmpCancelar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
            vlEmpAtl = 0;
            this.AlterarCampos();
            this.DialogResult = DialogResult.OK;
        }

        private void btnATLEmpSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*</OBJETO>**/

        /*<FUNCAO>**/
        private bool AtualizarEmpresa()
        {
            bool ret = false;

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpAtMd.IDPessoa = Convert.ToInt32(cbboxATLEmpResp.SelectedValue.ToString());
            CarregarIndiceComboEstado(this.cbboxATLEmpEstado.SelectedItem.ToString());
            EmpAtMd.Cidade = txtATLEmpCidade.Text;
            EmpAtMd.Bairro = txtATLEmpBairro.Text;
            EmpAtMd.Logradouro = txtATLEmpLog.Text;
            EmpAtMd.NumeroEnd = txtATLEmpNum.Text;
            EmpAtMd.Razao = txtATLEmpRazao.Text;
            EmpAtMd.NumeroCom = txtATLEmpTel.Text;
            EmpAtMd.NumeroFax = txtATLEmpFax.Text;

            EmpresaBLL fcbll = new EmpresaBLL(cx);

            if (fcbll.AtualizarEmpresa(EmpAtMd))
            {
                if (MeusFormularios.PDSSForm == null)
                    MeusFormularios.PDSSForm = new PadroesSistemaForm();

                MeusFormularios.PDSSForm.Show();
                MeusFormularios.PDSSForm.Focus();

                ret = true;
            }

            return ret;
        }

        private void CarregarCampos(EmpresaPaModelo EmpPaMd)
        {
            EmpAtMd.IDEnd = EmpPaMd.IDEnd;
            EmpAtMd.IDPessoa = EmpPaMd.IDPessoa;
            EmpAtMd.IDTelefone = EmpPaMd.IDTelefone;
            EmpAtMd.IDFuncionario = EmpPaMd.IDFuncionario;
            EmpAtMd.IDEmpresa = EmpPaMd.IDEmpresa;
            this.txtATLEmpRazao.Text = EmpPaMd.Razao;
            this.txtATLEmpTel.Text = EmpPaMd.NumeroTel;
            this.txtATLEmpTel.Text = EmpPaMd.NumeroCel;
            this.CarregarItemComboEstado(EmpPaMd.Estado);
            this.CarregarComboPessoa(EmpPaMd.IDPessoa);
            this.txtATLEmpCidade.Text = EmpPaMd.Cidade;
            this.txtATLEmpBairro.Text = EmpPaMd.Bairro;
            this.txtATLEmpLog.Text = EmpPaMd.Logradouro;
            this.txtATLEmpNum.Text = EmpPaMd.NumeroEnd;
        }

        private void AlterarCampos()
        {
            if (vlEmpAtl == 0)
            {
                this.pnATLEmpEditar.Enabled = false;
                this.btnATLEmpEditar.Enabled = true;
                this.btnATLEmpCancelar.Enabled = false;
                this.btnATLEmpSair.Enabled = true;
            }
            else if (vlEmpAtl == 1)
            {
                this.pnATLEmpEditar.Enabled = true;
                this.btnATLEmpEditar.Enabled = false;
                this.btnATLEmpCancelar.Enabled = true;
                this.btnATLEmpSair.Enabled = false;
            }

        }

        private void LimparCampos()
        {
            this.txtATLEmpBairro.Clear();
            this.txtATLEmpCidade.Clear();
            this.txtATLEmpComp.Clear();
            this.txtATLEmpFax.Clear();
            this.txtATLEmpLog.Clear();
            this.txtATLEmpNum.Clear();
            this.txtATLEmpRazao.Clear();
            this.txtATLEmpTel.Clear();
            this.cbboxATLEmpEstado.SelectedIndex = -1;
            this.cbboxATLEmpResp.SelectedIndex = -1;
        }

        private void CarregarComboPessoa(int id = 0)
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL empBLL = new EmpresaBLL(cx);
            
            cbboxATLEmpResp.DataSource = empBLL.LocalizarPessoa("ATLEMPFORM", id);            
            cbboxATLEmpResp.DisplayMember = "nome";
            cbboxATLEmpResp.ValueMember = "id_pessoa";
        }

        private void CarregarItemComboEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxATLEmpEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxATLEmpEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxATLEmpEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxATLEmpEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxATLEmpEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxATLEmpEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxATLEmpEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxATLEmpEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxATLEmpEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxATLEmpEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxATLEmpEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxATLEmpEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxATLEmpEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxATLEmpEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxATLEmpEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxATLEmpEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxATLEmpEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxATLEmpEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxATLEmpEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxATLEmpEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxATLEmpEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxATLEmpEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxATLEmpEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxATLEmpEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxATLEmpEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxATLEmpEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxATLEmpEstado.SelectedItem = "Tocantins";
                    break;
                default:
                    break;
            }
        }

        private void CarregarIndiceComboEstado(string estado)
        {
            switch (estado)
            {
                case "Acre":
                    EmpAtMd.Estado = 1;
                    break;
                case "Alagoas":
                    EmpAtMd.Estado = 2;
                    break;
                case "Amapá":
                    EmpAtMd.Estado = 3;
                    break;
                case "Amazonas":
                    EmpAtMd.Estado = 4;
                    break;
                case "Bahia":
                    EmpAtMd.Estado = 5;
                    break;
                case "Ceará":
                    EmpAtMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    EmpAtMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    EmpAtMd.Estado = 8;
                    break;
                case "Goiás":
                    EmpAtMd.Estado = 9;
                    break;
                case "Maranhão":
                    EmpAtMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    EmpAtMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    EmpAtMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    EmpAtMd.Estado = 13;
                    break;
                case "Pará":
                    EmpAtMd.Estado = 14;
                    break;
                case "Paraíba":
                    EmpAtMd.Estado = 15;
                    break;
                case "Paraná":
                    EmpAtMd.Estado = 16;
                    break;
                case "Pernambuco":
                    EmpAtMd.Estado = 17;
                    break;
                case "Piauí":
                    EmpAtMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    EmpAtMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    EmpAtMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    EmpAtMd.Estado = 21;
                    break;
                case "Rondônia":
                    EmpAtMd.Estado = 22;
                    break;
                case "Roraima":
                    EmpAtMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    EmpAtMd.Estado = 24;
                    break;
                case "São Paulo":
                    EmpAtMd.Estado = 25;
                    break;
                case "Sergipe":
                    EmpAtMd.Estado = 26;
                    break;
                case "Tocantins":
                    EmpAtMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }
        /*</FUNCAO>**/
    }
}
