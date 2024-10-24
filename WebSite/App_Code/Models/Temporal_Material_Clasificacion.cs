using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Temporal_Material_ClasificacionDataField
    {

        Temporal_Material_Clasificacion_Id,

        Temporal_Material_Clasificacion,

        Materal_Descripcion,

        MRP_Type_Id,

        Clasificacion,

        Mensaje_Sistema_Id,

        Mensaje_Sistema,

        Carga,

        Fecha_Procesamiento,

        Transaccion_Procesamiento,

        Creado_Por,

        Fecha_Creacion,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Actualizado_Por,

        Estatus_Procesamiento_Id,

        Estatus_Procesamiento,
    }

    public partial class Temporal_Material_ClasificacionModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_Material_Clasificacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _temporal_Material_Clasificacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _materal_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mRP_Type_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clasificacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _carga;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _transaccion_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento;

        public Temporal_Material_ClasificacionModel()
        {
        }

        public Temporal_Material_ClasificacionModel(BusinessRules r) :
                base(r)
        {
        }

        public int? Temporal_Material_Clasificacion_Id
        {
            get
            {
                return _temporal_Material_Clasificacion_Id;
            }
            set
            {
                _temporal_Material_Clasificacion_Id = value;
                UpdateFieldValue("Temporal_Material_Clasificacion_Id", value);
            }
        }

        public string Temporal_Material_Clasificacion_
        {
            get
            {
                return _temporal_Material_Clasificacion;
            }
            set
            {
                _temporal_Material_Clasificacion = value;
                UpdateFieldValue("Temporal_Material_Clasificacion_", value);
            }
        }

        public string Materal_Descripcion
        {
            get
            {
                return _materal_Descripcion;
            }
            set
            {
                _materal_Descripcion = value;
                UpdateFieldValue("Materal_Descripcion", value);
            }
        }

        public int? MRP_Type_Id
        {
            get
            {
                return _mRP_Type_Id;
            }
            set
            {
                _mRP_Type_Id = value;
                UpdateFieldValue("MRP_Type_Id", value);
            }
        }

        public string Clasificacion
        {
            get
            {
                return _clasificacion;
            }
            set
            {
                _clasificacion = value;
                UpdateFieldValue("Clasificacion", value);
            }
        }

        public int? Mensaje_Sistema_Id
        {
            get
            {
                return _mensaje_Sistema_Id;
            }
            set
            {
                _mensaje_Sistema_Id = value;
                UpdateFieldValue("Mensaje_Sistema_Id", value);
            }
        }

        public string Mensaje_Sistema
        {
            get
            {
                return _mensaje_Sistema;
            }
            set
            {
                _mensaje_Sistema = value;
                UpdateFieldValue("Mensaje_Sistema", value);
            }
        }

        public int? Carga
        {
            get
            {
                return _carga;
            }
            set
            {
                _carga = value;
                UpdateFieldValue("Carga", value);
            }
        }

        public DateTime? Fecha_Procesamiento
        {
            get
            {
                return _fecha_Procesamiento;
            }
            set
            {
                _fecha_Procesamiento = value;
                UpdateFieldValue("Fecha_Procesamiento", value);
            }
        }

        public System.Guid? Transaccion_Procesamiento
        {
            get
            {
                return _transaccion_Procesamiento;
            }
            set
            {
                _transaccion_Procesamiento = value;
                UpdateFieldValue("Transaccion_Procesamiento", value);
            }
        }

        public string Creado_Por
        {
            get
            {
                return _creado_Por;
            }
            set
            {
                _creado_Por = value;
                UpdateFieldValue("Creado_Por", value);
            }
        }

        public DateTime? Fecha_Creacion
        {
            get
            {
                return _fecha_Creacion;
            }
            set
            {
                _fecha_Creacion = value;
                UpdateFieldValue("Fecha_Creacion", value);
            }
        }

        public DateTime? Fecha_Ultima_Actualizacion
        {
            get
            {
                return _fecha_Ultima_Actualizacion;
            }
            set
            {
                _fecha_Ultima_Actualizacion = value;
                UpdateFieldValue("Fecha_Ultima_Actualizacion", value);
            }
        }

        public int? Estatus_Registro_Id
        {
            get
            {
                return _estatus_Registro_Id;
            }
            set
            {
                _estatus_Registro_Id = value;
                UpdateFieldValue("Estatus_Registro_Id", value);
            }
        }

        public string Estatus_Registro
        {
            get
            {
                return _estatus_Registro;
            }
            set
            {
                _estatus_Registro = value;
                UpdateFieldValue("Estatus_Registro", value);
            }
        }

        public string Actualizado_Por
        {
            get
            {
                return _actualizado_Por;
            }
            set
            {
                _actualizado_Por = value;
                UpdateFieldValue("Actualizado_Por", value);
            }
        }

        public int? Estatus_Procesamiento_Id
        {
            get
            {
                return _estatus_Procesamiento_Id;
            }
            set
            {
                _estatus_Procesamiento_Id = value;
                UpdateFieldValue("Estatus_Procesamiento_Id", value);
            }
        }

        public string Estatus_Procesamiento
        {
            get
            {
                return _estatus_Procesamiento;
            }
            set
            {
                _estatus_Procesamiento = value;
                UpdateFieldValue("Estatus_Procesamiento", value);
            }
        }

        public FieldValue this[Temporal_Material_ClasificacionDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
