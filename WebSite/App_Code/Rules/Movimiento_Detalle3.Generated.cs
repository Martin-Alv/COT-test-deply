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
    public partial class Movimiento_Detalle3BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Movimiento_Detalle3", RowKind.New)]
        public void BuildNewMovimiento_Detalle3()
        {
            UpdateFieldValue("Movimiento_Id", 1);
            UpdateFieldValue("Devolucion_Material_Id", 1);
            UpdateFieldValue("Devolucion_Ubicacion_Origen_Id", 1);
            UpdateFieldValue("Devolucion_Ubicacion_Destino_Id", 1);
            UpdateFieldValue("Estatus_Devolucion_Id", 1);
            UpdateFieldValue("Unidad_Material_A_Devolver_Id", 1);
            UpdateFieldValue("Unidad_Material_Devuelto_Id", 1);
            UpdateFieldValue("Transferencia_Material_Id", 1);
            UpdateFieldValue("Transferencia_Ubicacion_Origen_Id", 1);
            UpdateFieldValue("Transferencia_Ubicacion_Destino_Id", 1);
            UpdateFieldValue("Unidad_Material_A_Transferir_Id", 1);
            UpdateFieldValue("Unidad_Material_Transferido_Id", 1);
            UpdateFieldValue("Estatus_Transferencia_Id", 1);
            UpdateFieldValue("Motivo_Movimiento_Id", 1);
            UpdateFieldValue("Movimiento_Ruta_Optima_Id", 1);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
