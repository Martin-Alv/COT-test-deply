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
    public partial class Solicitud2_2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Solicitud2_2", RowKind.New)]
        public void BuildNewSolicitud2_2()
        {
            UpdateFieldValue("Unidad_Material_Entregado_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Orden_Produccion_Id", 0);
            UpdateFieldValue("Orden_Produccion_Detalle_Id", 0);
            UpdateFieldValue("Familia_Id", 0);
            UpdateFieldValue("Producto_Id", 0);
            UpdateFieldValue("Cantidad_Entregado", 0);
            UpdateFieldValue("Es_De_Excedente", 0);
        }
    }
}
