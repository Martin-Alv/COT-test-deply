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
    public partial class Etiqueta_Embarque_DetalleBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Etiqueta_Embarque_Detalle", RowKind.New)]
        public void BuildNewEtiqueta_Embarque_Detalle()
        {
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
