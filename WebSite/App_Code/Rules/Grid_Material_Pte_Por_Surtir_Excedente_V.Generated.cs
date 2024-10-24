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
    public partial class Grid_Material_Pte_Por_Surtir_Excedente_VBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Grid_Material_Pte_Por_Surtir_Excedente_V", RowKind.New)]
        public void BuildNewGrid_Material_Pte_Por_Surtir_Excedente_V()
        {
            UpdateFieldValue("Area_Servicio_Id", 0);
            UpdateFieldValue("Familia_Id", 0);
        }
    }
}
