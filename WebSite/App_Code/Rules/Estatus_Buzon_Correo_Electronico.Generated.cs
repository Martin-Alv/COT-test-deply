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
    public partial class Estatus_Buzon_Correo_ElectronicoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Buzon_Correo_Electronico", RowKind.New)]
        public void BuildNewEstatus_Buzon_Correo_Electronico()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
