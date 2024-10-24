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
    public partial class Motivo_CancelacionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Motivo_Cancelacion", RowKind.New)]
        public void BuildNewMotivo_Cancelacion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
