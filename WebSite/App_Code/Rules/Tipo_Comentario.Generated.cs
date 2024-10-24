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
    public partial class Tipo_ComentarioBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Tipo_Comentario", RowKind.New)]
        public void BuildNewTipo_Comentario()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
