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
    public partial class Handler_Ultima_Carga : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Procesar" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Report" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Temporal_Etiqueta_Proveedor1Model instance)
        {
            // This is the placeholder for method implementation.
            //int etiqueta_Proveedor_Id = instance.Etiqueta_Proveedor_Id ?? 0;

            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            bool resultadoProcesarEtiqueta;

            //GenerarEtiquetaDetalleProveedor
            resultadoProcesarEtiqueta = ProcesarEtiquetaMasivamente( out mensajeSistema, out mensajeSistemaId);


            if (resultadoProcesarEtiqueta == false || (resultadoProcesarEtiqueta == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeSistema);
                Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1', 'Controller').sync();");
                Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_1', 'Controller').sync();");
                Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_2', 'Controller').sync();");
                Result.ExecuteOnClient("$appfactory.find('Etiqueta_Proveedor1_1', 'Controller').sync();");
                Result.ShowMessage(mensajeSistema);
                Result.ShowAlert(mensajeSistema);
                Result.Refresh();
            }
            else
            {
                if (resultadoProcesarEtiqueta == true && mensajeSistemaId == 1)
                {
                    Result.ShowMessage(mensajeSistema);
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_1', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Etiqueta_Proveedor1_2', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Etiqueta_Proveedor1_1', 'Controller').sync();");
                    Result.Continue();
                }
            }
        }
    }
}
