using KMK_DAL.CONEXAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using KMK_MODELO.CLIENTE;

namespace KMK_DAL.CLIENTE
{
    public class ClienteDAL
    {
        static ClienteLiModelo cliLiMd = new ClienteLiModelo();

        private ConexaoDAL Conexao;


        public ClienteDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public bool IncluirCliente(ClienteInModelo CliInMd, string @form = null)
        {
            bool ret = false;
            string cod = null;
            ClienteCodigo ClCd = new ClienteCodigo();

            cod = ClCd.GerarCodigoCliente();
            CliInMd.Codigo = cod.ToUpper();

            while (this.LocalizarCodigoCliente(CliInMd.Codigo))
            {
                cod = ClCd.GerarCodigoCliente();
                CliInMd.Codigo = cod.ToUpper();
            }

            try
            {
                if (!ValidarCliente(CliInMd.Nome, @form))
                {
                    MySqlCommand cmd = new MySqlCommand("MYSP_INCLUIR_CLIENTE");
                    cmd.Connection = Conexao.ObjetoConexao;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_ESTADO", CliInMd.Estado);
                    cmd.Parameters.AddWithValue("_CIDADE", CliInMd.Cidade);
                    cmd.Parameters.AddWithValue("_BAIRRO", CliInMd.Bairro);
                    cmd.Parameters.AddWithValue("_LOGRADOURO", CliInMd.Logradouro);
                    cmd.Parameters.AddWithValue("_NUMERO", CliInMd.NumeroEnd);
                    cmd.Parameters.AddWithValue("_NOME", CliInMd.Nome);
                    cmd.Parameters.AddWithValue("_ANIVERSARIO", CliInMd.Aniversario);
                    cmd.Parameters.AddWithValue("_NUMEROTEL", CliInMd.NumeroTel);
                    cmd.Parameters.AddWithValue("_NUMEROCEL", CliInMd.NumeroCel);
                    cmd.Parameters.AddWithValue("_CODIGO", CliInMd.Codigo);

                    this.Conexao.Conectar();
                    cmd.ExecuteNonQuery();

                    if (ret = ValidarCliente(CliInMd.Nome, @form))
                        if (this.LocalizarCodigoCliente(CliInMd.Codigo))
                            MessageBox.Show("Cadastrado com sucesso! \n Codigo do Cliente (" + CliInMd.Codigo + ").");
                        else
                            MessageBox.Show("Codigo de cliente não localizado!");
                    else
                        MessageBox.Show("Falha ao efetuar o cadastro");
                }
                else
                {
                    MessageBox.Show("Cliente já Cadastrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return ret;
        }

        public bool AtualizarCliente(ClienteAtModelo CliAtMd)
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand("MYSP_ATUALIZAR_CLIENTE");
                cmd.Connection = Conexao.ObjetoConexao;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IDENDERECO", CliAtMd.IDEnd);
                cmd.Parameters.AddWithValue("_IDPESSOA", CliAtMd.IDPessoa);
                cmd.Parameters.AddWithValue("_IDTELEFONE", CliAtMd.IDTelefone);
                cmd.Parameters.AddWithValue("_IDCLIENTE", CliAtMd.IDCliente);
                cmd.Parameters.AddWithValue("_ESTADO", CliAtMd.Estado);
                cmd.Parameters.AddWithValue("_CIDADE", CliAtMd.Cidade);
                cmd.Parameters.AddWithValue("_BAIRRO", CliAtMd.Bairro);
                cmd.Parameters.AddWithValue("_LOGRADOURO", CliAtMd.Logradouro);
                cmd.Parameters.AddWithValue("_NUMERO", CliAtMd.NumeroEnd);
                cmd.Parameters.AddWithValue("_NOME", CliAtMd.Nome);
                cmd.Parameters.AddWithValue("_ANIVERSARIO", CliAtMd.Aniversario);
                cmd.Parameters.AddWithValue("_NUMEROTEL", CliAtMd.NumeroTel);
                cmd.Parameters.AddWithValue("_NUMEROCEL", CliAtMd.NumeroCel);
                this.Conexao.Conectar();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Atualizado com sucesso!");

                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
                ret = true;
            }

            return ret;
        }

        public bool ValidarCliente(string @nome = null, string @form = null)
        {
            bool ret = false;

            this.LocalizarCliente(@nome, @form);

            if (cliLiMd.IDCliente > 0)
                ret = true;

            return ret;
        }

        public DataTable ListarPessoa()
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlCommand mysql = new MySqlCommand("MYVW_LISTAR_PESSOA SELECT * FROM kmk_cfe.MYVW_LISTAR_CLIENTE;", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
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

        public DataTable DtgrMDCliente()
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlCommand mysql = new MySqlCommand("SELECT * FROM MYVW_LISTAR_CLIENTE", this.Conexao.ObjetoConexao);
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

        public bool LocalizarCodigoCliente(string @cod = null)
        {
            bool ret = false;
            string valor = null;

            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_CODIGO_CLIENTE", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_CODIGO", @cod);
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader(CommandBehavior.CloseConnection);

                while (result.Read())
                {
                    valor = Convert.ToString(result["codigo"]);

                    if (valor != null)
                        ret = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return ret;
        }

        public DataTable LocalizarCliente(string @nome = null, string @form = null)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlCommand mysql = new MySqlCommand("MYSP_LOCALIZAR_CLIENTE", this.Conexao.ObjetoConexao);
                mysql.CommandType = CommandType.StoredProcedure;
                mysql.Parameters.AddWithValue("_NOME", @nome);
                this.Conexao.Conectar();

                MySqlDataReader result = mysql.ExecuteReader(CommandBehavior.CloseConnection);
                //result.Read();

                if (@form == "CADASTRO")
                {
                    while (result.Read())
                    {
                        cliLiMd.IDCliente = Convert.ToInt32(result["IDCLI"].ToString());
                    }

                    tabela.Load(result);
                    //result.Close();
                }
                else
                {
                    tabela.Load(result);
                    result.Close();
                }

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

        public ClientePaModelo ParametrosAtualizaCliForm(string @nome = null)
        {
            ClientePaModelo CliPaMd = new ClientePaModelo();

            try
            {
                MySqlCommand myCm = new MySqlCommand("MYSP_PARAMETRO_FORM_CLIENTE", this.Conexao.ObjetoConexao);
                myCm.CommandType = CommandType.StoredProcedure;
                myCm.Parameters.AddWithValue("_NOME", @nome);
                this.Conexao.Conectar();

                MySqlDataReader selecionado = myCm.ExecuteReader(CommandBehavior.CloseConnection);
                selecionado.Read();

                CliPaMd.IDEnd = Convert.ToInt32(selecionado["IDEND"]);
                CliPaMd.IDPessoa = Convert.ToInt32(selecionado["IDPSS"]);
                CliPaMd.IDTelefone = Convert.ToInt32(selecionado["IDTEL"]);
                CliPaMd.IDCliente = Convert.ToInt32(selecionado["IDCLI"]);
                CliPaMd.IDPrmcClint = Convert.ToInt32(selecionado["IDCLIPRO"]);
                CliPaMd.IDPromocao = Convert.ToInt32(selecionado["IDPROM"]);
                CliPaMd.Promocao = Convert.ToString(selecionado["PROMO"]);
                CliPaMd.Estado = Convert.ToInt32(selecionado["EST"]);
                CliPaMd.Cidade = Convert.ToString(selecionado["CIDADE"]);
                CliPaMd.Bairro = Convert.ToString(selecionado["BAIRRO"]);
                CliPaMd.Logradouro = Convert.ToString(selecionado["LOG"]);
                CliPaMd.NumeroEnd = Convert.ToString(selecionado["NUM"]);
                CliPaMd.Nome = Convert.ToString(selecionado["NOME"]);
                CliPaMd.Aniversario = Convert.ToDateTime(selecionado["NIVER"]);
                CliPaMd.NumeroTel = Convert.ToString(selecionado["TEL"]);
                CliPaMd.NumeroCel = Convert.ToString(selecionado["CEL"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return CliPaMd;
        }
    }
}
