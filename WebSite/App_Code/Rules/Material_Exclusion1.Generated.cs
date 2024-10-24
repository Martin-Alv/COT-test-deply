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
    public partial class Material_Exclusion1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Material_Exclusion1", RowKind.New)]
        public void BuildNewMaterial_Exclusion1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
