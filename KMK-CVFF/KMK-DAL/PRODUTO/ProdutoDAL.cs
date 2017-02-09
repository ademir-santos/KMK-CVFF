using KMK_DAL.CONEXAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KMK_MODELO.PRODUTO;

namespace KMK_DAL.PRODUTO
{
    public class ProdutoDAL
    {
        private ConexaoDAL Conexao;

        public ProdutoDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirProduto(ProdutoInModelo ProdInMd = null)
        {
            bool ret = false;
            try
            {
                if (!ValidarProduto(ProdInMd.Produto, ProdInMd.IDSubCategoria))
                {
                    MySqlCommand cmd = new MySqlCommand("MYSP_INCLUIR_PRODUTO");
                    cmd.Connection = Conexao.ObjetoConexao;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_PRODUTO", ProdInMd.Produto);
                    cmd.Parameters.AddWithValue("_PRECO", ProdInMd.Preco);
                    cmd.Parameters.AddWithValue("_IDSUBCATEGORIA", ProdInMd.IDSubCategoria);
                    cmd.Parameters.AddWithValue("_IDFUNCIONARIO", ProdInMd.IDFuncionario);
                    cmd.Parameters.AddWithValue("_IDUNVENDA", ProdInMd.IDUnidadeVenda);

                    this.Conexao.Conectar();
                    cmd.ExecuteNonQuery();


                    if (ret = ValidarProduto(ProdInMd.Produto, ProdInMd.IDSubCategoria))
                        MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("SubCategoria já cadastrada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return ret;
        }

        public bool ValidarProduto(string @produto = null, int @idsubcategoria = 0)
        {
            bool ret = false;

            if (!ret)
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_VALIDAR_PRODUTO", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_PRODUTO", @produto);
                mysql.Parameters.AddWithValue("_SUBCATEGORIA", @idsubcategoria);

                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader();

                if (result.Read())
                {
                    ret = true;
                }

                this.Conexao.Desconectar();
            }

            return ret;
        }

        public DataTable DtgrProduto()
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("SELECT * FROM MYVW_DTGR_PRODUTO", this.Conexao.ObjetoConexao);
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader();
                tabela.Load(result);
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return tabela;
        }
    }
}
