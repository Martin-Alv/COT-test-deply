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
	public partial class Grid_Orden_Prod_Incandescencias_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "EnviarOrdenProdASurtidor" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r101")]
        //START public void r101Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
        public void r101Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            int tipoOperacionId = 1; // Registrar
            long ordenProduccionId = instance.Orden_Produccion_Id ?? 0;
            long productoId = instance.Producto_Id ?? 0;
            long NumeroOrdenProduccion = instance.Numero_Orden_Produccion ?? 0;
            int AreaServicioId = instance.Area_Servicio_Id ?? 0; 

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (ordenProduccionId == 0)
            {
                Result.ShowMessage("El identificador de Orden de Producción es obligatorio!");
            }
            else
            {
                resultadoEjecucion = AdministrarOrdenProduccionPickeo(
                    tipoOperacionId
                    ,ordenProduccionId
                    ,NumeroOrdenProduccion
                    ,productoId
                    ,AreaServicioId
                    //---                
                    , out MensajeSistema
                    , out MensajeSistemaId
                    , out ProcesoSistemaId
                );

                //START if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                {
                    RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                    Result.ShowMessage(MensajeSistema);
                }
                //END if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
                else
                {
                    if (resultadoEjecucion == true && MensajeSistemaId == 1)
                    {
                        Result.ShowMessage(MensajeSistema);
                        Result.Refresh();
                        Result.Continue();
                    }
                }
            }
        }
        //END public void r101Implementation(Grid_Orden_Prod_Incandescencias_VModel instance)
    }
}
