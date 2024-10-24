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
	public partial class Solicitud1BusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Iniciar_Surtido" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Solicitud1Model instance)
        {
            // This is the placeholder for method implementation.

            // Declaración de variables
            int TipoOperacionId = 1; // Creación de solicitud
            Int64 OrdenProduccionId = instance.Orden_Produccion_Id ?? 0;
            Int64 OrdenProduccionDetalleId = 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            resultadoEjecucion = AdministrarSolicitudMaterial(
                TipoOperacionId
                , OrdenProduccionId
                , OrdenProduccionDetalleId
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
                    Result.ExecuteOnClient("window.location.reload();");
                }
            }
        }// END public void r100Implementation(Solicitud1Model instance)
    }
}
