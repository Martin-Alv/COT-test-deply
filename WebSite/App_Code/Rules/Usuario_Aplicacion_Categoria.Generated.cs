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
    public partial class Usuario_Aplicacion_CategoriaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Usuario_Aplicacion_Categoria", RowKind.New)]
        public void BuildNewUsuario_Aplicacion_Categoria()
        {
            UpdateFieldValue("Categoria_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
