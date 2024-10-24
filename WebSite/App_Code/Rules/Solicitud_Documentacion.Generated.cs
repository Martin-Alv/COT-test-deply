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
	public partial class Solicitud_DocumentacionBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Solicitud_Documentacion", RowKind.New)]
        public void BuildNewSolicitud_Documentacion()
        {
            UpdateFieldValue("Es_Comentario", 0);
            UpdateFieldValue("Es_Imagen", 0);
        }
    }
}
