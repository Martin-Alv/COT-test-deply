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
    public partial class Material_Unidad_MaterialBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Material_Unidad_Material", RowKind.New)]
        public void BuildNewMaterial_Unidad_Material()
        {
            UpdateFieldValue("Puede_Surtirse_Manualmente", 0);
            UpdateFieldValue("Permitir_Desviacion", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
