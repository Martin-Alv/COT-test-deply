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
    public partial class Documento_ComentarioBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Documento_Comentario", RowKind.New)]
        public void BuildNewDocumento_Comentario()
        {
            UpdateFieldValue("Es_Comentario", 0);
            UpdateFieldValue("Es_Imagen", 0);
            UpdateFieldValue("Es_Motivo_Cancelacion", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
