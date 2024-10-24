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
    public partial class Handler_Carga_Material : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Temporal_Carga_Masiva_Material1", RowKind.New)]
        public void BuildNewTemporal_Carga_Masiva_Material1()
        {
            UpdateFieldValue("Estatus_Procesamiento_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
