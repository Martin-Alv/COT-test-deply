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
    public partial class Cancelar_Surtido_Custom_DialogBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Cancelar_Surtido_Custom_Dialog", RowKind.New)]
        public void BuildNewCancelar_Surtido_Custom_Dialog()
        {
            UpdateFieldValue("Motivo_Cancelacion_Id", 0);
        }
    }
}
