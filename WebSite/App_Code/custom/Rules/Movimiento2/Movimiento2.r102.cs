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
    public partial class Movimiento2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Enviar_A_Transferir" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Movimiento2Model instance)
        {
            // This is the placeholder for method implementation.


            long Movimiento_Id = instance.Movimiento_Id ?? 0;
            int Tipo_Operacion_Id = 1; // Enviar a transferir


            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;


            resultadoEjecucion = administrarMovimiento(
                 Tipo_Operacion_Id
                , Movimiento_Id
               //---                
               , out MensajeSistema
               , out MensajeSistemaId
               , out ProcesoSistemaId
           );

            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                Result.ShowAlert(MensajeSistema);
            }
            else
            {
                if (resultadoEjecucion == true && MensajeSistemaId == 1)
                {
                    //Result.ExecuteOnClient("window.location.replace('Ruta_Optima_A_Ejecutar_V?Creado_Por_Id=" + UserId + "&Transaccion_Id=" + RutaOptimaTransaccionId + "')");
                    Result.ShowMessage(MensajeSistema);
                    Result.Continue();
                }
            }// END else

        }
    }
}
