using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KMK_DAL.CONEXAO;
using KMK_MODELO.FUNCIONARIO;
using System.Data;
using System.Windows.Forms;

namespace KMK_DAL.FUNCIONARIO
{
    public class FuncionarioDAL
    {
        private ConexaoDAL Conexao;
        static int @id_funcionario = 0;


        public FuncionarioDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirFuncionario(FuncionarioInModelo fcInMd)
        {
            bool ret = false;
            try
            {
                if (!LocalizarFuncionario(fcInMd.Aniversario, fcInMd.Nome, fcInMd.NumeroCel))
                {
                    if (fcInMd.ConSenha == fcInMd.Senha)
                    {
                        MySqlCommand mysqlFun = new MySqlCommand("MYSP_INCLUIR_FUNCIONARIO");
                        mysqlFun.Connection = Conexao.ObjetoConexao;
                        mysqlFun.CommandType = CommandType.StoredProcedure;
                        mysqlFun.Parameters.AddWithValue("_ESTADO", fcInMd.Estado);
                        mysqlFun.Parameters.AddWithValue("_CIDADE", fcInMd.Cidade);
                        mysqlFun.Parameters.AddWithValue("_BAIRRO", fcInMd.Bairro);
                        mysqlFun.Parameters.AddWithValue("_LOGRADOURO", fcInMd.Logradouro);
                        mysqlFun.Parameters.AddWithValue("_NUMERO", fcInMd.NumeroEnd);
                        mysqlFun.Parameters.AddWithValue("_COMPLEMENTO", fcInMd.Complemento);
                        mysqlFun.Parameters.AddWithValue("_NOME", fcInMd.Nome);
                        mysqlFun.Parameters.AddWithValue("_ANIVERSARIO", fcInMd.Aniversario);
                        mysqlFun.Parameters.AddWithValue("_NUMEROTEL", fcInMd.NumeroTel);
                        mysqlFun.Parameters.AddWithValue("_NUMEROCEL", fcInMd.NumeroCel);
                        mysqlFun.Parameters.AddWithValue("_LOGIN", fcInMd.Login);
                        mysqlFun.Parameters.AddWithValue("_SENHA", fcInMd.Senha);
                        mysqlFun.Parameters.AddWithValue("_FUNCAO", fcInMd.Funcao);
                        this.Conexao.Conectar();
                        mysqlFun.ExecuteNonQuery();

                        if (ret = LocalizarFuncionario(fcInMd.Aniversario, fcInMd.Nome, fcInMd.NumeroCel))
                        {
                            if (@id_funcionario != 0)
                            {
                                if (this.IncluirAtualizarFunEmpr(fcInMd.IDFuncEmp, @id_funcionario, fcInMd.IDEmpresa))
                                    MessageBox.Show("Funcionário, " + fcInMd.Nome + "(" + fcInMd.Razao + ")" + " cadastrado com sucesso!");
                                else
                                    MessageBox.Show("Erro ao Vincular Funcionario a Empresa!");
                            }
                            else
                            {
                                MessageBox.Show("Funcionário " + fcInMd.Nome + " cadastrado com sucesso!");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("O campo [Confirma senha] tem que ser igual ao campo [Senha]!");
                    }
                }
                else
                {
                    MessageBox.Show("Funcionário " + fcInMd.Nome + " já cadastrado!");

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

        public bool AtualizarFuncionario(FuncionarioAtModelo fcAtMd)
        {
            bool ret = false;

            try
            {
                MySqlCommand mysqlFun = new MySqlCommand("MYSP_ATUALIZAR_FUNCIONARIO");
                mysqlFun.Connection = Conexao.ObjetoConexao;
                mysqlFun.CommandType = CommandType.StoredProcedure;
                mysqlFun.Parameters.AddWithValue("_IDENDERECO", fcAtMd.IDEnd);
                mysqlFun.Parameters.AddWithValue("_IDPESSOA", fcAtMd.IDPessoa);
                mysqlFun.Parameters.AddWithValue("_IDTELEFONE", fcAtMd.IDTelefone);
                mysqlFun.Parameters.AddWithValue("_IDFUNCIONARIO", fcAtMd.IDFuncionario);
                mysqlFun.Parameters.AddWithValue("_ESTADO", fcAtMd.Estado);
                mysqlFun.Parameters.AddWithValue("_CIDADE", fcAtMd.Cidade);
                mysqlFun.Parameters.AddWithValue("_BAIRRO", fcAtMd.Bairro);
                mysqlFun.Parameters.AddWithValue("_LOGRADOURO", fcAtMd.Logradouro);
                mysqlFun.Parameters.AddWithValue("_NUMERO", fcAtMd.NumeroEnd);
                mysqlFun.Parameters.AddWithValue("_NOME", fcAtMd.Nome);
                mysqlFun.Parameters.AddWithValue("_ANIVERSARIO", fcAtMd.Aniversario);
                mysqlFun.Parameters.AddWithValue("_NUMEROTEL", fcAtMd.NumeroTel);
                mysqlFun.Parameters.AddWithValue("_NUMEROCEL", fcAtMd.NumeroCel);
                mysqlFun.Parameters.AddWithValue("_LOGIN", fcAtMd.Login);
                mysqlFun.Parameters.AddWithValue("_SENHA", fcAtMd.Senha);
                mysqlFun.Parameters.AddWithValue("_FUNCAO", fcAtMd.Funcao);
                this.Conexao.Conectar();
                mysqlFun.ExecuteNonQuery();

                if (fcAtMd.IDEmpresa > 0)
                {
                    if (this.IncluirAtualizarFunEmpr(fcAtMd.IDFuncEmp, fcAtMd.IDFuncionario, fcAtMd.IDEmpresa))
                        MessageBox.Show("Atualizado com sucesso! (" + fcAtMd.Razao + ") ");
                    else
                        MessageBox.Show("Erro ao Vincular Funcionario a Empresa!");
                }
                else
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }


                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
                ret = true;
            }
            finally
            {
                this.Conexao.Desconectar();
            }
            return ret;
        }

        public bool IncluirAtualizarFunEmpr(int @idFunEmp = 0, int @idFuncionario = 0, int @idEmpresa = 0)
        {
            bool ret = false;

            if (@idFunEmp > 0)
            {
                try
                {
                    MySqlCommand mysqlEmpFun = new MySqlCommand("MYSP_ATUALIZAR_FUNCIONARIO_EMPRESA");
                    mysqlEmpFun.Connection = Conexao.ObjetoConexao;
                    mysqlEmpFun.CommandType = CommandType.StoredProcedure;
                    mysqlEmpFun.Parameters.AddWithValue("IDFUNEMP", @idFunEmp);
                    mysqlEmpFun.Parameters.AddWithValue("_IDFUNCIONARIO", @idFuncionario);
                    mysqlEmpFun.Parameters.AddWithValue("_IDEMPRESA", @idEmpresa);
                    this.Conexao.Conectar();
                    mysqlEmpFun.ExecuteNonQuery();

                    @idFunEmp = 0;

                    @idFunEmp = LocalizarFuncionarioEmpresa(@idFuncionario, @idEmpresa);
                    if (@idFunEmp > 0)
                        ret = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
                }
                finally
                {
                    this.Conexao.Desconectar();
                }

            }
            else
            {
                try
                {
                    MySqlCommand mysqlEmpFun = new MySqlCommand("MYSP_INCLUIR_FUNCIONARIO_EMPRESA");
                    mysqlEmpFun.Connection = Conexao.ObjetoConexao;
                    mysqlEmpFun.CommandType = CommandType.StoredProcedure;
                    mysqlEmpFun.Parameters.AddWithValue("_IDFUNCIONARIO", @idFuncionario);
                    mysqlEmpFun.Parameters.AddWithValue("_IDEMPRESA", @idEmpresa);
                    this.Conexao.Conectar();
                    mysqlEmpFun.ExecuteNonQuery();

                    @idFunEmp = LocalizarFuncionarioEmpresa(@idFuncionario, @idEmpresa);

                    if (@idFunEmp > 0)
                        ret = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
                }
                finally
                {
                    this.Conexao.Desconectar();
                }

            }

            return ret;
        }

        public void ExcluirFuncionario(FuncionarioInModelo fcMD)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("MYSP_EXCLUIR_FUNCIONARIO");
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IDFUNCIONARIO", fcMD.IDFuncionario);
                this.Conexao.Conectar();
                cmd.ExecuteNonQuery();
                this.Conexao.Desconectar();
            }
            catch (Exception error)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + error.Message);
            }
        }

        public bool LocalizarFuncionario(DateTime @aniversario, string @nome = null, string @cel = null)
        {
            bool ret = false;

            try
            {
                MySqlCommand myCm = new MySqlCommand("MYSP_LOCALIZAR_FUNCIONARIOS", this.Conexao.ObjetoConexao);
                myCm.CommandType = CommandType.StoredProcedure;
                myCm.Parameters.AddWithValue("_ANIVERSARIO", @aniversario);
                myCm.Parameters.AddWithValue("_NOME", @nome);
                myCm.Parameters.AddWithValue("_CEL", @cel);
                this.Conexao.Conectar();

                MySqlDataReader result = myCm.ExecuteReader(CommandBehavior.CloseConnection);

                while (result.Read())
                {
                    @id_funcionario = 0;

                    @id_funcionario = Convert.ToInt32(result["ID"]);
                }

                result.Close();

                if (@id_funcionario != 0)
                    ret = true;
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

        public int LocalizarFuncionarioEmpresa(int @idFuncionario = 0, int idEmpresa = 0)
        {
            int id = 0;

            try
            {
                MySqlCommand myCm = new MySqlCommand("MYSP_LOCALIZAR_FUNCIONARIOS_EMPRESA", this.Conexao.ObjetoConexao);
                myCm.CommandType = CommandType.StoredProcedure;
                myCm.Parameters.AddWithValue("_IDFUNCIONARIO", @idFuncionario);
                myCm.Parameters.AddWithValue("_IDEMPRESA", idEmpresa);
                this.Conexao.Conectar();

                MySqlDataReader result = myCm.ExecuteReader(CommandBehavior.CloseConnection);

                while (result.Read())
                {
                    id = Convert.ToInt32(result["ID"]);
                }

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

            return id;
        }

        public DataTable DtgrMDCadFuncionario()
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlCommand mysql = new MySqlCommand("SELECT * FROM MYVW_DTGR_FUNCIONARIO;", this.Conexao.ObjetoConexao);
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

        public FuncionarioPaModelo ParametrosAtualizaFunForm(string @login, string @nome, int @indice)
        {
            FuncionarioPaModelo fcPaMd = new FuncionarioPaModelo();

            try
            {
                MySqlCommand myCm = new MySqlCommand("MYSP_PARAMETRO_FORM_FUNCIONARIOS", this.Conexao.ObjetoConexao);
                myCm.CommandType = CommandType.StoredProcedure;
                myCm.Parameters.AddWithValue("_LOGIN", @login);
                myCm.Parameters.AddWithValue("_NOME", @nome);
                this.Conexao.Conectar();

                MySqlDataReader dr = myCm.ExecuteReader(CommandBehavior.CloseConnection);
                dr.Read();

                fcPaMd.IDEnd = Convert.ToInt32(dr["IDEND"]);
                fcPaMd.IDPessoa = Convert.ToInt32(dr["IDPSS"]);
                fcPaMd.IDTelefone = Convert.ToInt32(dr["IDTEL"]);
                fcPaMd.IDFuncionario = Convert.ToInt32(dr["IDFUN"]);
                fcPaMd.IDFuncEmp = Convert.ToInt32(dr["ID"]);
                fcPaMd.IDEmpresa = Convert.ToInt32(dr["IDEMP"]);
                fcPaMd.Razao = Convert.ToString(dr["RAZAO"]);
                fcPaMd.Estado = Convert.ToInt32(dr["EST"]);
                fcPaMd.Cidade = Convert.ToString(dr["CIDADE"]);
                fcPaMd.Bairro = Convert.ToString(dr["BAIRRO"]);
                fcPaMd.Logradouro = Convert.ToString(dr["LOG"]);
                fcPaMd.NumeroEnd = Convert.ToString(dr["NUM"]);
                fcPaMd.Nome = Convert.ToString(dr["NOME"]);
                fcPaMd.Aniversario = Convert.ToDateTime(dr["NIVER"]);
                fcPaMd.NumeroTel = Convert.ToString(dr["TEL"]);
                fcPaMd.NumeroCel = Convert.ToString(dr["CEL"]);
                fcPaMd.Login = Convert.ToString(dr["LOGIN"]);
                fcPaMd.Senha = Convert.ToString(dr["SENHA"]);
                fcPaMd.Funcao = Convert.ToInt32(dr["FUNCAO"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n\n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return fcPaMd;
        }

        public DataTable ComboBoxEmpresa(string @form = null, string @razao = null)
        {
            DataTable tabela = new DataTable();
            try
            {
                if (@form == "CadFun")
                {
                    MySqlCommand mysql = new MySqlCommand("SELECT * FROM MYVW_DTGR_EMPRESA", this.Conexao.ObjetoConexao);
                    this.Conexao.Conectar();

                    MySqlDataReader result = mysql.ExecuteReader();
                    tabela.Load(result);
                    result.Close();
                }
                else
                {
                    MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_EMPRESA", this.Conexao.ObjetoConexao);
                    mysql.CommandType = CommandType.StoredProcedure;
                    mysql.Parameters.AddWithValue("_RAZAO", @razao);
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

    }
}
