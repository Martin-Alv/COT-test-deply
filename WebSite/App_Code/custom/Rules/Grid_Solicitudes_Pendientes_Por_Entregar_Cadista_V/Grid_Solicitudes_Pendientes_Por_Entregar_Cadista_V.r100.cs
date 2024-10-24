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
	public partial class Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Entregar_Solicitud" implementation:
        /// This method will execute in any view before an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VModel instance)
        {
            // Declaración de variables
            int TipoOperacionId = 1; // entregar solicitud
            Int64 solicitudId = instance.Solicitud_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";

            resultadoEjecucion = AdministrarSolicitudCadista(
                TipoOperacionId
                ,solicitudId
                //---                
                , out MensajeSistema
                , out MensajeSistemaId
            );

            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(85, MensajeSistemaId, "", MensajeSistema);
                Result.ShowAlert(MensajeSistema);
            }
            else
            {
                if (resultadoEjecucion == true && MensajeSistemaId == 1)
                {
                    Result.ExecuteOnClient("window.location.reload();");
                    Result.ShowMessage("La solicitud fue entregada correctamente");
                    
                }
            }
        }
    }
}
