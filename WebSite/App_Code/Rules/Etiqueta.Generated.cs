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
    public partial class EtiquetaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta", RowKind.New)]
        public void BuildNewEtiqueta()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
