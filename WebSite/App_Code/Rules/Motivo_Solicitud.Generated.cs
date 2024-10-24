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
    public partial class Motivo_SolicitudBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Motivo_Solicitud", RowKind.New)]
        public void BuildNewMotivo_Solicitud()
        {
            UpdateFieldValue("Es_Otro", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Es_Frame", 0);
            UpdateFieldValue("Es_Error_De_Aplicacion", 0);
            UpdateFieldValue("Es_Material_Danado_Almacen", 0);
        }
    }
}
