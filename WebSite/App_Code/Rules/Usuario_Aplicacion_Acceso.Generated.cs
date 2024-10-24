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
    public partial class Usuario_Aplicacion_AccesoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Usuario_Aplicacion_Acceso", RowKind.New)]
        public void BuildNewUsuario_Aplicacion_Acceso()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
