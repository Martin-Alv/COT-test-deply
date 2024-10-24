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
	public partial class Grid_Movimiento_Transfer_Pte_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Generar_Tmp_Mov_Ruta_Optima" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r101")]
        //START public void r101Implementation(Grid_Movimiento_Transfer_Pte_VModel instance)
        public void r101Implementation(Grid_Movimiento_Transfer_Pte_VModel instance)
        {
            // This is the placeholder for method implementation.
            Int64 MovimientoId = instance.Movimiento_Id ?? 0;
            int TipoMovimientoId = instance.Tipo_Movimiento_Id ?? 0;

            bool resultadoGenerarTmpMovRutaOptima;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;
            string tmpMovRutaOptimaTransaccionId = instance.Tmp_Mov_Ruta_Optima_Transaccion_Id;

            // Generación de mov ruta óptima temporal
            resultadoGenerarTmpMovRutaOptima = GenerarTmpMovRutaOptima(
                MovimientoId
                , TipoMovimientoId
                , tmpMovRutaOptimaTransaccionId
                //---                
                , out MensajeSistema
                , out MensajeSistemaId
            );

            if (resultadoGenerarTmpMovRutaOptima == false || (resultadoGenerarTmpMovRutaOptima == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                Result.ShowMessage(MensajeSistema);
                //Agregamos el error al arreglo
                Result.Errors.Add(MensajeSistema);
            }
            else
            {
                if (resultadoGenerarTmpMovRutaOptima == true && MensajeSistemaId == 1)
                {
                    Result.ShowMessage(MensajeSistema);
                }
            }// END else
        }
        //END public void r101Implementation(Grid_Movimiento_Transfer_Pte_VModel instance)
    }
}
