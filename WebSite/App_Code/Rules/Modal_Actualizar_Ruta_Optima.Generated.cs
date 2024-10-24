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
    public partial class Modal_Actualizar_Ruta_OptimaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Modal_Actualizar_Ruta_Optima", RowKind.New)]
        public void BuildNewModal_Actualizar_Ruta_Optima()
        {
            UpdateFieldValue("Unidad_Material_Entregado_Id", 0);
        }
    }
}
