using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KMK_DAL.CONEXAO
{
    public class ConexaoDAL
    {
        //Parametros de Conexão com o Banco
        private String _stringConexao;
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        //Objeto de Conexão com o Banco
        private MySqlConnection _conexao;

        public MySqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        //Conexão com o Banco
        public ConexaoDAL(String dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        //Abrir Conexão
        public void Conectar()
        {
            if (this._conexao.State == ConnectionState.Closed)
                this._conexao.Open();
        }

        //Fechar Conexão
        public void Desconectar()
        {
            if (this._conexao.State == ConnectionState.Open)
                this._conexao.Close();
        }
    }
}
