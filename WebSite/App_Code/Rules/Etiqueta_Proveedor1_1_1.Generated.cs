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
    public partial class Handler_Ultima_Carga_Etiqueta_Usuario_Cooper : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta_Proveedor1_1_1", RowKind.New)]
        public void BuildNewEtiqueta_Proveedor1_1_1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
