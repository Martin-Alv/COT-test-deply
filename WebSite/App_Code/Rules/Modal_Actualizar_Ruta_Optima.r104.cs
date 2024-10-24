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
	public partial class Modal_Actualizar_Ruta_OptimaBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Actualizar_Surtido" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Modal_Actualizar_Ruta_OptimaModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            // Variables de operacion
         /*   Int64 RutaOptimaId = instance.Ruta_Optima_Id ?? 0;
            Int64 OrdenProduccionId = instance.Orden_Produccion_Id ?? 0;
            Int64 SolicitudId = instance.Solicitud_Id ?? 0;
            decimal CantidadEntregado = instance.Cantidad_Entregado ?? 0;
            int UnidadMaterialEntregadoId = instance.Unidad_Material_Entregado_Id ?? 0;

            // Variables de ejecucion
            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            resultadoEjecucion = ActualizarSurtido(
                RutaOptimaId
                ,OrdenProduccionId
                ,SolicitudId
                ,CantidadEntregado
                ,UnidadMaterialEntregadoId
                //
                ,out MensajeSistema
                ,out MensajeSistemaId
                ,out ProcesoSistemaId
            );
            // Si no se ejecuta, mostramos el error
            if (!resultadoEjecucion)
            {
                Result.ShowMessage(MensajeSistema);
            }
            // Si no, la ejecucion falló ó se ejecuta pero no exitosamente
            else
            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {
                // Registramos en bitacora
                RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                //Mostramos el mensaje de error
                Result.ShowMessage(MensajeSistema);
            }
            else
            {
                Result.ShowMessage(MensajeSistema);
            }
            // Refrescamos grid
            Result.ExecuteOnClient("$app.touch.dataView().sync();");
            */
        }// END public void r104Implementation(Modal_Actualizar_Ruta_OptimaModel instance)
    }// END public partial class Modal_Actualizar_Ruta_OptimaBusinessRules : eaton.Rules.SharedBusinessRules
}// END namespace
