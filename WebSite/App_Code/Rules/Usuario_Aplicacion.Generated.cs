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
    public partial class Usuario_AplicacionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Usuario_Aplicacion", RowKind.New)]
        public void BuildNewUsuario_Aplicacion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Tipo_Usuario_Id", 0);
            UpdateFieldValue("Genero_Persona_Id", 0);
            UpdateFieldValue("Estatus_Usuario_Id", 0);
            UpdateFieldValue("Area_Servicio_Id", 0);
        }
    }
}
