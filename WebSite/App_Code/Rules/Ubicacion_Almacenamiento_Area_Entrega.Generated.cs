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
    public partial class Ubicacion_Almacenamiento_Area_EntregaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Ubicacion_Almacenamiento_Area_Entrega", RowKind.New)]
        public void BuildNewUbicacion_Almacenamiento_Area_Entrega()
        {
            UpdateFieldValue("Ubicacion_Almacenamiento_Id", 0);
            UpdateFieldValue("Area_Entrega_Id", 0);
        }
    }
}
