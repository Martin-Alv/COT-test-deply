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
    public partial class ProductoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Producto", RowKind.New)]
        public void BuildNewProducto()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Categoria_Id", 0);
        }
    }
}
