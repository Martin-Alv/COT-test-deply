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
    public partial class Estatus_Orden_ProduccionBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Orden_Produccion", RowKind.New)]
        public void BuildNewEstatus_Orden_Produccion()
        {
            UpdateFieldValue("Significa_Pendiente", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Significa_Cancelado", 0);
            UpdateFieldValue("Significa_Orden_Sin_Material", 0);
        }
    }
}