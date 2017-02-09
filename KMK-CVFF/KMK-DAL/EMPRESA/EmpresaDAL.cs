using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMK_DAL.CONEXAO;
using System.Data;
using System.Windows.Forms;
using KMK_MODELO.EMPRESA;

namespace KMK_DAL.EMPRESA
{
    public class EmpresaDAL
    {
        private ConexaoDAL Conexao;


        public EmpresaDAL(ConexaoDAL cx = null)
        {
            this.Conexao = cx;
        }

        public bool IncluirEmpresa(EmpresaInModelo EmpInc = null)
        {
            bool ret = false;
            try
            {
                if (!ValidarEmpresa(EmpInc.Razao))
                {
                    MySqlCommand cmd = new MySqlCommand("MYSP_INCLUIR_EMPRESA");
                    cmd.Connection = Conexao.ObjetoConexao;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ESTADO", EmpInc.Estado);
                    cmd.Parameters.AddWithValue("_CIDADE", EmpInc.Cidade);
                    cmd.Parameters.AddWithValue("_BAIRRO", EmpInc.Bairro);
                    cmd.Parameters.AddWithValue("_LOGRADOURO", EmpInc.Logradouro);
                    cmd.Parameters.AddWithValue("_NUMERO", EmpInc.NumeroEnd);
                    cmd.Parameters.AddWithValue("_RAZAO", EmpInc.Razao);
                    cmd.Parameters.AddWithValue("_IDPESSOA", EmpInc.IDPessoa);
                    cmd.Parameters.AddWithValue("_NUMEROCOM", EmpInc.NumeroTel);
                    cmd.Parameters.AddWithValue("_NUMEROFAX", EmpInc.NumeroCel);

                    this.Conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    this.Conexao.Desconectar();

                    if (ret = ValidarEmpresa(EmpInc.Razao))
                        MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Empresa já cadastrada!");
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

        public bool AtualizarEmpresa(EmpresaAtModelo empAtMD)
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand("MYSP_ATUALIZAR_EMPRESA");
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IDENDERECO", empAtMD.IDEnd);
                cmd.Parameters.AddWithValue("_IDPESSOA", empAtMD.IDPessoa);
                cmd.Parameters.AddWithValue("_IDTELEFONE", empAtMD.IDTelefone);
                cmd.Parameters.AddWithValue("_IDEMPRESA", empAtMD.IDEmpresa);
                cmd.Parameters.AddWithValue("_ESTADO", empAtMD.Estado);
                cmd.Parameters.AddWithValue("_CIDADE", empAtMD.Cidade);
                cmd.Parameters.AddWithValue("_BAIRRO", empAtMD.Bairro);
                cmd.Parameters.AddWithValue("_LOGRADOURO", empAtMD.Logradouro);
                cmd.Parameters.AddWithValue("_NUMERO", empAtMD.NumeroEnd);
                cmd.Parameters.AddWithValue("_NOME", empAtMD.Nome);
                cmd.Parameters.AddWithValue("_NUMEROCOM", empAtMD.NumeroCom);
                cmd.Parameters.AddWithValue("_NUMEROFAX", empAtMD.NumeroFax);
                cmd.Parameters.AddWithValue("_RAZAO", empAtMD.Razao);

                this.Conexao.Conectar();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Atualizado com sucesso!");

                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
                ret = true;
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return ret;
        }

        public bool ValidarEmpresa(string razao = null)
        {
            bool ret = false;

            if (!ret)
            {

                MySqlCommand mysql = new MySqlCommand("MYSP_VALIDAR_EMPRESA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_RAZAO", razao);

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

        public DataTable LocalizarPessoa(string MsForms, int id = 0)
        {
            DataTable tabela = new DataTable();
            try
            {
                if (MsForms.Equals("PDSMFORM"))
                {
                    MySqlCommand mysql = new MySqlCommand("MYSP_SELECIONAR_PESSOA", this.Conexao.ObjetoConexao);
                    mysql.CommandType = CommandType.StoredProcedure;
                    this.Conexao.Conectar();

                    MySqlDataReader result = mysql.ExecuteReader();
                    tabela.Load(result);
                    result.Close();
                }
                else if (MsForms.Equals("ATLEMPFORM"))
                {
                    MySqlCommand mysql = new MySqlCommand("MYSP_SELECIONAR_PESSOA_PR", this.Conexao.ObjetoConexao);
                    mysql.CommandType = CommandType.StoredProcedure;
                    mysql.Parameters.AddWithValue("_ID", id);
                    this.Conexao.Conectar();

                    MySqlDataReader result = mysql.ExecuteReader();
                    tabela.Load(result);
                    result.Close();
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

            return tabela;
        }

        public int ValidarPessoa(int id = 0)
        {
            int valor = 0;
            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_PESSOA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_IDPESSOA", id);
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader();

                if (result.Read())
                {
                    valor = Convert.ToInt32(result["FUNCAO"]);
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

            return valor;
        }

        public DataTable DtgrMDEmpresa()
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LISTAR_EMPRESA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader();
                tabela.Load(result);
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return tabela;
        }

        public DataTable LocalizarEmpresa(string razao = null)
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LISTAR_EMPRESA", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_RAZAO", razao);
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader();
                tabela.Load(result);
                result.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return tabela;
        }

        public EmpresaPaModelo ParametrosAtualizaEmpForm(string @razao, int @indice)
        {
            EmpresaPaModelo EmpPaMd = new EmpresaPaModelo();

            try
            {
                MySqlCommand myCm = new MySqlCommand("MYSP_PARAMETRO_FORM_EMPRESA", this.Conexao.ObjetoConexao);
                myCm.CommandType = CommandType.StoredProcedure;
                myCm.Parameters.AddWithValue("_RAZAO", @razao);
                this.Conexao.Conectar();

                MySqlDataReader dr = myCm.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();

                EmpPaMd.IDEnd = Convert.ToInt32(dr["IDEND"]);
                EmpPaMd.IDPessoa = Convert.ToInt32(dr["IDPSS"]);
                EmpPaMd.IDTelefone = Convert.ToInt32(dr["IDTEL"]);
                EmpPaMd.IDEmpresa = Convert.ToInt32(dr["IDEMP"]);
                EmpPaMd.Estado = Convert.ToInt32(dr["ESTADO"]);
                EmpPaMd.Cidade = Convert.ToString(dr["CIDADE"]);
                EmpPaMd.Bairro = Convert.ToString(dr["BAIRRO"]);
                EmpPaMd.Logradouro = Convert.ToString(dr["LOG"]);
                EmpPaMd.NumeroEnd = Convert.ToString(dr["NUM"]);
                EmpPaMd.Razao = Convert.ToString(dr["RAZAO"]);
                EmpPaMd.NumeroTel = Convert.ToString(dr["TEL"]);
                EmpPaMd.NumeroCel = Convert.ToString(dr["FAX"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
            }
            finally
            {
                if (Conexao.Equals(ConnectionState.Open))
                    this.Conexao.Desconectar();
            }

            return EmpPaMd;
        }
    }
}