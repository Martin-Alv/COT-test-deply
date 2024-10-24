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
    public partial class Motivo_MovimientoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Motivo_Movimiento", RowKind.New)]
        public void BuildNewMotivo_Movimiento()
        {
            UpdateFieldValue("Aplica_A_Devolucion", 0);
            UpdateFieldValue("Aplica_A_Transferencia", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
