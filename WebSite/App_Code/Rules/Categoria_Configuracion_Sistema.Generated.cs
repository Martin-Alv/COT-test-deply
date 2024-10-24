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
    public partial class Categoria_Configuracion_SistemaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Categoria_Configuracion_Sistema", RowKind.New)]
        public void BuildNewCategoria_Configuracion_Sistema()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
