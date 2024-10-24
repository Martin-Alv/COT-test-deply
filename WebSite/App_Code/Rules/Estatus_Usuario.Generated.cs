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
    public partial class Estatus_UsuarioBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Usuario", RowKind.New)]
        public void BuildNewEstatus_Usuario()
        {
            UpdateFieldValue("Es_Activo", 0);
            UpdateFieldValue("Es_Baja_Temporal", 0);
            UpdateFieldValue("Es_Inactivo", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
