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
	public partial class Orden_ProduccionBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Generar_Orden_Produccion_Detalle" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(Orden_ProduccionModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            //int TipoOperacionId = 1; // Creación de solicitud
            Int64 OrdenProduccionId = instance.Orden_Produccion_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            resultadoEjecucion = GenerarOrdenProduccionDetalle(
                //TipoOperacionId,
                OrdenProduccionId,
                //---                
                out MensajeSistema,
                out MensajeSistemaId,
                out ProcesoSistemaId
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
                    //Result.ExecuteOnClient("window.location.reload();");
                    Result.Refresh();
                }
            }
        }// END public void r101Implementation(Orden_ProduccionModel instance)
    }
}
