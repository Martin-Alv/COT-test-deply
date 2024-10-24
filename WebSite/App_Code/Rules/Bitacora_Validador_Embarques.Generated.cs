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
    public partial class Bitacora_Validador_EmbarquesBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Bitacora_Validador_Embarques", RowKind.New)]
        public void BuildNewBitacora_Validador_Embarques()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
