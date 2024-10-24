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
    public partial class Estatus_SolicitudBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Solicitud", RowKind.New)]
        public void BuildNewEstatus_Solicitud()
        {
            UpdateFieldValue("Significa_Pendiente", 0);
            UpdateFieldValue("Significa_Entregada", 0);
            UpdateFieldValue("Significa_Cancelada", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Significa_Surtida_Completa", 0);
            UpdateFieldValue("Significa_Surtida_Parcial", 0);
        }
    }
}
