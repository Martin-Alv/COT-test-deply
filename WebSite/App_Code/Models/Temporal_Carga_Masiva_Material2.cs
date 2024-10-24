using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Temporal_Carga_Masiva_Material2DataField
    {

        Temporal_Carga_Masiva_Material_Id,

        Descripcion,

        Tipo_Material,

        Clase_Material,

        Material_Empaque,

        Estatus_Procesamiento_Id,

        Estatus_Procesamiento,

        Mensaje_Sistema_Id,

        Mensaje_Sistema,

        Error,

        Carga,

        Fecha_Procesamiento,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Creado_Por_Id,
    }

    public partial class Temporal_Carga_Masiva_Material2Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_Carga_Masiva_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clase_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Empaque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _error;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _carga;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        public Temporal_Carga_Masiva_Material2Model()
        {
        }

        public Temporal_Carga_Masiva_Material2Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Temporal_Carga_Masiva_Material_Id
        {
            get
            {
                return _temporal_Carga_Masiva_Material_Id;
            }
            set
            {
                _temporal_Carga_Masiva_Material_Id = value;
                UpdateFieldValue("Temporal_Carga_Masiva_Material_Id", value);
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
                UpdateFieldValue("Descripcion", value);
            }
        }

        public string Tipo_Material
        {
            get
            {
                return _tipo_Material;
            }
            set
            {
                _tipo_Material = value;
                UpdateFieldValue("Tipo_Material", value);
            }
        }

        public string Clase_Material
        {
            get
            {
                return _clase_Material;
            }
            set
            {
                _clase_Material = value;
                UpdateFieldValue("Clase_Material", value);
            }
        }

        public string Material_Empaque
        {
            get
            {
                return _material_Empaque;
            }
            set
            {
                _material_Empaque = value;
                UpdateFieldValue("Material_Empaque", value);
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

        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
                UpdateFieldValue("Error", value);
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

        public System.Guid? Creado_Por_Id
        {
            get
            {
                return _creado_Por_Id;
            }
            set
            {
                _creado_Por_Id = value;
                UpdateFieldValue("Creado_Por_Id", value);
            }
        }

        public FieldValue this[Temporal_Carga_Masiva_Material2DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
