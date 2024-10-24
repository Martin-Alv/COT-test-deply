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
    public partial class Handler_Carga_Material : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Procesar_Carga" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS03".
        /// </summary>
        [Rule("r107")]
        public void r107Implementation(Temporal_Carga_Masiva_Material1Model instance)
        {
            // This is the placeholder for method implementation.
            int mensajeSistemaId = 0;
            string mensajeSistema = "";
            bool resultadoProcesarTemporalMaterial;

            //GenerarTemporal_Carga_Masiva_Material
            resultadoProcesarTemporalMaterial = ProcesarMaterialTemporal(out mensajeSistema, out mensajeSistemaId);


            if (resultadoProcesarTemporalMaterial == false || (resultadoProcesarTemporalMaterial == true && mensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeSistema);
                Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material1', 'Controller').sync();");
                Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material2', 'Controller').sync();");
                Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material3', 'Controller').sync();");

                Result.ShowMessage(mensajeSistema);
                Result.ShowAlert(mensajeSistema);
                Result.Refresh();
            }
            else
            {
                if (resultadoProcesarTemporalMaterial == true && mensajeSistemaId == 1)
                {
                    Result.ShowMessage(mensajeSistema);
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material1', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material2', 'Controller').sync();");
                    Result.ExecuteOnClient("$appfactory.find('Temporal_Carga_Masiva_Material3', 'Controller').sync();");

                    Result.Continue();
                }
            }

        }
    }
}
