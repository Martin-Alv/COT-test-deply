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
	public partial class Mov_Transfer_Ruta_Optima_A_Ejecutar_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Cancelar_Transferencia" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Mov_Transfer_Ruta_Optima_A_Ejecutar_VModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
