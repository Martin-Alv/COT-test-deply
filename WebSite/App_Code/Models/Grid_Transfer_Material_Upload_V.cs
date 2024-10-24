using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Transfer_Material_Upload_VDataField
    {

        Movimiento_Material_Upload_Id,

        Movimiento_Id,

        Movimiento_Detalle_Id,

        Tipo_Movimiento_Id,

        Transferencia_Material_Id,

        Transferencia_Material,

        Transferencia_Material_Descripcion,

        Transferencia_Cantidad,

        Last_Transferencia_Material,

        Last_Transferencia_Material_Descripcion,

        Last_Transferencia_Cantidad,

        Es_Actualizado,

        Estatus_Procesamiento_Id,

        Estatus_Procesamiento,

        Mensaje_Sistema_Id,

        Mensaje_Sistema,

        Mensaje_Amigable_Usuario,

        Estatus_Registro_Id,

        Estatus_Registro,

        Creado_Por_Id,

        Creado_Por,

        Actualizado_Por_Id,

        Actualizado_Por,

        Fecha_Creacion,

        Fecha_Ultima_Actualizacion,

        Transferencia_Material_Ubicacion_Origen,

        Transferencia_Material_Ubicacion_Destino,

        Last_Transferencia_Material_Ubicacion_Origen,

        Last_Transferencia_Material_Ubicacion_Destino,
    }

    public partial class Grid_Transfer_Material_Upload_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Material_Upload_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _transferencia_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _transferencia_Cantidad;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _last_Transferencia_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _last_Transferencia_Material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _last_Transferencia_Cantidad;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Actualizado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Amigable_Usuario;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _actualizado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material_Ubicacion_Origen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material_Ubicacion_Destino;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _last_Transferencia_Material_Ubicacion_Origen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _last_Transferencia_Material_Ubicacion_Destino;

        public Grid_Transfer_Material_Upload_VModel()
        {
        }

        public Grid_Transfer_Material_Upload_VModel(BusinessRules r) :
                base(r)
        {
        }

        public long? Movimiento_Material_Upload_Id
        {
            get
            {
                return _movimiento_Material_Upload_Id;
            }
            set
            {
                _movimiento_Material_Upload_Id = value;
                UpdateFieldValue("Movimiento_Material_Upload_Id", value);
            }
        }

        public long? Movimiento_Id
        {
            get
            {
                return _movimiento_Id;
            }
            set
            {
                _movimiento_Id = value;
                UpdateFieldValue("Movimiento_Id", value);
            }
        }

        public long? Movimiento_Detalle_Id
        {
            get
            {
                return _movimiento_Detalle_Id;
            }
            set
            {
                _movimiento_Detalle_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Id", value);
            }
        }

        public int? Tipo_Movimiento_Id
        {
            get
            {
                return _tipo_Movimiento_Id;
            }
            set
            {
                _tipo_Movimiento_Id = value;
                UpdateFieldValue("Tipo_Movimiento_Id", value);
            }
        }

        public long? Transferencia_Material_Id
        {
            get
            {
                return _transferencia_Material_Id;
            }
            set
            {
                _transferencia_Material_Id = value;
                UpdateFieldValue("Transferencia_Material_Id", value);
            }
        }

        public string Transferencia_Material
        {
            get
            {
                return _transferencia_Material;
            }
            set
            {
                _transferencia_Material = value;
                UpdateFieldValue("Transferencia_Material", value);
            }
        }

        public string Transferencia_Material_Descripcion
        {
            get
            {
                return _transferencia_Material_Descripcion;
            }
            set
            {
                _transferencia_Material_Descripcion = value;
                UpdateFieldValue("Transferencia_Material_Descripcion", value);
            }
        }

        public decimal? Transferencia_Cantidad
        {
            get
            {
                return _transferencia_Cantidad;
            }
            set
            {
                _transferencia_Cantidad = value;
                UpdateFieldValue("Transferencia_Cantidad", value);
            }
        }

        public string Last_Transferencia_Material
        {
            get
            {
                return _last_Transferencia_Material;
            }
            set
            {
                _last_Transferencia_Material = value;
                UpdateFieldValue("Last_Transferencia_Material", value);
            }
        }

        public string Last_Transferencia_Material_Descripcion
        {
            get
            {
                return _last_Transferencia_Material_Descripcion;
            }
            set
            {
                _last_Transferencia_Material_Descripcion = value;
                UpdateFieldValue("Last_Transferencia_Material_Descripcion", value);
            }
        }

        public decimal? Last_Transferencia_Cantidad
        {
            get
            {
                return _last_Transferencia_Cantidad;
            }
            set
            {
                _last_Transferencia_Cantidad = value;
                UpdateFieldValue("Last_Transferencia_Cantidad", value);
            }
        }

        public bool? Es_Actualizado
        {
            get
            {
                return _es_Actualizado;
            }
            set
            {
                _es_Actualizado = value;
                UpdateFieldValue("Es_Actualizado", value);
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

        public string Mensaje_Amigable_Usuario
        {
            get
            {
                return _mensaje_Amigable_Usuario;
            }
            set
            {
                _mensaje_Amigable_Usuario = value;
                UpdateFieldValue("Mensaje_Amigable_Usuario", value);
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

        public System.Guid? Actualizado_Por_Id
        {
            get
            {
                return _actualizado_Por_Id;
            }
            set
            {
                _actualizado_Por_Id = value;
                UpdateFieldValue("Actualizado_Por_Id", value);
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

        public string Transferencia_Material_Ubicacion_Origen
        {
            get
            {
                return _transferencia_Material_Ubicacion_Origen;
            }
            set
            {
                _transferencia_Material_Ubicacion_Origen = value;
                UpdateFieldValue("Transferencia_Material_Ubicacion_Origen", value);
            }
        }

        public string Transferencia_Material_Ubicacion_Destino
        {
            get
            {
                return _transferencia_Material_Ubicacion_Destino;
            }
            set
            {
                _transferencia_Material_Ubicacion_Destino = value;
                UpdateFieldValue("Transferencia_Material_Ubicacion_Destino", value);
            }
        }

        public string Last_Transferencia_Material_Ubicacion_Origen
        {
            get
            {
                return _last_Transferencia_Material_Ubicacion_Origen;
            }
            set
            {
                _last_Transferencia_Material_Ubicacion_Origen = value;
                UpdateFieldValue("Last_Transferencia_Material_Ubicacion_Origen", value);
            }
        }

        public string Last_Transferencia_Material_Ubicacion_Destino
        {
            get
            {
                return _last_Transferencia_Material_Ubicacion_Destino;
            }
            set
            {
                _last_Transferencia_Material_Ubicacion_Destino = value;
                UpdateFieldValue("Last_Transferencia_Material_Ubicacion_Destino", value);
            }
        }

        public FieldValue this[Grid_Transfer_Material_Upload_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
