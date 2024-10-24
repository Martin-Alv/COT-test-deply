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
    public partial class Tipo_UsuarioBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Tipo_Usuario", RowKind.New)]
        public void BuildNewTipo_Usuario()
        {
            UpdateFieldValue("Es_Persona", 0);
            UpdateFieldValue("Es_Area_Servicio", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
