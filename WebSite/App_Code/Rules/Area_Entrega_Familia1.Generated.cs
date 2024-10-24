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
    public partial class Area_Entrega_Familia1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Area_Entrega_Familia1", RowKind.New)]
        public void BuildNewArea_Entrega_Familia1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
