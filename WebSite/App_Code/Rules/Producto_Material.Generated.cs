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
    public partial class Producto_MaterialBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Producto_Material", RowKind.New)]
        public void BuildNewProducto_Material()
        {
            UpdateFieldValue("Producto_Id", 0);
            UpdateFieldValue("Material_Id", 0);
            UpdateFieldValue("Unidad_Material_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
