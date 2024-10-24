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
    public partial class Solicitud4BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Solicitud4", RowKind.New)]
        public void BuildNewSolicitud4()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Motivo_Solicitud_Id", 0);
        }
    }
}
