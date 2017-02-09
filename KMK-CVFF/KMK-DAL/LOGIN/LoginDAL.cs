using KMK_DAL.CONEXAO;
using KMK_MODELO.LOGIN;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_DAL.LOGIN
{
    public class LoginDAL
    {
        private ConexaoDAL Conexao;
        static LoginPaModelo lgPaMd = new LoginPaModelo();

        public LoginDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public LoginPaModelo ParametrosLogin(string @login = null, string @senha = null)
        {
            MySqlCommand myCm = new MySqlCommand("MYSP_VALIDAR_LOGIN", this.Conexao.ObjetoConexao);
            myCm.CommandType = CommandType.StoredProcedure;
            myCm.Parameters.AddWithValue("_LOGIN", @login);
            myCm.Parameters.AddWithValue("_SENHA", @senha);
            this.Conexao.Conectar();

            MySqlDataReader Result = myCm.ExecuteReader(CommandBehavior.CloseConnection);

            if (Result.Read())
            {
                LoginSecaoModelo.id_endereco = Convert.ToInt32(Result["IDEND"]);
                LoginSecaoModelo.id_pessoa = Convert.ToInt32(Result["IDPSS"]);
                LoginSecaoModelo.id_telefone = Convert.ToInt32(Result["IDTEL"]);
                LoginSecaoModelo.id_funcionario = Convert.ToInt32(Result["IDFUN"]);
                LoginSecaoModelo.id_empresa = Convert.ToInt32(Result["IDEMP"]);
                LoginSecaoModelo.login = Convert.ToString(Result["LOGIN"]);
                LoginSecaoModelo.senha = Convert.ToString(Result["SENHA"]);
                LoginSecaoModelo.funcao = Convert.ToInt32(Result["FUNCAO"]);
                lgPaMd.IDEndereco = Convert.ToInt32(Result["IDEND"]);
                lgPaMd.IDPessoa = Convert.ToInt32(Result["IDPSS"]);
                lgPaMd.IDTelefone = Convert.ToInt32(Result["IDTEL"]);
                lgPaMd.IDFuncionario = Convert.ToInt32(Result["IDFUN"]);
                lgPaMd.IDEmpresa = Convert.ToInt32(Result["IDEMP"]);
                lgPaMd.Login = Convert.ToString(Result["LOGIN"]);
                lgPaMd.Senha = Convert.ToString(Result["SENHA"]);
                lgPaMd.Funcao = Convert.ToInt32(Result["FUNCAO"]);
            }

            Result.Close();

            return lgPaMd;
        }

        public int ValidarAcesso(string @login = null, string @senha = null)
        {
            int funcao = 0;

            this.ParametrosLogin(@login, @senha);

            funcao = lgPaMd.Funcao;

            return funcao;
        }
    }
}
