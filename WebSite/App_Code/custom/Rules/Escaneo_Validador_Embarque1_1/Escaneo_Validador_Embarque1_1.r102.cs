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
    public partial class Escaneo_Validador_Embarque1_1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS001".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Escaneo_Validador_Embarque1_1Model instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
