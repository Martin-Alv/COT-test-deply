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
    public partial class Movimiento3BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Movimiento3", RowKind.New)]
        public void BuildNewMovimiento3()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
