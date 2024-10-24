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
    public partial class SemaforoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Semaforo", RowKind.New)]
        public void BuildNewSemaforo()
        {
            UpdateFieldValue("Es_Semaforo_Tiempo_Entrega", 0);
            UpdateFieldValue("Es_Semaforo_Mat_Exist_Parcial", 0);
            UpdateFieldValue("Es_Semaforo_Mat_Inexistente", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Es_Semaforo_Estatus_Solicitud", 0);
        }
    }
}
