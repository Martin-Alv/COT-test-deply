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
    public partial class Clase_MaterialBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Clase_Material", RowKind.New)]
        public void BuildNewClase_Material()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
