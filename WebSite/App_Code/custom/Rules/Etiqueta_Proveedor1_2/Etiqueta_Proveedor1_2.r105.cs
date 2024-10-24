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
    public partial class Etiqueta_Proveedor1_2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Generar_Etiqueta_Detalle_Proveedor" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(Etiqueta_Proveedor1_2Model instance)
        {
            // This is the placeholder for method implementation.
        }
    }
}
