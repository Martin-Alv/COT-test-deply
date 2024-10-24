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
    public partial class SS_Dat_OrderBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("SS_Dat_Order", RowKind.New)]
        public void BuildNewSS_Dat_Order()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
