using KMK_BLL.CLIENTE;
using KMK_BLL.EMPRESA;
using KMK_BLL.FUNCIONARIO;
using KMK_BLL.PRODUTO;
using KMK_DAL.CONEXAO;
using KMK_GUI.VIEWS.SUB_FORMS.CLIENTE;
using KMK_GUI.VIEWS.SUB_FORMS.EMPRESA;
using KMK_GUI.VIEWS.SUB_FORMS.FUNCIONARIO;
using KMK_GUI.VIEWS.SUB_FORMS.PRODUTO;
using KMK_MODELO.CLIENTE;
using KMK_MODELO.EMPRESA;
using KMK_MODELO.FUNCIONARIO;
using KMK_MODELO.LOGIN;
using KMK_MODELO.PRODUTO;
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
    public partial class PadroesSistemaForm : Form
    {
        public PadroesSistemaForm()
        {
            InitializeComponent();
        }

        // ==========================================\\
        // [=======================================] \\
        // [PADROES DO SISTEMA] | [METOD()/OBJETO()] \\
        // [=======================================] \\
        // ==========================================\\
        /*<VARIAVEIS STATICAS>**/
        static FuncionarioInModelo fcInMd = new FuncionarioInModelo();
        static EmpresaInModelo EpInMd = new EmpresaInModelo();
        static ClienteInModelo ClInMd = new ClienteInModelo();
        static ProdutoInModelo ProdInMd = new ProdutoInModelo();
        /*</VARIAVEIS STATICAS>**/
        /*<OBJETO PADRAO FORM>**/
        private void PadroesSistemaForm_Load(object sender, EventArgs e)
        {
            this.CarregarPainel();
        }

        private void tabMDPadraoSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregarPainel();
        }

        private void tbMDFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregarPainel();
        } 

        private void tabMDEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregarPainel();
        }

        private void tabMDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregarPainel();
        }

        private void tabMDProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CarregarPainel();
        }
        /*</OBJETO PADRAO FORM>**/

        /*<ALTERAR BOTOES FORM>**/

        private void AlterarBotoes(string modulo = null, int operacao = 0)
        {
            switch (modulo)
            {
                case "FunCad":
                    this.BtnFunCad(operacao);
                    break;
                case "FunCon":
                    this.BtnFunCon(operacao);
                    break;
                case "EmpCad":
                    this.BtnEmpCad(operacao);
                    break;
                case "EmpCon":
                    this.BtnEmpCon(operacao);
                    break;
                case "CliCad":
                    this.BtnCliCad(operacao);
                    break;
                case "CliCon":
                    this.BtnCliCon(operacao);
                    break;
                case "ProdCad":
                    this.BtnProdCad(operacao);
                    break;
                case "ProdCon":
                    this.BtnProdCon(operacao);
                    break;
                default:
                    this.BtnFunCad(1);
                    break;
            }
        }

        private void BtnFunCad(int operacao = 0)
        {
            if (operacao == 0)
            {
                this.btnCADFunNovo.Enabled = true;
                this.btnCADFunCancelar.Enabled = false;
                this.btnCADFunSalvar.Enabled = false;
                this.btnCADFunSair.Enabled = true;
                this.pnCADFunNovo.Enabled = false;
            }
            else if (operacao == 1) //Botão Novo
            {
                this.btnCADFunNovo.Enabled = false;
                this.btnCADFunCancelar.Enabled = true;
                this.btnCADFunSalvar.Enabled = true;
                this.btnCADFunSair.Enabled = false;
                this.pnCADFunNovo.Enabled = true;
            }
        }

        private void BtnFunCon(int operacao = 0)
        {

        }

        private void BtnEmpCad(int operacao = 0)
        {
            if (operacao == 0)
            {
                this.pnCADEmpNovo.Enabled = false;
                this.btnCADEmpNovo.Enabled = true;
                this.btnCADEmpCancelar.Enabled = false;
                this.btnCADEmpSalvar.Enabled = false;
                this.btnCADEmpSair.Enabled = true;
                
                

            }
            else if (operacao == 1) //Botão Novo
            {
                this.pnCADEmpNovo.Enabled = true;
                this.btnCADEmpNovo.Enabled = false;
                this.btnCADEmpCancelar.Enabled = true;
                this.btnCADEmpSalvar.Enabled = true;
                this.btnCADEmpSair.Enabled = false;    
            }
        }

        private void BtnEmpCon(int operacao = 0)
        {

        }

        private void BtnCliCad(int operacao = 0)
        {
            if (operacao == 0)
            {
                this.btnCADClientNovo.Enabled = true;
                this.btnCADClientCanc.Enabled = false;
                this.btnCADClientSalvar.Enabled = false;
                this.btnCADClientSair.Enabled = true;
                this.pnCADClientNovo.Enabled = false;

            }
            else if (operacao == 1) //Botão Novo
            {
                this.btnCADClientNovo.Enabled = false;
                this.btnCADClientCanc.Enabled = true;
                this.btnCADClientSalvar.Enabled = true;
                this.btnCADClientSair.Enabled = false;
                this.pnCADClientNovo.Enabled = true;
            }
        }

        private void BtnCliCon(int operacao = 0)
        {

        }

        private void BtnProdCad(int operacao = 0)
        {
            if (operacao == 0)
            {
                this.btnCADProdutoNovo.Enabled = true;
                this.btnCADProdutoCancelar.Enabled = false;
                this.btnCADProdutoSalvar.Enabled = false;
                this.btnCADProdutoSair.Enabled = true;
                this.pnCADProdutoNovo.Enabled = false;

            }
            else if (operacao == 1) //Botão Novo
            {
                this.btnCADProdutoNovo.Enabled = false;
                this.btnCADProdutoCancelar.Enabled = true;
                this.btnCADProdutoSalvar.Enabled = true;
                this.btnCADProdutoSair.Enabled = false;
                this.pnCADProdutoNovo.Enabled = true;
            }
        }

        private void BtnProdCon(int operacao = 0)
        {

        }
        /*</ALTERAR BOTOES FORM>**/

        /*<LIMPAR CAMPOS>**/
        private void LimparCampos(string modulo = null)
        {
            switch (modulo)
            {
                case "FunCad":
                    this.CmpFunCad();
                    break;
                case "FunCon":
                    this.CmpFunCon();
                    break;
                case "EmpCad":
                    this.CmpEmpCad();
                    break;
                case "EmpCon":
                    this.CmpEmpCon();
                    break;
                case "CliCad":
                    //this.CmpCliCad();
                    break;
                case "CliCon":
                    //this.CmpCliCon();
                    break;
            }
        }

        private void CmpFunCad()
        {
            this.txtCADFunNome.Clear();
            this.txtCADFunTel.Clear();
            this.txtCADFunCel.Clear();
            this.txtCADFunLogin.Clear();
            this.txtCADFunSenha.Clear();
            this.txtCADFunConSenha.Clear();
            this.cbboxCADFunPerfil.SelectedIndex = -1;
            this.cbboxCADFunEstado.SelectedIndex = -1;
            this.txtCADFunCidade.Clear();
            this.txtCADFunBairro.Clear();
            this.txtCADFunComp.Clear();
            this.txtCADFunLog.Clear();
            this.txtCADFunNum.Clear();
        }

        private void CmpFunCon()
        {

        }

        private void CmpEmpCad()
        {
            this.txtCADEmpRazao.Clear();
            this.txtCADEmpTel.Clear();
            this.txtCADEmpFax.Clear();
            this.EmpCadCarregarComboPessoa();
            this.cbboxCADEmpEstado.SelectedIndex = -1;
            this.txtCADEmpCidade.Clear();
            this.txtCADEmpBairro.Clear();
            this.txtCADEmpComplemento.Clear();
            this.txtCADEmpLog.Clear();
            this.txtCADEmpNum.Clear();
        }

        private void CmpEmpCon()
        {

        }

        private void CmpCliCad()
        {
            this.txtCADClientNome.Clear();
            this.txtCADClientTel.Clear();
            this.txtCADClientCel.Clear();
            this.cbboxCADEmpEstado.SelectedIndex = -1;
            this.txtCADClientCidade.Clear();
            this.txtCADClientBairro.Clear();
            this.txtCADClientComp.Clear();
            this.txtCADClientLograd.Clear();
            this.txtCADClientNumero.Clear();
        }
        /*</LIMPAR CAMPOS>**/

        /*<CARREGAR PAINEL PADRAO>**/
        private void CarregarPainel()
        {
            if (this.tabMDPadraoSistema.SelectedTab == this.pnMDFuncionario)
            {
                if (this.tbMDFuncionario.SelectedTab == this.pnMDFUNCAD)
                {
                    this.AlterarBotoes("FunCad", 0);
                    this.DtGrdCadFuncionario();
                    this.FunCadCarregarComboEmpresa();
                }
                else if (this.tbMDFuncionario.SelectedTab == this.pnMDFUNCON)
                {
                    this.DtGrdConFuncionario();
                }
            }
            else if (this.tabMDPadraoSistema.SelectedTab == this.pnMDEmpresa)
            {

                if (this.tabMDEmpresa.SelectedTab == this.tbMDCadEmp)
                {
                    this.AlterarBotoes("EmpCad", 0);
                    this.EmpCadDtGrdEmpresa();
                    this.EmpCadCarregarComboPessoa();
                }
                else if (this.tabMDEmpresa.SelectedTab == this.tbMDConEmp)
                {
                    this.EmpConDtGrdEmpresa();
                }
                
            }
            else if (this.tabMDPadraoSistema.SelectedTab == this.pnMDCliente)
            {
                if (this.tabMDCliente.SelectedTab == this.tbMDCadCliente)
                {
                    this.AlterarBotoes("CliCad", 0);
                    this.CliCadDtgrCliente();
                }
                else if (this.tabMDCliente.SelectedTab == this.tbMDConCliente)
                {
                    this.CliConDtGrdCliente();
                }
            }
            else if (this.tabMDPadraoSistema.SelectedTab == this.pnMDItensProduto)
            {
                if (this.tabMDProduto.SelectedTab == this.tbMDCadProduto)
                {
                    this.AlterarBotoes("ProdCad", 0);
                    this.ProdCadCarregarTabelaProduto();
                    this.ProdCadCarregarComboSubCategoria();
                    this.ProdCadCarregarComboUnidadeVenda();
                }
                else if (this.tabMDProduto.SelectedTab == this.tbMDCadProduto)
                {
                    this.AlterarBotoes("ProdCon", 0);
                    this.ProdCadCarregarComboSubCategoria();
                }
            }

        }
        /*</CARREGAR PAINEL PADRAO>**/

        // ==========================================\\
        // [=======================================] \\
        // [PADROES DO SISTEMA] | [METOD()/OBJETO()] \\
        // [=======================================] \\
        // ==========================================\\


        // =========================================\\
        // [======================================] \\
        // [MODULO FUNCIONARIO] | [PAINEL CADASTRO] \\
        // [======================================] \\
        // =========================================\\
        /*<OBJETOS>**/
        private void btnCADFunNovo_Click(object sender, EventArgs e)
        {
            /*<Metodo() Generico>*/
            this.AlterarBotoes("FunCad", 1);
            /*<Metodo() Generico>*/
        }

        private void btnCADFunCancelar_Click(object sender, EventArgs e)
        {
            /*<Metodo() Generico>*/
            this.LimparCampos("FunCad");
            this.AlterarBotoes("FunCad", 0);
            /*</Metodo() Generico>*/
        }

        private void btnCADFunSalvar_Click(object sender, EventArgs e)
        {
            this.IncluirFuncionario();
        }

        private void btnCADFunSair_Click(object sender, EventArgs e)
        {
            MeusFormularios.PDSSForm.DialogResult = DialogResult.OK;
        }

        private void dtgrMDCADFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FunCadTransVrForm();
        }
        /*</OBJETOS>**/

        /*<FUNCAO>**/
        private void IncluirFuncionario()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            this.FunCadCarregarIndiceComboEstado(this.cbboxCADFunEstado.SelectedItem.ToString());
            fcInMd.Cidade = txtCADFunCidade.Text;
            fcInMd.Bairro = txtCADFunBairro.Text;
            fcInMd.Logradouro = txtCADFunLog.Text;
            fcInMd.NumeroEnd = txtCADFunNum.Text;
            fcInMd.Nome = txtCADFunNome.Text;
            fcInMd.Aniversario = Convert.ToDateTime(dtCADFunAniversario.Text);
            fcInMd.NumeroTel = txtCADFunTel.Text;
            fcInMd.NumeroCel = txtCADFunCel.Text;
            fcInMd.Login = txtCADFunLogin.Text;
            fcInMd.Senha = txtCADFunSenha.Text;
            fcInMd.ConSenha = txtCADFunConSenha.Text;
            this.FunCadCarregarIndiceComboPerfil(this.cbboxCADFunPerfil.SelectedItem.ToString());
            fcInMd.IDEmpresa = Convert.ToInt32(cbboxCADFunEmpresa.SelectedValue.ToString());

            FuncionarioBLL fcbll = new FuncionarioBLL(cx);

            if (fcbll.IncluirFuncionario(fcInMd))
            {
                this.LimparCampos("FunCad");
                this.AlterarBotoes("FunCad", 0);
                this.DtGrdCadFuncionario();
            }
        }

        private void FunCadTransVrForm()
        {
            int @indice = dtgrMDCADFuncionario.CurrentRow.Index;
            string @nome = dtgrMDCADFuncionario[1, indice].Value.ToString();
            string @login = dtgrMDCADFuncionario[2, indice].Value.ToString();

            if (MeusFormularios.ATFNForm == null)
                MeusFormularios.ATFNForm = new AtualizarFuncionarioForm(@login, @nome, @indice);

            MeusFormularios.ATFNForm.ShowDialog();

            if (MeusFormularios.ATFNForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATFNForm.Close();
                MeusFormularios.ATFNForm = null;
                this.CarregarPainel();
            }

        }

        private void DtGrdCadFuncionario()
        {
            this.FunCadCarregarTabelaFuncionario();
        }

        private void FunCadCarregarComboEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL empBLL = new FuncionarioBLL(cx);

            string @form = "CadFun";

            cbboxCADFunEmpresa.DataSource = empBLL.ComboBoxEmpresa(@form);
            cbboxCADFunEmpresa.DisplayMember = "razao";
            cbboxCADFunEmpresa.ValueMember = "id_empresa";
        }

        private void FunCadCarregarTabelaFuncionario()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);

            dtgrMDCADFuncionario.DataSource = fcbll.DtgrMDCadFuncionario();
            this.FunCadColunaTabelaTM();
        }

        private void FunCadColunaTabelaTM()
        {
            dtgrMDCADFuncionario.Columns[0].Width = 40;
            dtgrMDCADFuncionario.Columns[1].Width = 250;
            dtgrMDCADFuncionario.Columns[2].Width = 80;
            dtgrMDCADFuncionario.Columns[3].Width = 100;
            dtgrMDCADFuncionario.Columns[4].Width = 180;
            dtgrMDCADFuncionario.Columns[5].Width = 130;
            dtgrMDCADFuncionario.Columns[6].Width = 130;
            dtgrMDCADFuncionario.Columns[7].Width = 100;
            dtgrMDCADFuncionario.Columns[8].Width = 100;
            dtgrMDCADFuncionario.Columns[9].Width = 150;
            dtgrMDCADFuncionario.Columns[10].Width = 160;
            dtgrMDCADFuncionario.Columns[11].Width = 50;

            dtgrMDCADFuncionario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADFuncionario.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            dtgrMDCADFuncionario.Columns[0].HeaderText = "ID";
            dtgrMDCADFuncionario.Columns[1].HeaderText = "Nome";
            dtgrMDCADFuncionario.Columns[2].HeaderText = "Login";
            dtgrMDCADFuncionario.Columns[3].HeaderText = "Função";
            dtgrMDCADFuncionario.Columns[4].HeaderText = "Empresa";
            dtgrMDCADFuncionario.Columns[5].HeaderText = "Fixo";
            dtgrMDCADFuncionario.Columns[6].HeaderText = "Celular";
            dtgrMDCADFuncionario.Columns[7].HeaderText = "Estado";
            dtgrMDCADFuncionario.Columns[8].HeaderText = "Cidade";
            dtgrMDCADFuncionario.Columns[9].HeaderText = "Bairro";
            dtgrMDCADFuncionario.Columns[10].HeaderText = "Logradouro";
            dtgrMDCADFuncionario.Columns[11].HeaderText = "Nº";
        }

        private void FunCADCarregarItemComboPerfil(int perfil)
        {
            switch (perfil)
            {

                case 1:
                    this.cbboxCADFunPerfil.SelectedItem = "Presidente";
                    break;
                case 2:
                    this.cbboxCADFunPerfil.SelectedItem = "Gerente";
                    break;
                case 3:
                    this.cbboxCADFunPerfil.SelectedItem = "Coordenador";
                    break;
                case 4:
                    this.cbboxCADFunPerfil.SelectedItem = "Pizzaiolo";
                    break;
                case 5:
                    this.cbboxCADFunPerfil.SelectedItem = "Atendente";
                    break;
                case 6:
                    this.cbboxCADFunPerfil.SelectedItem = "Entregador";
                    break;
                default:
                    break;
            }
        }

        private void FunCadCarregarIndiceComboPerfil(string perfil)
        {
            switch (perfil)
            {

                case "Presidente":
                    fcInMd.Funcao = 1;
                    break;
                case "Gerente":
                    fcInMd.Funcao = 2;
                    break;
                case "Coordenador":
                    fcInMd.Funcao = 3;
                    break;
                case "Pizzaiolo":
                    fcInMd.Funcao = 4;
                    break;
                case "Atendente":
                    fcInMd.Funcao = 5;
                    break;
                case "Entregador":
                    fcInMd.Funcao = 6;
                    break;
                default:
                    break;
            }
        }

        private void FunCadCarregarItemComboEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxCADFunEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxCADFunEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxCADFunEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxCADFunEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxCADFunEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxCADFunEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxCADFunEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxCADFunEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxCADFunEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxCADFunEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxCADFunEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxCADFunEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxCADFunEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxCADFunEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxCADFunEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxCADFunEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxCADFunEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxCADFunEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxCADFunEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxCADFunEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxCADFunEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxCADFunEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxCADFunEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxCADFunEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxCADFunEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxCADFunEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxCADFunEstado.SelectedItem = "Tocantins";
                    break;
                default:
                    break;
            }
        }

        private void FunCadCarregarIndiceComboEstado(string estado)
        {
            switch (estado)
            {
                case "Acre":
                    fcInMd.Estado = 1;
                    break;
                case "Alagoas":
                    fcInMd.Estado = 2;
                    break;
                case "Amapá":
                    fcInMd.Estado = 3;
                    break;
                case "Amazonas":
                    fcInMd.Estado = 4;
                    break;
                case "Bahia":
                    fcInMd.Estado = 5;
                    break;
                case "Ceará":
                    fcInMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    fcInMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    fcInMd.Estado = 8;
                    break;
                case "Goiás":
                    fcInMd.Estado = 9;
                    break;
                case "Maranhão":
                    fcInMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    fcInMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    fcInMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    fcInMd.Estado = 13;
                    break;
                case "Pará":
                    fcInMd.Estado = 14;
                    break;
                case "Paraíba":
                    fcInMd.Estado = 15;
                    break;
                case "Paraná":
                    fcInMd.Estado = 16;
                    break;
                case "Pernambuco":
                    fcInMd.Estado = 17;
                    break;
                case "Piauí":
                    fcInMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    fcInMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    fcInMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    fcInMd.Estado = 21;
                    break;
                case "Rondônia":
                    fcInMd.Estado = 22;
                    break;
                case "Roraima":
                    fcInMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    fcInMd.Estado = 24;
                    break;
                case "São Paulo":
                    fcInMd.Estado = 25;
                    break;
                case "Sergipe":
                    fcInMd.Estado = 26;
                    break;
                case "Tocantins":
                    fcInMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }
        /*</FUNCAO>**/
        // =========================================\\
        // [======================================] \\
        // [MODULO FUNCIONARIO] | [PAINEL CADASTRO] \\
        // [======================================] \\
        // =========================================\\

        // =========================================\\
        // [======================================] \\
        // [MODULO FUNCIONARIO] | [PAINEL CONSULTA] \\
        // [======================================] \\
        // =========================================\\
        /*<OBJETOS>**/
        private void DtGrdConFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.FunConTransVrForm();
        }
        private void btnCONFunSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*</OBJETOS>**/

        /*<FUNCAO>**/
        private void ExcluirFuncionario()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);
            FuncionarioInModelo fcInMOD = new FuncionarioInModelo();

            fcInMOD.IDFuncionario = Convert.ToInt32(dtgrMDCADFuncionario.CurrentRow.Cells[0].Value.ToString());

            fcbll.ExcluirFuncionario(fcInMOD);
            this.DtGrdConFuncionario();
        }

        private void DtGrdConFuncionario()
        {
            this.FunConCarregarTabelaFuncionario();
        }

        private void FunConCarregarTabelaFuncionario()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);

            dtgrMDCONFuncionario.DataSource = fcbll.DtgrMDCadFuncionario();
            this.FunConColunaTabelaTM();
        }

        private void FunConLocalizarFuncionario()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);
            string @nome = "'%" + this.txtCONFunNomeLogin.Text + "%'";
            string @login = "'%" + this.txtCONFunNomeLogin.Text + "%'";

            if (this.chkBoxCONFunLogin.Checked == true)


            this.FunConColunaTabelaTM();
        }

        private void FunConColunaTabelaTM()
        {

            dtgrMDCONFuncionario.Columns[0].Width = 40;
            dtgrMDCONFuncionario.Columns[1].Width = 250;
            dtgrMDCONFuncionario.Columns[2].Width = 80;
            dtgrMDCONFuncionario.Columns[3].Width = 100;
            dtgrMDCONFuncionario.Columns[4].Width = 180;
            dtgrMDCONFuncionario.Columns[5].Width = 130;
            dtgrMDCONFuncionario.Columns[6].Width = 130;
            dtgrMDCONFuncionario.Columns[7].Width = 100;
            dtgrMDCONFuncionario.Columns[8].Width = 100;
            dtgrMDCONFuncionario.Columns[9].Width = 150;
            dtgrMDCONFuncionario.Columns[10].Width = 160;
            dtgrMDCONFuncionario.Columns[11].Width = 50;

            dtgrMDCONFuncionario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONFuncionario.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCONFuncionario.Columns[0].HeaderText = "ID";
            dtgrMDCONFuncionario.Columns[1].HeaderText = "Nome";
            dtgrMDCONFuncionario.Columns[2].HeaderText = "Login";
            dtgrMDCONFuncionario.Columns[3].HeaderText = "Função";
            dtgrMDCONFuncionario.Columns[4].HeaderText = "Empresa";
            dtgrMDCONFuncionario.Columns[5].HeaderText = "Fixo";
            dtgrMDCONFuncionario.Columns[6].HeaderText = "Celular";
            dtgrMDCONFuncionario.Columns[7].HeaderText = "Estado";
            dtgrMDCONFuncionario.Columns[8].HeaderText = "Cidade";
            dtgrMDCONFuncionario.Columns[9].HeaderText = "Bairro";
            dtgrMDCONFuncionario.Columns[10].HeaderText = "Logradouro";
            dtgrMDCONFuncionario.Columns[11].HeaderText = "Nº";

        }

        private void FunConTransVrForm()
        {
            int @indice = dtgrMDCONFuncionario.CurrentRow.Index;
            string @nome = dtgrMDCONFuncionario[1, indice].Value.ToString();
            string @login = dtgrMDCONFuncionario[2, indice].Value.ToString();

            if (MeusFormularios.ATFNForm == null)
                MeusFormularios.ATFNForm = new AtualizarFuncionarioForm(@login, @nome, @indice);

            MeusFormularios.ATFNForm.ShowDialog();

            if (MeusFormularios.ATFNForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATFNForm.Close();
                MeusFormularios.ATFNForm = null;
                this.CarregarPainel();
            }

        }
        /*</FUNCAO>**/
        // =========================================\\
        // [======================================] \\
        // [MODULO FUNCIONARIO] | [PAINEL CONSULTA] \\
        // [======================================] \\
        // =========================================\\

        // =========================================\\
        // [======================================] \\
        // [=[MODULO EMPRESA] | [PAINEL CADASTRO]=] \\
        // [======================================] \\
        // =========================================\\
        /*<OBJETOS>**/
        private void btnCADEmpNovo_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes("EmpCad", 1);
        }

        private void btnCADEmpCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes("EmpCad", 0);
            this.LimparCampos("EmpCad");
        }

        private void btnCADEmpSalvar_Click(object sender, EventArgs e)
        {
            this.IncluirEmpresa();
        }

        private void btnCADEmpSair_Click(object sender, EventArgs e)
        {
            MeusFormularios.PDSSForm.DialogResult = DialogResult.OK;
        }

        private void dtgrMDCADEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpCadTransVrForm();
        }
        /*</OBJETOS>**/

        /*<FUNCAO>**/
        private void IncluirEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            this.EmpCadCarregarIndiceComboEstado(this.cbboxCADEmpEstado.SelectedItem.ToString());
            EpInMd.Cidade = this.txtCADEmpCidade.Text;
            EpInMd.Bairro = this.txtCADEmpBairro.Text;
            EpInMd.Logradouro = this.txtCADEmpLog.Text;
            EpInMd.NumeroEnd = this.txtCADEmpNum.Text;
            EpInMd.Razao = this.txtCADEmpRazao.Text;
            EpInMd.IDPessoa = Convert.ToInt32(this.cbboxCADEmpResp.SelectedValue.ToString());
            EpInMd.NumeroTel = this.txtCADEmpTel.Text;
            EpInMd.NumeroCel = this.txtCADEmpFax.Text;

            EmpresaBLL empBLL = new EmpresaBLL(cx);

            int id = Convert.ToInt32(cbboxCADEmpResp.SelectedValue.ToString());

            if (empBLL.ValidarPessoa(id) == 1)
            {
                if (empBLL.IncluirEmpresa(EpInMd))
                {
                    this.LimparCampos("EmpCad");
                    this.AlterarBotoes("EmpCad", 1);
                    this.EmpCadDtGrdEmpresa();
                }
            }
            else
            {
                MessageBox.Show("Usuário não pode ser responsável pela Empresa: " + EpInMd.Razao + "!");
            }

        }

        private void EmpCadTransVrForm()
        {
            int @indice = dtgrMDCADEmpresa.CurrentRow.Index;
            string @razao = dtgrMDCADEmpresa[1, indice].Value.ToString();


            if (MeusFormularios.ATEMPForm == null)
                MeusFormularios.ATEMPForm = new AtualizarEmpresaForm(@razao, @indice);

            MeusFormularios.ATEMPForm.ShowDialog();

            if (MeusFormularios.ATEMPForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATEMPForm.Close();
                MeusFormularios.ATEMPForm = null;
                this.CarregarPainel();
            }

        } 

        private void EmpCadDtGrdEmpresa()
        {
            this.EmpCadCarregarTabelaEmpresa();
            this.EmpCadColunaTabelaTM();
        }

        private void EmpCadColunaTabelaTM()
        {
            dtgrMDCADEmpresa.Columns[0].Width = 40;
            dtgrMDCADEmpresa.Columns[1].Width = 280;
            dtgrMDCADEmpresa.Columns[2].Width = 250;
            dtgrMDCADEmpresa.Columns[3].Width = 100;
            dtgrMDCADEmpresa.Columns[4].Width = 100;
            dtgrMDCADEmpresa.Columns[5].Width = 100;
            dtgrMDCADEmpresa.Columns[6].Width = 100;
            dtgrMDCADEmpresa.Columns[7].Width = 80;
            dtgrMDCADEmpresa.Columns[8].Width = 280;
            dtgrMDCADEmpresa.Columns[9].Width = 80;

            dtgrMDCADEmpresa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCADEmpresa.Columns[0].HeaderText = "ID";
            dtgrMDCADEmpresa.Columns[1].HeaderText = "Razao";
            dtgrMDCADEmpresa.Columns[2].HeaderText = "Nome";
            dtgrMDCADEmpresa.Columns[3].HeaderText = "Tel";
            dtgrMDCADEmpresa.Columns[4].HeaderText = "Fax";
            dtgrMDCADEmpresa.Columns[5].HeaderText = "Estado";
            dtgrMDCADEmpresa.Columns[6].HeaderText = "Cidade";
            dtgrMDCADEmpresa.Columns[7].HeaderText = "Bairro";
            dtgrMDCADEmpresa.Columns[8].HeaderText = "Logradouro";
            dtgrMDCADEmpresa.Columns[9].HeaderText = "Nº";
        }

        private void EmpCadCarregarItemComboEstado(int estado = 0)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxCADEmpEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxCADEmpEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxCADEmpEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxCADEmpEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxCADEmpEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxCADEmpEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxCADEmpEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxCADEmpEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxCADEmpEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxCADEmpEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxCADEmpEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxCADEmpEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxCADEmpEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxCADEmpEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxCADEmpEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxCADEmpEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxCADEmpEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxCADEmpEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxCADEmpEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxCADEmpEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxCADEmpEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxCADEmpEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxCADEmpEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxCADEmpEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxCADEmpEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxCADEmpEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxCADEmpEstado.SelectedItem = "Tocantins";
                    break;
                default:
                    break;
            }
        }

        private void EmpCadCarregarIndiceComboEstado(string estado = null)
        {
            switch (estado)
            {
                case "Acre":
                    EpInMd.Estado = 1;
                    break;
                case "Alagoas":
                    EpInMd.Estado = 2;
                    break;
                case "Amapá":
                    EpInMd.Estado = 3;
                    break;
                case "Amazonas":
                    EpInMd.Estado = 4;
                    break;
                case "Bahia":
                    EpInMd.Estado = 5;
                    break;
                case "Ceará":
                    EpInMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    EpInMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    EpInMd.Estado = 8;
                    break;
                case "Goiás":
                    EpInMd.Estado = 9;
                    break;
                case "Maranhão":
                    EpInMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    EpInMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    EpInMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    EpInMd.Estado = 13;
                    break;
                case "Pará":
                    EpInMd.Estado = 14;
                    break;
                case "Paraíba":
                    EpInMd.Estado = 15;
                    break;
                case "Paraná":
                    EpInMd.Estado = 16;
                    break;
                case "Pernambuco":
                    EpInMd.Estado = 17;
                    break;
                case "Piauí":
                    EpInMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    EpInMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    EpInMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    EpInMd.Estado = 21;
                    break;
                case "Rondônia":
                    EpInMd.Estado = 22;
                    break;
                case "Roraima":
                    EpInMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    EpInMd.Estado = 24;
                    break;
                case "São Paulo":
                    EpInMd.Estado = 25;
                    break;
                case "Sergipe":
                    EpInMd.Estado = 26;
                    break;
                case "Tocantins":
                    EpInMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }

        private void EmpCadValidarPessoa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL empBLL = new EmpresaBLL(cx);


        }

        private void EmpCadCarregarComboPessoa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL empBLL = new EmpresaBLL(cx);

            cbboxCADEmpResp.DataSource = empBLL.LocalizarPessoa("PDSMFORM", 0);
            cbboxCADEmpResp.DisplayMember = "nome";
            cbboxCADEmpResp.ValueMember = "id_pessoa";
        }

        private void EmpCadCarregarTabelaEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL empBLL = new EmpresaBLL(cx);

            dtgrMDCADEmpresa.DataSource = empBLL.DtgrMDEmpresa();
            this.EmpCadColunaTabelaTM();
        }
        /*</FUNCAO>**/
        // =========================================\\
        // [======================================] \\
        // [=[MODULO EMPRESA] | [PAINEL CADASTRO]=] \\
        // [======================================] \\
        // =========================================\\

        // =========================================\\
        // [======================================] \\
        // [=[MODULO EMPRESA] | [PAINEL CONSULTA]=] \\
        // [======================================] \\
        // =========================================\\
        /*<OBJETOS>**/
        private void btnCONEmpSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dtgrMDCONEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpConTransVrForm();
        }
        /*</OBJETOS>**/

        /*<FUNCAO>**/
        private void ExcluirEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);
            FuncionarioInModelo fcInMOD = new FuncionarioInModelo();
            int @indice = dtgrMDCONEmpresa.CurrentRow.Index;

            fcInMOD.IDFuncionario = Convert.ToInt32(dtgrMDCONFuncionario.CurrentRow.Cells[@indice].Value.ToString());

            fcbll.ExcluirFuncionario(fcInMOD);
            this.EmpConDtGrdEmpresa();
        }

        private void EmpConDtGrdEmpresa()
        {
            this.EmpConCarregarTabelaEmpresa();

            this.EmpConColunaTabelaTM();
        }

        private void EmpConColunaTabelaTM()
        {
            dtgrMDCONEmpresa.Columns[0].Width = 40;
            dtgrMDCONEmpresa.Columns[1].Width = 280;
            dtgrMDCONEmpresa.Columns[2].Width = 250;
            dtgrMDCONEmpresa.Columns[3].Width = 100;
            dtgrMDCONEmpresa.Columns[4].Width = 100;
            dtgrMDCONEmpresa.Columns[5].Width = 100;
            dtgrMDCONEmpresa.Columns[6].Width = 100;
            dtgrMDCONEmpresa.Columns[7].Width = 80;
            dtgrMDCONEmpresa.Columns[8].Width = 280;
            dtgrMDCONEmpresa.Columns[9].Width = 80;

            dtgrMDCONEmpresa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCONEmpresa.Columns[0].HeaderText = "ID";
            dtgrMDCONEmpresa.Columns[1].HeaderText = "Razao";
            dtgrMDCONEmpresa.Columns[2].HeaderText = "Nome";
            dtgrMDCONEmpresa.Columns[3].HeaderText = "Tel";
            dtgrMDCONEmpresa.Columns[4].HeaderText = "Fax";
            dtgrMDCONEmpresa.Columns[5].HeaderText = "Estado";
            dtgrMDCONEmpresa.Columns[6].HeaderText = "Cidade";
            dtgrMDCONEmpresa.Columns[7].HeaderText = "Bairro";
            dtgrMDCONEmpresa.Columns[8].HeaderText = "Logradouro";
            dtgrMDCONEmpresa.Columns[9].HeaderText = "Nº";
        }

        private void EmpConCarregarTabelaEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL empBLL = new EmpresaBLL(cx);

            dtgrMDCONEmpresa.DataSource = empBLL.DtgrMDEmpresa();
            this.EmpConColunaTabelaTM();
        }

        private void EmpConLocalizarEmpresa()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL epbll = new EmpresaBLL(cx);
            string @razao = this.txtCONEmpRazao.Text;

            dtgrMDCONEmpresa.DataSource = epbll.LocalizarEmpresa(@razao);
        }

        private void EmpConTransVrForm()
        {
            int @indice = dtgrMDCONEmpresa.CurrentRow.Index;
            string @razao = dtgrMDCONEmpresa[1, indice].Value.ToString();


            if (MeusFormularios.ATEMPForm == null)
                MeusFormularios.ATEMPForm = new AtualizarEmpresaForm(@razao, @indice);

            MeusFormularios.ATEMPForm.ShowDialog();

            if (MeusFormularios.ATEMPForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATEMPForm.Close();
                MeusFormularios.ATEMPForm = null;
                this.CarregarPainel();
            }

        }      
        /*</FUNCAO>**/
        // =========================================\\
        // [======================================] \\
        // [=[MODULO EMPRESA] | [PAINEL CONSULTA]=] \\
        // [======================================] \\
        // =========================================\\


        // =====================================\\
        // [==================================] \\
        // [MODULO CLIENTE] | [PAINEL CADASTRO] \\
        // [==================================] \\
        // =====================================\\
        /*<OBJETO>**/
        private void btnCADClientSalvar_Click(object sender, EventArgs e)
        {
            this.IncluirCliente();
        }

        private void btnCADClientNovo_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes("CliCad", 1);
        }

        private void btnCADClientCanc_Click(object sender, EventArgs e)
        {
            this.LimparCampos("CliCad");
            this.AlterarBotoes("CliCad", 0);
        }

        private void dtgrMDCADCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CliCadTransVrForm();
        }

        private void btnCADClientSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*</OBJETO>**/

        /*<FUNCAO>**/
        private void IncluirCliente()
        {
            ClInMd.Nome = this.txtCADClientNome.Text;
            ClInMd.NumeroTel = this.txtCADClientTel.Text;
            ClInMd.NumeroCel = this.txtCADClientCel.Text;
            this.ClICadCarregarIndiceComboEstado(this.cbboxCADClientEstado.SelectedItem.ToString());
            ClInMd.Aniversario = Convert.ToDateTime(dtCADCliAniversario.Text);
            ClInMd.Cidade = this.txtCADClientCidade.Text;
            ClInMd.Bairro = this.txtCADClientBairro.Text;
            ClInMd.Logradouro = this.txtCADClientLograd.Text;
            ClInMd.NumeroEnd = this.txtCADClientNumero.Text;
            //ClInMd.Codigo = 

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            ClienteBLL CliBLL = new ClienteBLL(cx);

            if (CliBLL.IncluirCliente(ClInMd, "CADASTRO"))
            {
                this.LimparCampos("CliCad");
                this.AlterarBotoes("CliCad", 0);
                this.CliCadDtgrCliente();
            }
        }

        private void CliCadDtgrCliente()
        {
            this.CliCadCarregarTabelaCliente();
            this.CliCadColunaTabelaTM();
        }

        private void CliCadColunaTabelaTM()
        {
            dtgrMDCADCliente.Columns[0].Width = 110;
            dtgrMDCADCliente.Columns[1].Width = 250;
            dtgrMDCADCliente.Columns[2].Width = 150;
            dtgrMDCADCliente.Columns[3].Width = 150;
            dtgrMDCADCliente.Columns[4].Width = 180;
            dtgrMDCADCliente.Columns[5].Width = 200;
            dtgrMDCADCliente.Columns[6].Width = 70;
            dtgrMDCADCliente.Columns[7].Width = 100;
            dtgrMDCADCliente.Columns[8].Width = 150;
            dtgrMDCADCliente.Columns[9].Width = 150;

            dtgrMDCADCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADCliente.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCADCliente.Columns[0].HeaderText = "Codigo";
            dtgrMDCADCliente.Columns[1].HeaderText = "Nome";
            dtgrMDCADCliente.Columns[2].HeaderText = "Estado";
            dtgrMDCADCliente.Columns[3].HeaderText = "Cidade";
            dtgrMDCADCliente.Columns[4].HeaderText = "Bairro";
            dtgrMDCADCliente.Columns[5].HeaderText = "Logradouro";
            dtgrMDCADCliente.Columns[6].HeaderText = "Nº";
            dtgrMDCADCliente.Columns[7].HeaderText = "Complemento";
            dtgrMDCADCliente.Columns[8].HeaderText = "Tel";
            dtgrMDCADCliente.Columns[9].HeaderText = "Cel";
        }

        private void CliCadCarregarTabelaCliente()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            ClienteBLL CliBLL = new ClienteBLL(cx);

            dtgrMDCADCliente.DataSource = CliBLL.DtgrMDCliente();
        }

        private void ClICadCarregarItemComboEstado(int estado)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxCADClientEstado.SelectedItem = "Acre";
                    break;
                case 2:
                    this.cbboxCADClientEstado.SelectedItem = "Alagoas";
                    break;
                case 3:
                    this.cbboxCADClientEstado.SelectedItem = "Amapá";
                    break;
                case 4:
                    this.cbboxCADClientEstado.SelectedItem = "Amazonas";
                    break;
                case 5:
                    this.cbboxCADClientEstado.SelectedItem = "Bahia";
                    break;
                case 6:
                    this.cbboxCADClientEstado.SelectedItem = "Ceará";
                    break;
                case 7:
                    this.cbboxCADClientEstado.SelectedItem = "Distrito Federal";
                    break;
                case 8:
                    this.cbboxCADClientEstado.SelectedItem = "Espírito Santo";
                    break;
                case 9:
                    this.cbboxCADClientEstado.SelectedItem = "Goiás";
                    break;
                case 10:
                    this.cbboxCADClientEstado.SelectedItem = "Maranhão";
                    break;
                case 11:
                    this.cbboxCADClientEstado.SelectedItem = "Mato Grosso";
                    break;
                case 12:
                    this.cbboxCADClientEstado.SelectedItem = "Mato Grosso do Sul";
                    break;
                case 13:
                    this.cbboxCADClientEstado.SelectedItem = "Minas Gerais";
                    break;
                case 14:
                    this.cbboxCADClientEstado.SelectedItem = "Pará";
                    break;
                case 15:
                    this.cbboxCADClientEstado.SelectedItem = "Paraíba";
                    break;
                case 16:
                    this.cbboxCADClientEstado.SelectedItem = "Paraná";
                    break;
                case 17:
                    this.cbboxCADClientEstado.SelectedItem = "Pernambuco";
                    break;
                case 18:
                    this.cbboxCADClientEstado.SelectedItem = "Piauí";
                    break;
                case 19:
                    this.cbboxCADClientEstado.SelectedItem = "Rio de Janeiro";
                    break;
                case 20:
                    this.cbboxCADClientEstado.SelectedItem = "Rio Grande do Norte";
                    break;
                case 21:
                    this.cbboxCADClientEstado.SelectedItem = "Rio Grande do Sul";
                    break;
                case 22:
                    this.cbboxCADClientEstado.SelectedItem = "Rondônia";
                    break;
                case 23:
                    this.cbboxCADClientEstado.SelectedItem = "Roraima";
                    break;
                case 24:
                    this.cbboxCADClientEstado.SelectedItem = "Santa Catarina";
                    break;
                case 25:
                    this.cbboxCADClientEstado.SelectedItem = "São Paulo";
                    break;
                case 26:
                    this.cbboxCADClientEstado.SelectedItem = "Sergipe";
                    break;
                case 27:
                    this.cbboxCADClientEstado.SelectedItem = "Tocantins";
                    break;
                default:
                    break;
            }
        }

        private void ClICadCarregarIndiceComboEstado(string estado)
        {
            switch (estado)
            {
                case "Acre":
                    ClInMd.Estado = 1;
                    break;
                case "Alagoas":
                    ClInMd.Estado = 2;
                    break;
                case "Amapá":
                    ClInMd.Estado = 3;
                    break;
                case "Amazonas":
                    ClInMd.Estado = 4;
                    break;
                case "Bahia":
                    ClInMd.Estado = 5;
                    break;
                case "Ceará":
                    ClInMd.Estado = 6;
                    break;
                case "Distrito Federal":
                    ClInMd.Estado = 7;
                    break;
                case "Espírito Santo":
                    ClInMd.Estado = 8;
                    break;
                case "Goiás":
                    ClInMd.Estado = 9;
                    break;
                case "Maranhão":
                    ClInMd.Estado = 10;
                    break;
                case "Mato Grosso":
                    ClInMd.Estado = 11;
                    break;
                case "Mato Grosso do Sul":
                    ClInMd.Estado = 12;
                    break;
                case "Minas Gerais":
                    ClInMd.Estado = 13;
                    break;
                case "Pará":
                    ClInMd.Estado = 14;
                    break;
                case "Paraíba":
                    ClInMd.Estado = 15;
                    break;
                case "Paraná":
                    ClInMd.Estado = 16;
                    break;
                case "Pernambuco":
                    ClInMd.Estado = 17;
                    break;
                case "Piauí":
                    ClInMd.Estado = 18;
                    break;
                case "Rio de Janeiro":
                    ClInMd.Estado = 19;
                    break;
                case "Rio Grande do Norte":
                    ClInMd.Estado = 20;
                    break;
                case "Rio Grande do Sul":
                    ClInMd.Estado = 21;
                    break;
                case "Rondônia":
                    ClInMd.Estado = 22;
                    break;
                case "Roraima":
                    ClInMd.Estado = 23;
                    break;
                case "Santa Catarina":
                    ClInMd.Estado = 24;
                    break;
                case "São Paulo":
                    ClInMd.Estado = 25;
                    break;
                case "Sergipe":
                    ClInMd.Estado = 26;
                    break;
                case "Tocantins":
                    ClInMd.Estado = 27;
                    break;
                default:
                    break;
            }
        }

        private void CliCadTransVrForm()
        {
            int @indice = dtgrMDCADCliente.CurrentRow.Index;
            string @nome = dtgrMDCADCliente[1, @indice].Value.ToString();
            string @form = "ATUALIZAR";

            if (MeusFormularios.ATCLIForm == null)
                MeusFormularios.ATCLIForm = new AtualizarClienteForm(@nome, @form);

            MeusFormularios.ATCLIForm.ShowDialog();

            if (MeusFormularios.ATCLIForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATCLIForm.Close();
                MeusFormularios.ATCLIForm = null;
                this.CarregarPainel();
            }

        }
        /*</FUNCAO>**/
        // =====================================\\
        // [==================================] \\
        // [MODULO CLIENTE] | [PAINEL CADASTRO] \\
        // [==================================] \\
        // =====================================\\

        
        // =====================================\\
        // [==================================] \\
        // [MODULO CLIENTE] | [PAINEL CONSULTA] \\
        // [==================================] \\
        // =====================================\\
        /*<OBJETO>**/
        private void dtgrMDCONCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CliConTransVrForm();
        }

        private void btnCONClientSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /*</OBJETO>**/

        /*<FUNCAO>**/
        private void ExcluirCliente()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            FuncionarioBLL fcbll = new FuncionarioBLL(cx);
            ClienteAtModelo ClinMOD = new ClienteAtModelo();
            int @indice = dtgrMDCONCliente.CurrentRow.Index;

            ClinMOD.IDCliente = Convert.ToInt32(dtgrMDCONCliente.CurrentRow.Cells[@indice].Value.ToString());

            //fcbll.ExcluirCliente(fcInMOD);
            this.CliConDtGrdCliente();
        }

        private void CliConDtGrdCliente()
        {
            this.CliConCarregarTabelaCliente();

            this.CliConColunaTabelaTM();
        }

        private void CliConColunaTabelaTM()
        {
            dtgrMDCONCliente.Columns[0].Width = 110;
            dtgrMDCONCliente.Columns[1].Width = 250;
            dtgrMDCONCliente.Columns[2].Width = 150;
            dtgrMDCONCliente.Columns[3].Width = 150;
            dtgrMDCONCliente.Columns[4].Width = 180;
            dtgrMDCONCliente.Columns[5].Width = 200;
            dtgrMDCONCliente.Columns[6].Width = 70;
            dtgrMDCONCliente.Columns[7].Width = 100;
            dtgrMDCONCliente.Columns[8].Width = 150;
            dtgrMDCONCliente.Columns[9].Width = 150;

            dtgrMDCONCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCONCliente.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCONCliente.Columns[0].HeaderText = "Codigo";
            dtgrMDCONCliente.Columns[1].HeaderText = "Nome";
            dtgrMDCONCliente.Columns[2].HeaderText = "Estado";
            dtgrMDCONCliente.Columns[3].HeaderText = "Cidade";
            dtgrMDCONCliente.Columns[4].HeaderText = "Bairro";
            dtgrMDCONCliente.Columns[5].HeaderText = "Logradouro";
            dtgrMDCONCliente.Columns[6].HeaderText = "Nº";
            dtgrMDCONCliente.Columns[7].HeaderText = "Complemento";
            dtgrMDCONCliente.Columns[8].HeaderText = "Tel";
            dtgrMDCONCliente.Columns[9].HeaderText = "Cel";
        }

        private void CliConCarregarTabelaCliente()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            ClienteBLL CliBLL = new ClienteBLL(cx);

            dtgrMDCONCliente.DataSource = CliBLL.DtgrMDCliente();
        }

        private void CliConLocalizarCliente()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            EmpresaBLL epbll = new EmpresaBLL(cx);
            //string @razao = this.txtCONEmpRazao.Text;

            //dtgrMDCONEmpresa.DataSource = epbll.LocalizarEmpresa(@razao);
        }

        private void CliConTransVrForm()
        {
            int @indice = dtgrMDCONCliente.CurrentRow.Index;
            string @nome = dtgrMDCONCliente[1, @indice].Value.ToString();
            string @form = "ATUALIZAR";

            if (MeusFormularios.ATCLIForm == null)
                MeusFormularios.ATCLIForm = new AtualizarClienteForm(@nome, @form);

            MeusFormularios.ATCLIForm.ShowDialog();

            if (MeusFormularios.ATCLIForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.ATCLIForm.Close();
                MeusFormularios.ATCLIForm = null;
                this.CarregarPainel();
            }

        }

        private void btnCADProdutoSubCat_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.SBCATPROForm == null)
                MeusFormularios.SBCATPROForm = new SubCategoriaProdutoForm();

            MeusFormularios.SBCATPROForm.ShowDialog();

            if (MeusFormularios.SBCATPROForm.DialogResult == DialogResult.OK)
            {
                MeusFormularios.SBCATPROForm.Close();
                MeusFormularios.SBCATPROForm = null;
            }
        }


        /*</FUNCAO>**/
        // =====================================\\
        // [==================================] \\
        // [MODULO CLIENTE] | [PAINEL CONSULTA] \\
        // [==================================] \\
        // =====================================\\

        // =====================================\\
        // [==================================] \\
        // [MODULO PRODUTO] | [PAINEL CADASTRO] \\
        // [==================================] \\
        // =====================================\\
        /*<OBJETO>**/
        private void btnCADProdutoNovo_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes("ProdCad", 1);
        }

        private void btnCADProdutoCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes("ProdCad", 0);
        }

        private void cbboxCADProdutoSubCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            this.ProdCadCarregarComboSubCategoria();
        }

        private void btnCADProdutoSalvar_Click(object sender, EventArgs e)
        {
            this.IncluirProduto();
        }

        private void btnCADProdutoSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        /*</OBJETO>**/

        /*<FUNCAO>**/


        private void IncluirProduto()
        {
            ProdInMd.Produto = this.txtMDCADProduto.Text;
            ProdInMd.Preco = Convert.ToDecimal(this.txtMDCADPreco.Text);
            ProdInMd.IDSubCategoria = Convert.ToInt32(this.cbboxCADProdutoSubCategoria.SelectedValue.ToString());
            ProdInMd.IDFuncionario = LoginSecaoModelo.id_funcionario;
            ProdInMd.IDUnidadeVenda = Convert.ToInt32(this.cbboxCADProdutoUnVenda.SelectedValue.ToString());


            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            ProdutoBLL ProdBLL = new ProdutoBLL(cx);

            if (ProdBLL.IncluirProduto(ProdInMd))
            {
                this.LimparCampos("ProdCad");
                this.AlterarBotoes("ProdCad", 0);
                this.CarregarPainel();
            }
        }

        private void ProdCadCarregarTabelaProduto()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            ProdutoBLL ProdBLL = new ProdutoBLL(cx);

            dtgrMDCADProduto.DataSource = ProdBLL.DtgrMDProduto();
        }

        private void ProdCadCarregarComboUnidadeVenda()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            UnidadeVendaBLL UnVdBLL = new UnidadeVendaBLL(cx);

            cbboxCADProdutoUnVenda.DataSource = UnVdBLL.DtgrUnidadeVenda();
            cbboxCADProdutoUnVenda.DisplayMember = "SIGLA";
            cbboxCADProdutoUnVenda.ValueMember = "ID";
        }

        private void ProdCadCarregarComboSubCategoria()
        {
            int @cat = 0;
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            SubCategoriaBLL SubCatBLL = new SubCategoriaBLL(cx);

            @cat = this.cbboxCADProdutoCategoria.SelectedIndex;
            
            switch(@cat)
            {
                case -1:
                    @cat = 0;
                    break;
                case 0:
                    @cat = 1;
                    break;
                case 1:
                    @cat = 2;
                    break;
            }

            cbboxCADProdutoSubCategoria.DataSource = SubCatBLL.LocalizarSubCategoria(@cat);
            cbboxCADProdutoSubCategoria.DisplayMember = "subcategoria";
            cbboxCADProdutoSubCategoria.ValueMember = "id_subcategoria";
        }
        /*</FUNCAO>**/
        // =====================================\\
        // [==================================] \\
        // [MODULO PRODUTO] | [PAINEL CADASTRO] \\
        // [==================================] \\
        // =====================================\\

        // =====================================\\
        // [==================================] \\
        // [MODULO PRODUTO] | [PAINEL CONSULTA] \\
        // [==================================] \\
        // =====================================\\
        /*<OBJETO>**/

        /*</OBJETO>**/

        /*<FUNCAO>**/

        /*</FUNCAO>**/

        // =====================================\\
        // [==================================] \\
        // [MODULO PRODUTO] | [PAINEL CONSULTA] \\
        // [==================================] \\
        // =====================================\\
    }
}
