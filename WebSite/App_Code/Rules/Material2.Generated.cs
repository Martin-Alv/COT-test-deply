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
    public partial class Material2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Material2", RowKind.New)]
        public void BuildNewMaterial2()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
