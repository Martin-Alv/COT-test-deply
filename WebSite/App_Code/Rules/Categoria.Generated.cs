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
    public partial class CategoriaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Categoria", RowKind.New)]
        public void BuildNewCategoria()
        {
            UpdateFieldValue("Familia_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
