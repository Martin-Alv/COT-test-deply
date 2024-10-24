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
    public partial class Etiqueta_EmbarqueBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta_Embarque", RowKind.New)]
        public void BuildNewEtiqueta_Embarque()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
