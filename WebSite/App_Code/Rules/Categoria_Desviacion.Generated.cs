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
    public partial class Categoria_DesviacionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Categoria_Desviacion", RowKind.New)]
        public void BuildNewCategoria_Desviacion()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
