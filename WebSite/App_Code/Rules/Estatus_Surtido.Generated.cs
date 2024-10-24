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
    public partial class Estatus_SurtidoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Surtido", RowKind.New)]
        public void BuildNewEstatus_Surtido()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
