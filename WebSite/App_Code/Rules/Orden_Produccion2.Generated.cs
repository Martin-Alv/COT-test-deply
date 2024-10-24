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
	public partial class Orden_Produccion2BusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Orden_Produccion2", RowKind.New)]
        public void BuildNewOrden_Produccion2()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Estatus_Orden_Produccion_Id", 0);
        }
    }
}
