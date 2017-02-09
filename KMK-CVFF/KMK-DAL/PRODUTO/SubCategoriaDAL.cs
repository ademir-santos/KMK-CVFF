using KMK_DAL.CONEXAO;
using KMK_MODELO.PRODUTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMK_DAL.PRODUTO
{
    public class SubCategoriaDAL
    {
        private ConexaoDAL Conexao;


        public SubCategoriaDAL(ConexaoDAL cx = null)
        {
            this.Conexao = cx;
        }

        public bool IncluirSubCategoria(CategoriaInModelo CatInMd = null)
        {
            bool ret = false;
            try
            {
                if (!ValidarSubCategoria(CatInMd.SubCategoria))
                {
                    MySqlCommand cmd = new MySqlCommand("MYSP_INCLUIR_SUBCATEGORIA");
                    cmd.Connection = Conexao.ObjetoConexao;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_CATEGORIA", CatInMd.Categoria);
                    cmd.Parameters.AddWithValue("_SUBCATEGORIA", CatInMd.SubCategoria);

                    this.Conexao.Conectar();
                    cmd.ExecuteNonQuery();


                    if (ret = ValidarSubCategoria(CatInMd.SubCategoria))
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

        public DataTable LocalizarSubCategoria(int @categoria = 0)
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_SELECIONAR_SUBCATEGORIA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_CATEGORIA", @categoria);

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

        public bool ValidarSubCategoria(string @subcategoria = null)
        {
            bool ret = false;

            if (!ret)
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_VALIDAR_SUBCATEGORIA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_SUBCATEGORIA", @subcategoria);

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

        public DataTable DtgrSubCategoria()
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("SELECT * FROM MYVW_DTGR_SUBCATEGORIA", this.Conexao.ObjetoConexao);
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
