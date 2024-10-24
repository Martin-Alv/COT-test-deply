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
    public partial class Estatus_Orden_Produccion_DetalleBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Estatus_Orden_Produccion_Detalle", RowKind.New)]
        public void BuildNewEstatus_Orden_Produccion_Detalle()
        {
            UpdateFieldValue("Significa_Pendiente", 0);
            UpdateFieldValue("Significa_Entregado", 0);
            UpdateFieldValue("Significa_Cancelado", 0);
            UpdateFieldValue("Significa_Enviado_A_Solicitud", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
