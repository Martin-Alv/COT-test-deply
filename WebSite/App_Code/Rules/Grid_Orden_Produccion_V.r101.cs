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
	public partial class Grid_Orden_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Cancelar_Solicitud" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r101")]
        // START public void r101Implementation(Grid_Orden_Produccion_VModel instance)
        public void r101Implementation(Grid_Orden_Produccion_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            Int32 tipoOperacionId = 1; // Actualizar
            
            Int64 ordenProduccionId = instance.Orden_Produccion_Id ?? 0;
            Int64 productoId = instance.Producto_Id ?? 0;
            Int32 estatusOrdenProduccionId = instance.Estatus_Orden_Produccion_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (ordenProduccionId == 0)
            {
                Result.ShowMessage("El identificador de Orden de Producción es obligatorio!");
            }
            else
            if (estatusOrdenProduccionId == 0)
            {
                Result.ShowMessage("Debe indicar el estatus de orden de producción!");
            }
            else
            {
                resultadoEjecucion = AdministrarOrdenProduccion(
                    tipoOperacionId
                    , ordenProduccionId
                    , productoId
                    , estatusOrdenProduccionId
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
                        Result.Continue();
                    }
                }
            }
        }
        // END public void r101Implementation(Grid_Orden_Produccion_VModel instance)
    }
}
