using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;

namespace eaton.Rules
{
    public partial class Etiqueta_Detalle_Proveedor1_2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta_Detalle_Proveedor1_2", RowKind.New)]
        public void BuildNewEtiqueta_Detalle_Proveedor1_2()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
