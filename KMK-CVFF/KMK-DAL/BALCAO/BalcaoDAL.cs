using KMK_DAL.CONEXAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using KMK_MODELO.BALCAO;

namespace KMK_DAL.BALCAO
{
    public class BalcaoDAL
    {

        static BalcaoLiModelo blcLiMd = new BalcaoLiModelo();

        private ConexaoDAL Conexao;


        public BalcaoDAL(ConexaoDAL cx)
        {
            this.Conexao = cx;
        }

        public BalcaoLiModelo ParametrosAtualizaCliForm(BalcaoPaModelo blcPaMd)
        {

            try
            {
                /*
                blcLiMd.IDEnd = Convert.ToInt32(selecionado["IDEND"]);
                blcLiMd.IDPessoa = Convert.ToInt32(selecionado["IDPSS"]);
                blcLiMd.IDTelefone = Convert.ToInt32(selecionado["IDTEL"]);
                blcLiMd.IDCliente = Convert.ToInt32(selecionado["IDCLI"]);
                blcLiMd.IDPrmcClint = Convert.ToInt32(selecionado["IDCLIPRO"]);
                blcLiMd.IDPromocao = Convert.ToInt32(selecionado["IDPROM"]);
                blcLiMd.Promocao = Convert.ToString(selecionado["PROMO"]);
                blcLiMd.Estado = Convert.ToInt32(selecionado["EST"]);
                blcLiMd.Cidade = Convert.ToString(selecionado["CIDADE"]);
                blcLiMd.Bairro = Convert.ToString(selecionado["BAIRRO"]);
                blcLiMd.Logradouro = Convert.ToString(selecionado["LOG"]);
                blcLiMd.NumeroEnd = Convert.ToString(selecionado["NUM"]);
                blcLiMd.Nome = Convert.ToString(selecionado["NOME"]);
                blcLiMd.Aniversario = Convert.ToDateTime(selecionado["NIVER"]);
                blcLiMd.NumeroTel = Convert.ToString(selecionado["TEL"]);
                blcLiMd.NumeroCel = Convert.ToString(selecionado["CEL"]);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve problemas. Erro: \n" + ex.Message);
            }
            finally
            {
                this.Conexao.Desconectar();
            }

            return blcLiMd;
        }
    }
}
