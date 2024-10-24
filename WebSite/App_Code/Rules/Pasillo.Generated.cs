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
    public partial class PasilloBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Pasillo", RowKind.New)]
        public void BuildNewPasillo()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
