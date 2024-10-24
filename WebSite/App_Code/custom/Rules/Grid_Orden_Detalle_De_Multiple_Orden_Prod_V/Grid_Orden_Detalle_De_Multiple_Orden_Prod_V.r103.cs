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
	public partial class Grid_Orden_Detalle_De_Multiple_Orden_Prod_VBusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>
        /// Rule "Borrar_Orden_Produccion_Seleccion_Temporal" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r103")]
        //START public void r103Implementation(Grid_Orden_Detalle_De_Multiple_Orden_Prod_VModel instance)
        public void r103Implementation(Grid_Orden_Detalle_De_Multiple_Orden_Prod_VModel instance)
        {
            // This is the placeholder for method implementation.
            string SeleccionTemporalTransaccionId = instance.Seleccion_Temporal_Transaccion_Id.ToString() ?? "";

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (SeleccionTemporalTransaccionId == "")
            {
                Result.ShowMessage("El identificador (SeleccionTemporalTransaccionId) de la selección temporal es obligatorio!");
            }
            else { 

                resultadoEjecucion = BorrarOrdenProduccionSeleccionTemporal(
                    SeleccionTemporalTransaccionId
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
                        Result.ShowMessage(MensajeSistema);
                        //Result.Refresh(); // Refrescamos el grid                        
                        //Result.ExecuteOnClient("window.location.reload();");
                    }
                }
            }
        }
       // END public void r103Implementation(Grid_Orden_Detalle_De_Multiple_Orden_Prod_VModel instance)
    }
}
