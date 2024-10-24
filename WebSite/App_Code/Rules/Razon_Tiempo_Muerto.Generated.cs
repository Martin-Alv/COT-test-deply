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
    public partial class Razon_Tiempo_MuertoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Razon_Tiempo_Muerto", RowKind.New)]
        public void BuildNewRazon_Tiempo_Muerto()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
