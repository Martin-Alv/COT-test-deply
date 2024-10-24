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
	public partial class Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Crear_Solicitud_Material_De_Mat_Agrupado" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VModel instance)
        {
            // This is the placeholder for method implementation.
            // This is the placeholder for method implementation.                      
            int Tipo_Operacion_Id = 1;  /*
							 1: Generar Solicitud y validar material en relacion Producto_Material
							 2: Generar Solicitud
							 3: Procesar Producto Material
							 4: Generar solicitudes de materiales en relación Producto Material
							*/
            long Orden_Produccion_Id = 0;// instance.Material_Orden_Produccion ?? 0;
            long Orden_Produccion_Detalle_Id = 0;// instance.Orden_Produccion_Detalle_Id ?? 0;
            int Producto_Id = 0;// instance.Producto_Id ?? 0;
            long Material_Id = instance.Material_Id ?? 0;
            decimal Cantidad_A_Solicitar = instance.Cantidad_Mat_A_Solicitar ?? 0;
            int Area_Entrega_Id = instance.Area_Entrega_Id ?? 0;
            string Transaccion_Tmp_Id = null;

            bool resultadoGenerarSolicitMat;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (Orden_Produccion_Id == 0)
            {
                Result.ShowMessage("El identificador de Orden Producción es obligatorio!");
            }
            else
               if (Material_Id == 0)
            {
                Result.ShowMessage("El identificador de Material es obligatorio!");
            }
            else
              if (Cantidad_A_Solicitar == 0)
            {
                Result.ShowMessage("La cant. de material a solicitar debe ser mayor a cero!");
            }
            else
            {
                resultadoGenerarSolicitMat = GenerarSolicitudMatPickeo(
                    Tipo_Operacion_Id
                    , Orden_Produccion_Id
                    , Producto_Id
                    , Orden_Produccion_Detalle_Id
                    , Material_Id
                    , Cantidad_A_Solicitar
                    , Area_Entrega_Id
                    , Transaccion_Tmp_Id
                    //---                
                    , out MensajeSistema
                    , out MensajeSistemaId
                );

                if (resultadoGenerarSolicitMat == false || (resultadoGenerarSolicitMat == true && MensajeSistemaId != 1))
                {
                    RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                    Result.ShowMessage(MensajeSistema);
                    //Agregamos el error al arreglo
                    Result.Errors.Add(MensajeSistema);
                }
                else
                {
                    if (resultadoGenerarSolicitMat == true && MensajeSistemaId == 1)
                    {
                        Result.ShowMessage(MensajeSistema);
                        //Result.Continue();
                        //Result.ExecuteOnClient("window.location.reload();");
                    }
                }// END else
            }
        }
    }
}
