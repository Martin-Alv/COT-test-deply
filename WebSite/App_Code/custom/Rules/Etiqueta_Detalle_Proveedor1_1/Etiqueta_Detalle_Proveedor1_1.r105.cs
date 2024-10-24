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
    public partial class Etiqueta_Detalle_Proveedor1_1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Generar_Etiqueta" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Report" and argument that matches "ExecCS02".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(Etiqueta_Detalle_Proveedor1_1Model instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
