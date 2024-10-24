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
    public partial class Area_EntregaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Area_Entrega", RowKind.New)]
        public void BuildNewArea_Entrega()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
