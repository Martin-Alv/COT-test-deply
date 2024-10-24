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
    public partial class Temporal_Carga_Masiva_Material3BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Prcesar_Material" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Temporal_Carga_Masiva_Material3Model instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
