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
	public partial class Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Actualizar_Surtido" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables  
            int tipoOperacionId = 1;

            long materialId = instance.Material_Id ?? 0;
            decimal cantidadSolicitado = instance.Cantidad_Solicitado ?? 0;
            int unidadMaterialId = instance.Unidad_Material_Id ?? 0;
            int ubicacionAlmacenamientoId = instance.Ubicacion_Almacenamiento_Id ?? 0;
            long materialUbicacionStockId = instance.Material_Ubicacion_Stock_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;
            string tmpMaterialSurtidoTransaccionId = instance.Tmp_Material_Surtido_Transaccion_Id.ToString();

            // Generación de ruta óptima temporal
            resultadoEjecucion = AdministrarMaterialSurtido(
                tipoOperacionId
                , tmpMaterialSurtidoTransaccionId
                , materialId
                , cantidadSolicitado
                , ubicacionAlmacenamientoId
                , materialUbicacionStockId
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
                    //Result.ExecuteOnClient("window.location.replace('Ruta_Optima_A_Ejecutar_V?Creado_Por_Id=" + UserId + "&Transaccion_Id=" + RutaOptimaTransaccionId + "')");
                    Result.ShowMessage(MensajeSistema);
                }
            }// END else
        }
    }
}
