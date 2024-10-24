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
    public partial class Categoria_SolicitudBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Categoria_Solicitud", RowKind.New)]
        public void BuildNewCategoria_Solicitud()
        {
            UpdateFieldValue("Es_De_Excedente", 0);
            UpdateFieldValue("Es_De_Kanban", 0);
            UpdateFieldValue("Es_Otro", 0);
        }
    }
}
