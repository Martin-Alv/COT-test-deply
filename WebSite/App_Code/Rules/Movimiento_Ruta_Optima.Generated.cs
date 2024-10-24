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
    public partial class Movimiento_Ruta_OptimaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Movimiento_Ruta_Optima", RowKind.New)]
        public void BuildNewMovimiento_Ruta_Optima()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
