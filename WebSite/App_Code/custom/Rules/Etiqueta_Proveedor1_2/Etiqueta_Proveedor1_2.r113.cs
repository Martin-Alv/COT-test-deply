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

        /// <summary>Rule "Generar_PDF_Prueva" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS07".
        /// </summary>
        [Rule("r113")]
        public void r113Implementation(Etiqueta_Proveedor1_2Model instance)
        {
            // This is the placeholder for method implementation.
            string Valores = instance.Valores_Etiqueta_Padre;
            Result.ShowAlert(Valores);
        }
    }
}
