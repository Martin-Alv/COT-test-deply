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
    public partial class Bitacora_Captura_Sap1_2_1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Bitacora_Captura_Sap1_2_1", RowKind.New)]
        public void BuildNewBitacora_Captura_Sap1_2_1()
        {
            UpdateFieldValue("Ruta_Optima_Id", 0);
            UpdateFieldValue("Material_Surtido_Id", 0);
            UpdateFieldValue("Es_Captura_Local", 0);
            UpdateFieldValue("Es_Captura_Remota", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
