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
    public partial class Temporal_ZINV1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Temporal_ZINV1", RowKind.New)]
        public void BuildNewTemporal_ZINV1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
