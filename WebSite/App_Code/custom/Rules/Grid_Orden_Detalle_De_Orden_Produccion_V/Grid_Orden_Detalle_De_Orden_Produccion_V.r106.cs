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
	public partial class Grid_Orden_Detalle_De_Orden_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Administrar_Orden_Prod_Det_Actualizar" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r106")]
        // START public void r106Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
        public void r106Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
           /* int TipoOperacionId = 1; // Administrar Orden Prod Detalle: Actualizar
            Int64 OrdenProduccionDetalleId = instance.Orden_Produccion_Detalle_Id ?? 0;
            decimal CantMatASolicitar = instance.Cantidad_Mat_A_Solicitar ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (OrdenProduccionDetalleId == 0)
            {
                Result.ShowMessage("El identificador de Orden Producción Detalle es obligatorio!");
            }
            else
                if (CantMatASolicitar == 0)
            {
                Result.ShowMessage("Ingrese cantidad a solicitar");
            }
            else
            {
                resultadoEjecucion = AdministrarOrdenProduccionDetalle(
                    TipoOperacionId
                    , OrdenProduccionDetalleId
                    , CantMatASolicitar
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
                        Result.Refresh(); // Refrescamos el grid
                    }
                }
            }*/
        }
        // END public void r106Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
    }
}
