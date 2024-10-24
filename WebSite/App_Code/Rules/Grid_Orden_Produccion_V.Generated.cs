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
    public partial class Grid_Orden_Produccion_VBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Grid_Orden_Produccion_V", RowKind.New)]
        public void BuildNewGrid_Orden_Produccion_V()
        {
            UpdateFieldValue("Habilitar_Crear_Solicitud", 0);
            UpdateFieldValue("Existencia_Completa_Cantidad_Material", 1);
        }
    }
}
