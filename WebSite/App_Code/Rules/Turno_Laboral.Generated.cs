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
    public partial class Turno_LaboralBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Turno_Laboral", RowKind.New)]
        public void BuildNewTurno_Laboral()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
