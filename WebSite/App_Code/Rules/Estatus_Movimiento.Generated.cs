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
    public partial class Estatus_MovimientoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Movimiento", RowKind.New)]
        public void BuildNewEstatus_Movimiento()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}