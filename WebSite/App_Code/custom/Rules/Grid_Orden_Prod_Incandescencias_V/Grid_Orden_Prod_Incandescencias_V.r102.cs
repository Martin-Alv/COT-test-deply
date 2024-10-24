using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

using System.Messaging.Design;

namespace eaton.Rules
{
	public partial class Grid_Orden_Prod_Incandescencias_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "GenerarSolicUltimaCargaMat" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r102")]
        //START public void r102Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
        public void r102Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
        {
            // This is the placeholder for method implementation.
            int Tipo_Operacion_Id = 4;  /*
							 1: Generar Solicitud y validar material en relacion Producto_Material
							 2: Generar Solicitud
							 3: Procesar Producto Material
							 4: Generar solicitudes de materiales en relación Producto Material
							*/
            long Orden_Produccion_Id = instance.Orden_Produccion_Id ?? 0;
            long Orden_Produccion_Detalle_Id = 0;
            int Producto_Id = instance.Producto_Id ?? 0;
            long Material_Id = 0;
            decimal Cantidad_A_Solicitar = 0;
            int Area_Entrega_Id = 0;
            string Transaccion_Tmp_Id = null;

            bool resultadoGenerarSolicitMat;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            // Generación de mov ruta óptima temporal
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
            /*else
                if (resultadoGenerarSolicitMat == true && MensajeSistemaId == 100) {
               // Result.ExecuteOnClient("$app.confirm('Prueba','ExecCS02','Result.Refresh');");
                //Result.ExecuteOnClient("if(confirm('Editing Beverages. Are you sure ? '))this._continueAfterScript=true;");

                //Result.ExecuteOnClient("if($app.confirm('Editing Beverages. Are you sure ? '))this._continueAfterScript=true;");
            }*/
            else
            {
                if (resultadoGenerarSolicitMat == true && MensajeSistemaId == 1)
                {
                    Result.ShowMessage(MensajeSistema);
                    Result.Refresh();
                    
                }
            }// END else
        }
        //END public void r102Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
    }
}
