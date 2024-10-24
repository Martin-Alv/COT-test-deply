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
    public partial class Desviacion_MaterialBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Desviacion_Material", RowKind.New)]
        public void BuildNewDesviacion_Material()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
