using KMK_BLL.CLIENTE;
using KMK_DAL.CONEXAO;
using KMK_GUI.VIEWS;
using KMK_MODELO.CLIENTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_GUI.VIEWS.SUB_FORMS.CLIENTE
{
    public partial class AtualizarClienteForm : Form
    {
        static ClienteAtModelo CliAtMd = new ClienteAtModelo();
        static string @validar = null;
        static int @operacao = 0;

        public AtualizarClienteForm(string @nome = null, string @form = null)
        {
            InitializeComponent();

            @validar = @form;
            if (@validar == "ATUALIZAR")
            {
                ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
                ClienteBLL Clibll = new ClienteBLL(cx);
                this.CarregarCampos(Clibll.ParametrosAtualizaClienteForm(@nome));
                this.AtualizarOuCadastrar(1);
            }
            else
            {
                this.AtualizarOuCadastrar(0);
            }
        }

        private void AtualizarClienteForm_Load(object sender, EventArgs e)
        {
            @operacao = 0;
            this.AlterarCampos();
        }

        private void btnCADATLClienteCancelar_Click(object sender, EventArgs e)
        {
            @validar = null;
            @operacao = 0;
            this.LimparCampos();
            this.AlterarCampos();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCADATLClienteSair_Click(object sender, EventArgs e)
        {
            @validar = null;
            @operacao = 0;
            this.LimparCampos();
            this.AlterarCampos();
            this.DialogResult = DialogResult.OK;
        }

        /*[FUNCAO]*/
        private void AlterarCampos()
        {
            if (@operacao == 0)
            {
                this.pnATLClienteNovo.Enabled = false;
                this.btnCADATLClienteEditar.Enabled = true;
                this.btnCADATLClienteCancelar.Enabled = false;
                this.btnCADATLClienteSair.Enabled = true;
            }
            else if (@operacao == 1)
            {
                this.pnATLClienteNovo.Enabled = true;
                this.btnCADATLClienteEditar.Enabled = false;
                this.btnCADATLClienteCancelar.Enabled = true;
                this.btnCADATLClienteSair.Enabled = false;
            }

        }

        private void LimparCampos()
        {
            this.txtCADATLClienteNome.Clear();
            this.txtCADATLClienteTel.Clear();
            this.txtCADATLClienteCel.Clear();
            this.cbboxCADATLClienteEstado.SelectedIndex = -1;
            this.txtCADATLClienteCidade.Clear();
            this.txtCADATLClienteBairro.Clear();
            this.txtCADATLClienteLog.Clear();
            this.txtCADATLClienteNum.Clear();
        }

        private void AtualizarOuCadastrar(int @indice = 0)
        {
            if (indice == 0)
            {
                this.btnCADATLClienteEditar.Text = "Novo";
                this.btnCADATLClienteSalvar.Visible = true;
            }
            else
            {
                this.btnCADATLClienteEditar.Text = "Editar";
                this.btnCADATLClienteSalvar.Visible = false;
            }
        }

        private void CarregarCampos(ClientePaModelo CliPaMd)
        {
            CliAtMd.IDEnd = CliPaMd.IDEnd;
            CliAtMd.IDPessoa = CliPaMd.IDPessoa;
            CliAtMd.IDTelefone = CliPaMd.IDTelefone;
            CliAtMd.IDCliente = CliPaMd.IDCliente;
            CliAtMd.IDPrmcClint = CliPaMd.IDPrmcClint;
            CliAtMd.IDPromocao = CliPaMd.IDPromocao;
            this.txtCADATLClienteNome.Text = CliPaMd.Nome;
            this.txtCADATLClienteTel.Text = CliPaMd.NumeroTel;
            this.txtCADATLClienteCel.Text = CliPaMd.NumeroCel;
            this.CarregarItemComboEstado(CliPaMd.Estado);
            this.dtATLCliAniversario.Value = CliPaMd.Aniversario;
            this.txtCADATLClienteCidade.Text = CliPaMd.Cidade;
            this.txtCADATLClienteBairro.Text = CliPaMd.Bairro;
            this.txtCADATLClienteLog.Text = CliPaMd.Logradouro;
            this.txtCADATLClienteNum.Text = CliPaMd.NumeroEnd;
        }

        private void CarregarItemComboEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxCADATLClienteEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxCADATLClienteEstado.SelectedItem = "Tocantins";
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
                    CliAtMd.Estado = 1;
                    break;
                case "Alagoas":
                    CliAtMd.Estado = 2;
                    break;
                case "Amapá":
                    CliAtMd.Estado = 3;
                    break;
                case "Amazonas":
                    CliAtMd.Estado = 4;
                    break;
                case "Bahia":
                    CliAtMd.Estado = 5;
                    break;
                case "Ceará":
                    CliAtMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    CliAtMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    CliAtMd.Estado = 8;
                    break;
                case "Goiás":
                    CliAtMd.Estado = 9;
                    break;
                case "Maranhão":
                    CliAtMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    CliAtMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    CliAtMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    CliAtMd.Estado = 13;
                    break;
                case "Pará":
                    CliAtMd.Estado = 14;
                    break;
                case "Paraíba":
                    CliAtMd.Estado = 15;
                    break;
                case "Paraná":
                    CliAtMd.Estado = 16;
                    break;
                case "Pernambuco":
                    CliAtMd.Estado = 17;
                    break;
                case "Piauí":
                    CliAtMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    CliAtMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    CliAtMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    CliAtMd.Estado = 21;
                    break;
                case "Rondônia":
                    CliAtMd.Estado = 22;
                    break;
                case "Roraima":
                    CliAtMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    CliAtMd.Estado = 24;
                    break;
                case "São Paulo":
                    CliAtMd.Estado = 25;
                    break;
                case "Sergipe":
                    CliAtMd.Estado = 26;
                    break;
                case "Tocantins":
                    CliAtMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }

        private bool CriarOuAtualizarCliente()
        {
            bool ret = false;

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            CarregarIndiceComboEstado(this.cbboxCADATLClienteEstado.SelectedItem.ToString());
            CliAtMd.Aniversario = Convert.ToDateTime(dtATLCliAniversario.Text);
            CliAtMd.Cidade = txtCADATLClienteCidade.Text;
            CliAtMd.Bairro = txtCADATLClienteBairro.Text;
            CliAtMd.Logradouro = txtCADATLClienteLog.Text;
            CliAtMd.NumeroEnd = txtCADATLClienteNum.Text;
            CliAtMd.Nome = txtCADATLClienteNome.Text;
            CliAtMd.NumeroTel = txtCADATLClienteTel.Text;
            CliAtMd.NumeroCel = txtCADATLClienteCel.Text;

            ClienteBLL Clibll = new ClienteBLL(cx);


            if (@validar == "ATUALIZAR")
            {
                if (Clibll.AtualizarCliente(CliAtMd))
                {
                    @validar = null;
                    @operacao = 0;
                    this.LimparCampos();
                    this.AlterarCampos();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                ClienteInModelo CliInMd = new ClienteInModelo();

                CliInMd.Nome = CliAtMd.Nome;
                CliInMd.Estado = CliAtMd.Estado;
                CliInMd.Aniversario = CliAtMd.Aniversario;
                CliInMd.Cidade = CliAtMd.Cidade;
                CliInMd.Bairro = CliAtMd.Bairro;
                CliInMd.Logradouro = CliAtMd.Logradouro;
                CliInMd.NumeroEnd = CliAtMd.NumeroEnd;
                CliInMd.NumeroTel = CliAtMd.NumeroTel;
                CliInMd.NumeroCel = CliAtMd.NumeroCel;

                if (Clibll.IncluirCliente(CliInMd, @validar))
                {
                    @validar = null;
                    @operacao = 0;
                    this.LimparCampos();
                    this.AlterarCampos();
                    this.DialogResult = DialogResult.OK;
                }
            }

            return ret;
        }

        private void btnCADATLClienteEditar_Click(object sender, EventArgs e)
        {
            if (@validar == "ATUALIZAR")
            {
                if (@operacao == 0)
                {
                    @operacao = 1;
                    this.AlterarCampos();
                }
                else
                {
                    this.CriarOuAtualizarCliente();
                }
            }
            else
            {
                @operacao = 1;
                this.AlterarCampos();
            }

        }

        private void btnCADATLClienteSalvar_Click(object sender, EventArgs e)
        {
            this.CriarOuAtualizarCliente();
        }
        /*[FUNCAO]*/
    }
}
