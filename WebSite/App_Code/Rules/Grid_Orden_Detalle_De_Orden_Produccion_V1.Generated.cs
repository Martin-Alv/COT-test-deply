﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;

namespace eaton.Rules
{
    public partial class Grid_Orden_Detalle_De_Orden_Produccion_V1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Grid_Orden_Detalle_De_Orden_Produccion_V1", RowKind.New)]
        public void BuildNewGrid_Orden_Detalle_De_Orden_Produccion_V1()
        {
            UpdateFieldValue("Folio_Desviacion", 0);
        }
    }
}