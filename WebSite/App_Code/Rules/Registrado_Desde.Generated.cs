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
    public partial class Registrado_DesdeBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Registrado_Desde", RowKind.New)]
        public void BuildNewRegistrado_Desde()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
