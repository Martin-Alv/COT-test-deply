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
	public partial class Grid_Material_Pte_Por_Surtir_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Grid_Material_Pte_Por_Surtir_V", RowKind.New)]
        public void BuildNewGrid_Material_Pte_Por_Surtir_V()
        {
            UpdateFieldValue("Es_Edit_Mat_Unidad_Mat", 0);
        }
    }
}
