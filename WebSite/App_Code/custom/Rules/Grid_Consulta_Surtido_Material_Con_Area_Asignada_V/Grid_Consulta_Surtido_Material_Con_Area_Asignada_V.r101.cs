using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

using System.Diagnostics; //Necesario para llamar a la aplicacion App_Captura_Surtido_En_Sap

namespace eaton.Rules
{
	public partial class Grid_Consulta_Surtido_Material_Con_Area_Asignada_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "IniciarCapturaLocalSap" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r101")]
        public void r101Implementation(Grid_Consulta_Surtido_Material_Con_Area_Asignada_VModel instance)
        {
            // This is the placeholder for method implementation.

            //Valores
            string Usuario_Id = UserId.ToString();// Id de Usuario logueado
            string Es_Captura_Local = "1";
            string Es_Captura_Remota = "0";
            //string Tipo_Surtido_Id = "1"; // Tipo de Surtido: 1 de surtidor normal, 2 surtidor con área asignada

            //Validamos nulos o vacíos
            if (Usuario_Id == null || Usuario_Id == "")
            {
                Usuario_Id = "5c7568fd-6412-474e-a099-006fad27cd02"; // Usuario sistema
            }

            //Llamada a App_Captura_Surtido_En_Sap
            ProcessStartInfo proceso = new ProcessStartInfo();
            //Ubicación del proceso
            proceso.FileName = "C://AppCapturaSap//Release//App_Captura_Surtido_En_Sap.exe";

            //Parámetros
            proceso.Arguments = Usuario_Id + "," + Es_Captura_Local + "," + Es_Captura_Remota;
            //Inicia proceso
            Process.Start(proceso);
        }
    }
}
