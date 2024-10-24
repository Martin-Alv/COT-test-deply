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
    public partial class Impresion_Etiqueta_ProveedorBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Impresion_Etiqueta_Proveedor", RowKind.New)]
        public void BuildNewImpresion_Etiqueta_Proveedor()
        {
            UpdateFieldValue("Tamanio_Etiqueta_Id", 1);
        }
    }
}
