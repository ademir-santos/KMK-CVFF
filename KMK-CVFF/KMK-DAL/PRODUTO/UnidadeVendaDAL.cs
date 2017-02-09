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
    public class UnidadeVendaDAL
    {
        private ConexaoDAL Conexao;


        public UnidadeVendaDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public DataTable LocalizarUnidadeVenda(string @sigla = null, string @unidade = null)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_UNIDADE_VENDA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_SIGLA", @sigla);
                mysql.Parameters.AddWithValue("_UNIDADEVENDA", @unidade);

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

        public bool ValidarUnidadeVenda(string @sigla = null, string @unidade = null)
        {
            bool ret = false;

            if (!ret)
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_UNIDADE_VENDA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_SIGLA", @sigla);
                mysql.Parameters.AddWithValue("_UNIDADEVENDA", @unidade);

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

        public DataTable DtgrUnidadeVenda()
        {
            DataTable tabela = new DataTable();

            try
            {
                string query = "SELECT * FROM MYVW_DTGR_UNIDADE_VENDA";
                MySqlCommand NewMysql = new MySqlCommand(query, this.Conexao.ObjetoConexao);
                this.Conexao.Conectar();

                MySqlDataReader result = NewMysql.ExecuteReader();
                tabela.Load(result);
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n " + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return tabela;
        }
    }
}
