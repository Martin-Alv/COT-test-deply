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
    public partial class Handler_Ultima_Carga : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Temporal_Etiqueta_Proveedor1", RowKind.New)]
        public void BuildNewTemporal_Etiqueta_Proveedor1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}