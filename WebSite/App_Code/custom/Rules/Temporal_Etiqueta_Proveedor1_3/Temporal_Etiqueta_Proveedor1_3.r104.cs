using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

namespace eaton.Rules
{
    public partial class Temporal_Etiqueta_Proveedor1_3BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Procesar" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Temporal_Etiqueta_Proveedor1_3Model instance)
        {
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            bool resultadoProcesarEtiquetaUsuarioCooper;

            //GenerarEtiquetaDetalleProveedor
            resultadoProcesarEtiquetaUsuarioCooper = ProcesarTemporalEtiquetaProveedorUsuarioCooper(out mensajeSistema, out mensajeSistemaId);


            if (resultadoProcesarEtiquetaUsuarioCooper == false || (resultadoProcesarEtiquetaUsuarioCooper == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeSistema);
                Result.ShowMessage(mensajeSistema);
                Result.ShowAlert(mensajeSistema);
                Result.Refresh();
            }
            else
            {
                if (resultadoProcesarEtiquetaUsuarioCooper == true && mensajeSistemaId == 1)
                {
                    Result.ShowMessage(mensajeSistema);
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_3', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_2_1', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_1', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Etiqueta_Proveedor1_1', 'Controller').sync();");
                    Result.Continue();
                }
            }
        }
    }
}
