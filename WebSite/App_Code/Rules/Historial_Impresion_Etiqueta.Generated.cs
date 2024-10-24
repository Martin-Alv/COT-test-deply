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
    public partial class Historial_Impresion_EtiquetaBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Historial_Impresion_Etiqueta", RowKind.New)]
        public void BuildNewHistorial_Impresion_Etiqueta()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
