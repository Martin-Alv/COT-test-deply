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
	public partial class Orden_Produccion_ModeloBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Orden_Produccion_Modelo", RowKind.New)]
        public void BuildNewOrden_Produccion_Modelo()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
