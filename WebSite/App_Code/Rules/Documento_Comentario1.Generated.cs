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
    public partial class Documento_Comentario1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Documento_Comentario1", RowKind.New)]
        public void BuildNewDocumento_Comentario1()
        {
            UpdateFieldValue("Orden_Produccion_Id", 0);
            UpdateFieldValue("Orden_Produccion_Detalle_Id", 0);
            UpdateFieldValue("Producto_Id", 0);
            UpdateFieldValue("Material_Id", 0);
            UpdateFieldValue("Es_Comentario", 0);
            UpdateFieldValue("Tipo_Comentario_Id", 3);
            UpdateFieldValue("Es_Imagen", 0);
            UpdateFieldValue("Es_Motivo_Cancelacion", 0);
            UpdateFieldValue("Motivo_Cancelacion_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Motivo_Movimiento_Id", 0);
            UpdateFieldValue("Movimiento_Ruta_Optima_Id", 0);
        }
    }
}
