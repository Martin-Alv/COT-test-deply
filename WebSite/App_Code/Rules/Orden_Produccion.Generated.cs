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
    public partial class Orden_ProduccionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Orden_Produccion", RowKind.New)]
        public void BuildNewOrden_Produccion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Estatus_Orden_Produccion_Id", 0);
            UpdateFieldValue("Esta_Bloqueado", 0);
        }
    }
}
