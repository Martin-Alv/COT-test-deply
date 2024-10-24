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
    public partial class Orden_Produccion1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Orden_Produccion1", RowKind.New)]
        public void BuildNewOrden_Produccion1()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Habilitar_Crear_Solicitud", 0);
            UpdateFieldValue("Existencia_Completa_Cantidad_Material", 1);
            UpdateFieldValue("Cantidad_Dias_Produccion", 0);
        }
    }
}
