using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;
using System.Collections.Specialized;
using System.Net;

namespace eaton.Rules
{
    public partial class Etiqueta_Proveedor1_1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Generar_Etiquetas" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Report" and argument that matches "ExecCS05".
        /// </summary>
        [Rule("r110")]
        public void r110Implementation(Etiqueta_Proveedor1_1Model instance)
        {
            // This is the placeholder for method implementation.


        }
    }
}
