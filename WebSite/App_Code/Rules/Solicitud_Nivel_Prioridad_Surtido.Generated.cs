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
    public partial class Solicitud_Nivel_Prioridad_SurtidoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Solicitud_Nivel_Prioridad_Surtido", RowKind.New)]
        public void BuildNewSolicitud_Nivel_Prioridad_Surtido()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
