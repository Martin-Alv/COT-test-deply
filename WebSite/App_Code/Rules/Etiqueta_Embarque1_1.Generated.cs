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
    public partial class Etiqueta_Embarque1_1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta_Embarque1_1", RowKind.New)]
        public void BuildNewEtiqueta_Embarque1_1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
