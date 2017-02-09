using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMK_GUI.VIEWS;
using KMK_GUI.VIEWS.SUB_FORMS.FUNCIONARIO;
using KMK_GUI.VIEWS.SUB_FORMS.EMPRESA;
using KMK_GUI.VIEWS.SUB_FORMS.CLIENTE;
using KMK_GUI.VIEWS.SUB_FORMS.PRODUTO;
//using KMK_GUI.VIEW.SUB_FORMS.BALCAO;
using KMK_GUI.VIEWS.SUB_FORMS.FORM_PADRAO;


namespace KMK_GUI
{
    public class MeusFormularios
    {
        /* <PRINCIPAIS> */
        public static LoginForm LGNForm { get; set; }
        public static DeliveryForm DLVForm { get; set; }
        public static BalcaoForm BLCForm { get; set; }
        public static PadroesSistemaForm PDSSForm { get; set; }
        /* </PRINCIPAIS> */

        /* <SUB MENUS> */
        public static AtualizarFuncionarioForm ATFNForm { get; set; }
        public static AtualizarEmpresaForm ATEMPForm { get; set; }
        public static AtualizarClienteForm ATCLIForm { get; set; }
        public static SubCategoriaProdutoForm SBCATPROForm { get; set; }
       
        //public static OpcaoModeloForm OPCMDForm { get; set; }
        /* </SUB MENUS> */
    }
}
