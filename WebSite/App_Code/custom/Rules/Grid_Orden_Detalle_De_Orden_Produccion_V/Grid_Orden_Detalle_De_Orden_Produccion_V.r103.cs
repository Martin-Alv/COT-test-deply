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
        /// Rule "Crear_Solicitud_Material" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r103")]
        //  START public void r103Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
        public void r103Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            int TipoOperacionId = 1; //solicitud normal
            long OrdenProduccionId = instance.Orden_Produccion_Id ?? 0;
            long OrdenProduccionDetalleId = instance.Orden_Produccion_Detalle_Id ?? 0;
            int ProductoId = instance.Producto_Id ?? 0;
            long MaterialASolicitarId = instance.Material_Id ?? 0;
            decimal CantMatASolicitar = instance.Cantidad_Mat_A_Solicitar ?? 0;
            decimal CantMatRestantePorSolicitar = instance.Cantidad_Mat_Restante_Por_Solicitar ?? 0;
            int AreaEntregaId = instance.Area_Entrega_Id ?? 0;
            int AreaServicioId = instance.Area_Servicio_Id ?? 0;
            int FamiliaId = instance.Familia_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (OrdenProduccionId == 0)
            {
                Result.ShowMessage("El identificador de Orden Producción es obligatorio!");
            }
            else
                if (MaterialASolicitarId == 0)
            {
                Result.ShowMessage("El identificador de Material es obligatorio!");
            }
            else
               if (CantMatASolicitar == 0)
            {
                Result.ShowMessage("La cant. de material a solicitar debe ser mayor a cero!");
            }
            else
            {
                resultadoEjecucion = GenerarSolicitudMaterial(
                    TipoOperacionId
                    ,OrdenProduccionId
                    ,OrdenProduccionDetalleId
                    ,ProductoId
                    ,MaterialASolicitarId
                    ,CantMatASolicitar
                    ,CantMatRestantePorSolicitar
                    ,AreaEntregaId
                    ,AreaServicioId
                    ,FamiliaId
                    , 10 //Solicitud creado desde materiales de una orden.
                    //---                
                    , out MensajeSistema
                    ,out MensajeSistemaId
                    ,out ProcesoSistemaId
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
                        Result.ExecuteOnClient("window.location.reload();");
                    }
                }
            }
        }
        // END public void r103Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
    }
}
