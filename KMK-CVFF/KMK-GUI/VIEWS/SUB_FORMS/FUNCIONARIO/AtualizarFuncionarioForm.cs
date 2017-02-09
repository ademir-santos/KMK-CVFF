using KMK_BLL.FUNCIONARIO;
using KMK_DAL.CONEXAO;
using KMK_MODELO.FUNCIONARIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_GUI.VIEWS.SUB_FORMS.FUNCIONARIO
{
    public partial class AtualizarFuncionarioForm : Form
    {
        static int valor = 0;

        static FuncionarioAtModelo fcAtMd = new FuncionarioAtModelo();

        public AtualizarFuncionarioForm(string @login = null, string @nome = null, int @indice = 0)
        {
            InitializeComponent();

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);
            this.CarregarCampos(fcbll.ParametrosAtualizaFunForm(@login, @nome, @indice));
        }

        private void AtualizarFuncionarioForm_Load(object sender, EventArgs e)
        {
            this.AlterarCampos();
        }

        private void btnATLFunEditar_Click(object sender, EventArgs e)
        {
            if (valor == 0)
            {
                valor = 1;
                this.AlterarCampos();
            }
            else
            {
                this.AtualizarFuncionario();
            }    
        }

        private void btnATLFunCancelar_Click(object sender, EventArgs e)
        {
            valor = 0;
            this.LimparCampos();
            this.AlterarCampos();
            this.DialogResult = DialogResult.OK;
        }

        private void btnATLFunSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*<FUNCAO>*/
        private bool AtualizarFuncionario()
        {
            bool ret = false;

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            CarregarIndiceComboEstado(this.cbboxATLFunEstado.SelectedItem.ToString());
            fcAtMd.Cidade = txtATLFunCidade.Text;
            fcAtMd.Bairro = txtATLFunBairro.Text;
            fcAtMd.Logradouro = txtATLFunLog.Text;
            fcAtMd.NumeroEnd = txtATLFunNum.Text;
            fcAtMd.Nome = txtATLFunNome.Text;
            fcAtMd.NumeroTel = txtATLFunTel.Text;
            fcAtMd.NumeroCel = txtATLFunCel.Text;
            fcAtMd.Login = txtATLFunLogin.Text;
            fcAtMd.Aniversario = Convert.ToDateTime(dtATLFunAniversario.Text);
            CarregarIndiceComboPerfil(this.cbboxATLFunPerfil.SelectedItem.ToString());
            fcAtMd.IDEmpresa = Convert.ToInt32(cbboxATLFunEmpresa.SelectedValue.ToString());

            FuncionarioBLL fcbll = new FuncionarioBLL(cx);

            if (fcbll.AtualizarFuncionario(fcAtMd))
            {
                valor = 0;
                this.DialogResult = DialogResult.OK;
            }

            return ret;
        }

        private void AlterarCampos()
        {
            if (valor == 0)
            {
                this.pnATLFunPessoa.Enabled = false;
                this.pnATLFunEndereco.Enabled = false;
                this.btnATLFunEditar.Enabled = true;
                this.btnATLFunCancelar.Enabled = false;
                this.btnATLFunEdtSenha.Enabled = false;
                this.btnATLFunSair.Enabled = true;
            }
            else if (valor == 1)
            {
                this.pnATLFunPessoa.Enabled = true;
                this.pnATLFunEndereco.Enabled = true;
                this.btnATLFunEditar.Enabled = true;
                this.btnATLFunCancelar.Enabled = true;
                this.btnATLFunEdtSenha.Enabled = true;
                this.btnATLFunSair.Enabled = false;
            }

        }

        private void LimparCampos()
        {
            this.txtATLFunBairro.Clear();
            this.txtATLFunCel.Clear();
            this.txtATLFunCidade.Clear();
            this.txtATLFunComp.Clear();
            this.txtATLFunLog.Clear();
            this.txtATLFunLogin.Clear();
            this.txtATLFunNome.Clear();
            this.txtATLFunNum.Clear();
            this.txtATLFunTel.Clear();
            this.cbboxATLFunEmpresa.SelectedIndex = -1;
            this.cbboxATLFunEstado.SelectedIndex = -1;
            this.cbboxATLFunPerfil.SelectedIndex = -1;
        }

        private void CarregarCampos(FuncionarioPaModelo fcPaMd)
        {
            fcAtMd.IDEnd = fcPaMd.IDEnd;
            fcAtMd.IDPessoa = fcPaMd.IDPessoa;
            fcAtMd.IDTelefone = fcPaMd.IDTelefone;
            fcAtMd.IDFuncionario = fcPaMd.IDFuncionario;
            fcAtMd.IDFuncEmp = fcPaMd.IDFuncEmp;
            this.txtATLFunNome.Text = fcPaMd.Nome;
            this.txtATLFunTel.Text = fcPaMd.NumeroTel;
            this.txtATLFunCel.Text = fcPaMd.NumeroCel;
            this.txtATLFunLogin.Text = fcPaMd.Login;
            this.CarregarItemComboPerfil(fcPaMd.Funcao);
            this.CarregarComboEmpresa(fcPaMd.Razao);
            this.dtATLFunAniversario.Value = fcPaMd.Aniversario;
            this.CarregarItemComboEstado(fcPaMd.Estado);
            this.txtATLFunCidade.Text = fcPaMd.Cidade;
            this.txtATLFunBairro.Text = fcPaMd.Bairro;
            this.txtATLFunLog.Text = fcPaMd.Logradouro;
            this.txtATLFunNum.Text = fcPaMd.NumeroEnd;
        }

        private void CarregarComboEmpresa(string @razao = null)
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL empBLL = new FuncionarioBLL(cx);

            string @form = null;


            if (@razao == "Vazio")
            {
                @form = "CadFun";

                cbboxATLFunEmpresa.DataSource = empBLL.ComboBoxEmpresa(@form, @razao);
                cbboxATLFunEmpresa.DisplayMember = "razao";
                cbboxATLFunEmpresa.ValueMember = "id_empresa";
            }
            else
            {
                cbboxATLFunEmpresa.DataSource = empBLL.ComboBoxEmpresa(@form, @razao);
                cbboxATLFunEmpresa.DisplayMember = "razao";
                cbboxATLFunEmpresa.ValueMember = "id_empresa";
            }

        }

        private void CarregarItemComboPerfil(int perfil)
        {
            switch (perfil)
            {

                case 1:
                    this.cbboxATLFunPerfil.SelectedItem = "Presidente";
                    break;
                case 2:
                    this.cbboxATLFunPerfil.SelectedItem = "Gerente";
                    break;
                case 3:
                    this.cbboxATLFunPerfil.SelectedItem = "Coordenador";
                    break;
                case 4:
                    this.cbboxATLFunPerfil.SelectedItem = "Pizzaiolo";
                    break;
                case 5:
                    this.cbboxATLFunPerfil.SelectedItem = "Atendente";
                    break;
                case 6:
                    this.cbboxATLFunPerfil.SelectedItem = "Entregador";
                    break;
                default:
                    break;
            }
        }

        private void CarregarIndiceComboPerfil(string perfil)
        {
            switch (perfil)
            {

                case "Presidente":
                    fcAtMd.Funcao = 1;
                    break;
                case "Gerente":
                    fcAtMd.Funcao = 2;
                    break;
                case "Coordenador":
                    fcAtMd.Funcao = 3;
                    break;
                case "Pizzaiolo":
                    fcAtMd.Funcao = 4;
                    break;
                case "Atendente":
                    fcAtMd.Funcao = 5;
                    break;
                case "Entregador":
                    fcAtMd.Funcao = 6;
                    break;
                default:
                    break;
            }
        }

        private void CarregarItemComboEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxATLFunEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxATLFunEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxATLFunEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxATLFunEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxATLFunEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxATLFunEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxATLFunEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxATLFunEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxATLFunEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxATLFunEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxATLFunEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxATLFunEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxATLFunEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxATLFunEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxATLFunEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxATLFunEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxATLFunEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxATLFunEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxATLFunEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxATLFunEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxATLFunEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxATLFunEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxATLFunEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxATLFunEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxATLFunEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxATLFunEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxATLFunEstado.SelectedItem = "Tocantins";
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
                    fcAtMd.Estado = 1;
                    break;
                case "Alagoas":
                    fcAtMd.Estado = 2;
                    break;
                case "Amapá":
                    fcAtMd.Estado = 3;
                    break;
                case "Amazonas":
                    fcAtMd.Estado = 4;
                    break;
                case "Bahia":
                    fcAtMd.Estado = 5;
                    break;
                case "Ceará":
                    fcAtMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    fcAtMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    fcAtMd.Estado = 8;
                    break;
                case "Goiás":
                    fcAtMd.Estado = 9;
                    break;
                case "Maranhão":
                    fcAtMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    fcAtMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    fcAtMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    fcAtMd.Estado = 13;
                    break;
                case "Pará":
                    fcAtMd.Estado = 14;
                    break;
                case "Paraíba":
                    fcAtMd.Estado = 15;
                    break;
                case "Paraná":
                    fcAtMd.Estado = 16;
                    break;
                case "Pernambuco":
                    fcAtMd.Estado = 17;
                    break;
                case "Piauí":
                    fcAtMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    fcAtMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    fcAtMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    fcAtMd.Estado = 21;
                    break;
                case "Rondônia":
                    fcAtMd.Estado = 22;
                    break;
                case "Roraima":
                    fcAtMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    fcAtMd.Estado = 24;
                    break;
                case "São Paulo":
                    fcAtMd.Estado = 25;
                    break;
                case "Sergipe":
                    fcAtMd.Estado = 26;
                    break;
                case "Tocantins":
                    fcAtMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }

        /*</FUNCAO>*/


    }
}
