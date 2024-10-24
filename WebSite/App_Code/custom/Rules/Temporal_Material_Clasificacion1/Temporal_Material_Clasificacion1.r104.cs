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
    public partial class Temporal_Material_Clasificacion1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Procesar" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Temporal_Material_Clasificacion1Model instance)
        {
            // This is the placeholder for method implementation.
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            bool resultadoProcesarMaterialClasificado;

            //GenerarEtiquetaDetalleProveedor
            resultadoProcesarMaterialClasificado = ProcesarMaterialClasificacion(out mensajeSistema, out mensajeSistemaId);


            if (resultadoProcesarMaterialClasificado == false || (resultadoProcesarMaterialClasificado == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeSistema);
                Result.ExecuteOnClient("$appfactory.find('Temporal_Material_Clasificacion1', 'Controller').sync();");

                Result.ShowMessage(mensajeSistema);
                Result.ShowAlert(mensajeSistema);
                Result.Refresh();
            }
            else
            {
                if (resultadoProcesarMaterialClasificado == true && mensajeSistemaId == 1)
                {
                    Result.ShowMessage(mensajeSistema);
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Material_Clasificacion1', 'Controller').sync();");

                    Result.Continue();
                }
            }
        }
    }
}
