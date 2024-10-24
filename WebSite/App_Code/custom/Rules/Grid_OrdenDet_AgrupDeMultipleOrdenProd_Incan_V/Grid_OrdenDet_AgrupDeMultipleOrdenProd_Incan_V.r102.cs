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
	public partial class Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Administrar_Material_Agrupado_De_Multiple_Orden_Prod" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VModel instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
