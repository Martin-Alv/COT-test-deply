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
	public partial class Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Administrar_Orden_Prod_Det_Actualizar" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            int TipoOperacionId = 1; // Administrar Orden Prod Detalle: Actualizar
            long MaterialAgrupadoDeMultipleOrdenProduccionId = instance.Material_Agrupado_De_Multiple_Orden_Produccion_Id ?? 0;
            string MaterialAgrupadoDeMultipleOrdenProduccionTransaccionId = Convert.ToString(instance.Seleccion_Temporal_Transaccion_Id);
            long MaterialId = instance.Material_Id ?? 0;
            decimal CantMatASolicitar = instance.Cantidad_Mat_A_Solicitar ?? 0;
            int AreaEntregaId = instance.Area_Entrega_Id ?? 0;

            string MaterialOrdenProduccion = instance.Material_Orden_Produccion;
            string MaterialProducto = instance.Material_Producto;
            string MaterialOrdenProduccionDetalle = instance.Material_Orden_Produccion_Detalle;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (MaterialId == 0)
            {
                Result.ShowMessage("El identificador de Material es obligatorio!");
            }
            else
                if (CantMatASolicitar == 0)
            {
                Result.ShowMessage("Ingrese cantidad a solicitar");
            }
            // START else
            else
            {
                resultadoEjecucion = AdministrarMaterialAgrupadoDeMultipleOrdenProduccion(
                    TipoOperacionId
                    , MaterialAgrupadoDeMultipleOrdenProduccionId
                    ,MaterialAgrupadoDeMultipleOrdenProduccionTransaccionId
                    ,MaterialId
                    , CantMatASolicitar
                    ,MaterialOrdenProduccion
                    ,MaterialProducto
                    ,MaterialOrdenProduccionDetalle 
                    ,AreaEntregaId                  
                    //---                
                    , out MensajeSistema
                    , out MensajeSistemaId
                    , out ProcesoSistemaId
                );

                // START if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                {
                    RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                    Result.ShowMessage(MensajeSistema);
                }
                // END if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                else
                {
                    if (resultadoEjecucion == true && MensajeSistemaId == 1)
                    {
                        Result.ShowMessage(MensajeSistema);                        
                    }

                }
            }
          //END else
        }
        // END public void r102Implementation(Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_VModel instance)
    }
}
