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
	public partial class Usuario_Aplicacion_AccesoBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "DesbloquearUsuario" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Customs" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Usuario_Aplicacion_AccesoModel instance)
        {
            // This is the placeholder for method implementation.

            // Declaración de variables
            int tipoOperacionId = 2; // Desbloquear usuario
            int usuarioAplicacionAccesoId = instance.Usuario_Aplicacion_Acceso_Id ?? 0;
            string nip = instance.Nip ?? "";

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (usuarioAplicacionAccesoId == 0)
            {
                Result.ShowMessage("El identificador de Usuario Aplicacion Acceso es obligatorio.");
            }            
            else
            {
                resultadoEjecucion = ActualizarUsuarioAplicacionAcceso(
                    tipoOperacionId
                    ,usuarioAplicacionAccesoId
                    , nip
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
                        Result.ShowMessage(MensajeSistema);
                        //Result.Continue();
                        Result.Refresh(); // Refrescamos el grid
                    }
                }
            }
        }
        // END public void r104Implementation(Usuario_Aplicacion_AccesoModel instance)
    }
}
