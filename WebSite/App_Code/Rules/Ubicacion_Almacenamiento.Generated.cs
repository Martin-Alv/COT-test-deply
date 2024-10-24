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
    public partial class Ubicacion_AlmacenamientoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Ubicacion_Almacenamiento", RowKind.New)]
        public void BuildNewUbicacion_Almacenamiento()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
            UpdateFieldValue("Aplica_Para_Ruta_Optima", 0);
        }
    }
}
