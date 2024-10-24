using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Modal_Actualizar_Ruta_OptimaDataField
    {

        Cantidad_Entregado,

        Unidad_Material_Entregado_Id,

        Ruta_Optima_Id,

        Orden_Produccion_Id,

        Solicitud_Id,
    }

    public partial class Modal_Actualizar_Ruta_OptimaModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;

        public Modal_Actualizar_Ruta_OptimaModel()
        {
        }

        public Modal_Actualizar_Ruta_OptimaModel(BusinessRules r) :
                base(r)
        {
        }

        public decimal? Cantidad_Entregado
        {
            get
            {
                return _cantidad_Entregado;
            }
            set
            {
                _cantidad_Entregado = value;
                UpdateFieldValue("Cantidad_Entregado", value);
            }
        }

        public int? Unidad_Material_Entregado_Id
        {
            get
            {
                return _unidad_Material_Entregado_Id;
            }
            set
            {
                _unidad_Material_Entregado_Id = value;
                UpdateFieldValue("Unidad_Material_Entregado_Id", value);
            }
        }

        public long? Ruta_Optima_Id
        {
            get
            {
                return _ruta_Optima_Id;
            }
            set
            {
                _ruta_Optima_Id = value;
                UpdateFieldValue("Ruta_Optima_Id", value);
            }
        }

        public long? Orden_Produccion_Id
        {
            get
            {
                return _orden_Produccion_Id;
            }
            set
            {
                _orden_Produccion_Id = value;
                UpdateFieldValue("Orden_Produccion_Id", value);
            }
        }

        public long? Solicitud_Id
        {
            get
            {
                return _solicitud_Id;
            }
            set
            {
                _solicitud_Id = value;
                UpdateFieldValue("Solicitud_Id", value);
            }
        }

        public FieldValue this[Modal_Actualizar_Ruta_OptimaDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
