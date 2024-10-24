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
	public partial class Grid_Solicitud_A_Surtir_De_Orden_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Iniciar_Surtido" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Grid_Solicitud_A_Surtir_De_Orden_Produccion_VModel instance)
        {/*
            // This is the placeholder for method implementation.
            // Declaración de variables   
            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;
            // Variables de salida
            string RutaOptimaTransaccionId = "";

            resultadoEjecucion = GenerarRutaOptima(   
                out RutaOptimaTransaccionId
                //---                
                ,out MensajeSistema
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
                    Result.ExecuteOnClient("window.location.replace('Ruta_Optima_A_Ejecutar_V?Creado_Por_Id=" + UserId + "&Transaccion_Id=" + RutaOptimaTransaccionId + "')");
                    //Result.ExecuteOnClient("$app.touch.show({  controller: 'Ruta_Optima_A_Ejecutar_V',  startCommand: 'Select',  startArgument: 'grid1'});");
                    //Result.ExecuteOnClient("pages/Ruta_Optima_A_Ejecutar_V?_controller=Ruta_Optima_A_Ejecutar_V&_command=Select&_argument=grid1");
                    //Result.ExecuteOnClient("_blank:~/pages/Ruta_Optima_A_Ejecutar_V? Estatus_Registro_Id ={ Estatus_Registro_Id}& _controller = Estatus_Registro & _command = Select & _argument = editForm1");
                    //+ ",    done: function(result) {                        console.log(result);                    }                })");
                    //Result.("Ruta_Optima_A_Ejecutar_V.html?Creado_Por_Id="+UserId+"");
                }
            }
            */
        }// END public void r100Implementation(Grid_Solicitud_A_Surtir_De_Orden_Produccion_VModel instance)
    }
}
