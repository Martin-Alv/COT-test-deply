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
    public partial class Estatus_Captura_SapBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Captura_Sap", RowKind.New)]
        public void BuildNewEstatus_Captura_Sap()
        {
            UpdateFieldValue("Significa_Pendiente", 0);
            UpdateFieldValue("Significa_Capturado_Exitosamente", 0);
            UpdateFieldValue("Significa_Capturado_Con_Errores", 0);
            UpdateFieldValue("Significa_Cancelado", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
