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
    public partial class MRP_TypeBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("MRP_Type", RowKind.New)]
        public void BuildNewMRP_Type()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
