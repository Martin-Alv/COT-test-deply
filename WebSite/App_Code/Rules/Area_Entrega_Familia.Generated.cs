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
    public partial class Area_Entrega_FamiliaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Area_Entrega_Familia", RowKind.New)]
        public void BuildNewArea_Entrega_Familia()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}