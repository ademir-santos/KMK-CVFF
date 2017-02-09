using KMK_BLL.PRODUTO;
using KMK_DAL.CONEXAO;
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

namespace KMK_GUI.VIEWS.SUB_FORMS.PRODUTO
{
    public partial class SubCategoriaProdutoForm : Form
    {
        static CategoriaInModelo CatInMd = new CategoriaInModelo();

        public SubCategoriaProdutoForm()
        {
            InitializeComponent();
        }

        private void SubCategoriaProdutoForm_Load(object sender, EventArgs e)
        {
            this.CarregarTabelaSubCategoria();
        }

        private void btnCADSubCatProdSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void IncluirSubCategoria()
        {
            this.CarregarIndiceComboCategoria(this.cbboxCADSubCatCategoria.SelectedItem.ToString());
            CatInMd.SubCategoria = this.txtCADSubCatSubCategoria.Text;
 

            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            SubCategoriaBLL SubCatBLL = new SubCategoriaBLL(cx);

            if (SubCatBLL.IncluirSubCategoria(CatInMd))
            {
                //this.LimparCampos("CliCad");
                //this.AlterarBotoes("CliCad", 0);
                this.CarregarTabelaSubCategoria();
            }
        }

        private void CarregarTabelaSubCategoria()
        {
            ConexaoDAL cx = new ConexaoDAL(DadosConexao.StringDeConexao);
            SubCategoriaBLL SubCatBLL = new SubCategoriaBLL(cx);

            dtgrMDCADSubCategoria.DataSource = SubCatBLL.DtgrSubCategoria();
            this.ColunaTabelaTM();
        }

        private void ColunaTabelaTM()
        {
            dtgrMDCADSubCategoria.Columns[0].Width = 60;
            dtgrMDCADSubCategoria.Columns[1].Width = 266;

            dtgrMDCADSubCategoria.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrMDCADSubCategoria.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgrMDCADSubCategoria.Columns[0].HeaderText = "ID";
            dtgrMDCADSubCategoria.Columns[1].HeaderText = "SubCategoria";
        }

        private void btnCADSubCatProdSalvar_Click(object sender, EventArgs e)
        {
            this.IncluirSubCategoria();
        }

        private void CarregarItemComboCategoria(int estado = 0)
        {
            switch (estado)
            {
                case 1:
                    this.cbboxCADSubCatCategoria.SelectedItem = "Bebidas";
                    break;
                case 2:
                    this.cbboxCADSubCatCategoria.SelectedItem = "Alimentação";
                    break;
                default:
                    break;
            }
        }

        private void CarregarIndiceComboCategoria(string estado = null)
        {
            switch (estado)
            {
                case "Bebidas":
                    CatInMd.Categoria = 1;
                    break;
                case "Alimentação":
                    CatInMd.Categoria = 2;
                    break;
                default:
                    break;
            }
        }

    }
}
