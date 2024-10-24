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
    public partial class Usuario_Aplicacion_Area_Entrega_Nivel_Prioridad_SurtidoBusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Usuario_Aplicacion_Area_Entrega_Nivel_Prioridad_Surtido", RowKind.New)]
        public void BuildNewUsuario_Aplicacion_Area_Entrega_Nivel_Prioridad_Surtido()
        {
            UpdateFieldValue("Usuario_Aplicacion_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}
