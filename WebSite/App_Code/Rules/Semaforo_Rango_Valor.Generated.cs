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
    public partial class Semaforo_Rango_ValorBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Semaforo_Rango_Valor", RowKind.New)]
        public void BuildNewSemaforo_Rango_Valor()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
