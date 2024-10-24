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
    public partial class Material_Ubicacion_StockBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Material_Ubicacion_Stock", RowKind.New)]
        public void BuildNewMaterial_Ubicacion_Stock()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
