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
    public partial class Tipo_UbicacionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Tipo_Ubicacion", RowKind.New)]
        public void BuildNewTipo_Ubicacion()
        {
            UpdateFieldValue("Es_Almacen", 0);
            UpdateFieldValue("Es_Piso", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
