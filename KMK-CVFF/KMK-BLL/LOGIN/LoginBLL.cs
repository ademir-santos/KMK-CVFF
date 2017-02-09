using KMK_DAL.CONEXAO;
using KMK_DAL.LOGIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMK_BLL.LOGIN
{
    public class LoginBLL
    {
        private ConexaoDAL Conexao;

        public LoginBLL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public int ValidarAcesso(string @login = null, string @senha = null)
        {
            int funcao = 0;

            LoginDAL lgDAL = new LoginDAL(this.Conexao);

            funcao = lgDAL.ValidarAcesso(@login, @senha);

            return funcao;
        }
    }
}
