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
	public partial class Grid_Mat_Incan_Pte_Por_Surtir_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Generar_Ruta_Optima" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Grid_Mat_Incan_Pte_Por_Surtir_VModel instance)
        {
            // This is the placeholder for method implementation.            
            // Declaración de variables
            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;
            string tmpRutaOptimaTransaccionId = instance.Tmp_Ruta_Optima_Transaccion_Id.ToString();

            // Generación de ruta óptima temporal
            resultadoEjecucion = GenerarRutaOptimaIncan(
                tmpRutaOptimaTransaccionId
                //---                
                , out MensajeSistema
                , out MensajeSistemaId
                , out ProcesoSistemaId
            );

            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                Result.ShowMessage(MensajeSistema);
            }
            else
            {
                if (resultadoEjecucion == true && MensajeSistemaId == 1)
                {
                    Result.ExecuteOnClient("window.location.replace('Grid_Ruta_Optima_Incan_A_Ejecutar_V?Tmp_Ruta_Optima_Transaccion_Id=" + tmpRutaOptimaTransaccionId + "')");
                }
            }// END else
        }
    }
}
