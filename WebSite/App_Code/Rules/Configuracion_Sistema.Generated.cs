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
    public partial class Configuracion_SistemaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Configuracion_Sistema", RowKind.New)]
        public void BuildNewConfiguracion_Sistema()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
