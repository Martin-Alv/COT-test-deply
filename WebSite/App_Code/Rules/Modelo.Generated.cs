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
	public partial class ModeloBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Modelo", RowKind.New)]
        public void BuildNewModelo()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}