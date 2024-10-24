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
	public partial class Grid_Orden_Detalle_De_Orden_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Grid_Orden_Detalle_De_Orden_Produccion_VModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
