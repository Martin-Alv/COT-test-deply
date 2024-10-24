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
	public partial class Movimiento_Detalle2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Obtener_Materiales" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        //START public void r100Implementation(Movimiento_Detalle2Model instance)
        public void r100Implementation(Movimiento_Detalle2Model instance)
        {
            // This is the placeholder for method implementation.
            //Valores
            long MovimientoId = instance.Movimiento_Id ?? 0;
            int UbicacionOrigenId = Convert.ToInt32(SelectFieldValue("Parameters_Ubicacion_Almacenamiento_Id").ToString());
            //int UbicacionDestinoId = instance.Transferencia_Ubicacion_Destino_Id ?? 0;
            int AreaEntregaId = instance.Area_Entrega_Id ?? 0;

            string mensajeSistema = "";
            int mensajeSistemaId = 0;

            bool resultadoObtenerMateriales;

            if (UbicacionOrigenId == 0)
            {
                Result.ShowMessage("Debe seleccionar ubicación Origen");               
            }
            else
            {
                resultadoObtenerMateriales = ObtenerMaterialesDeUbicacionOrigen(
                    MovimientoId
                    , UbicacionOrigenId
                    , 0 //UbicacionDestinoId
                    , AreaEntregaId
                    //
                    , out mensajeSistema
                    , out mensajeSistemaId
                );

                if (resultadoObtenerMateriales == false || (resultadoObtenerMateriales == true && mensajeSistemaId != 1))
                {
                    RegistrarEnBitacora(0, mensajeSistemaId, "", mensajeSistema);
                    Result.ShowMessage(mensajeSistema);
                }
                else
                {
                    if (resultadoObtenerMateriales == true && mensajeSistemaId == 1)
                    {
                        Result.ShowMessage(mensajeSistema);
                        Result.Refresh();
                    }
                }// END else
            }
        }
        //END public void r100Implementation(Movimiento_Detalle2Model instance)
    }
}
