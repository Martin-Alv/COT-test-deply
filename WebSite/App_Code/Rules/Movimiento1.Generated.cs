﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;

namespace eaton.Rules
{
    public partial class Movimiento1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        [RowBuilder("Movimiento1", RowKind.New)]
        public void BuildNewMovimiento1()
        {
            UpdateFieldValue("Area_Servicio_Id", 0);
            UpdateFieldValue("Tipo_Movimiento_Id", 0);
            UpdateFieldValue("Estatus_Movimiento_Id", 0);
            UpdateFieldValue("Area_Entrega_Id", 0);
            UpdateFieldValue("Devolucion_Ubicacion_Origen_Id", 0);
            UpdateFieldValue("Devolucion_Ubicacion_Destino_Id", 0);
            UpdateFieldValue("Estatus_Devolucion_Id", 0);
            UpdateFieldValue("Transferencia_Ubicacion_Origen_Id", 0);
            UpdateFieldValue("Transferencia_Ubicacion_Destino_Id", 0);
            UpdateFieldValue("Movimiento_Ruta_Optima_Id", 0);
            UpdateFieldValue("Estatus_Registro_Id", 1);
        }
    }
}