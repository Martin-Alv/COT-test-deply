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
    public partial class Temporal_Material_ClasificacionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Temporal_Material_Clasificacion", RowKind.New)]
        public void BuildNewTemporal_Material_Clasificacion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
