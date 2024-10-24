using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Consulta_Surtido_Material_VDataField
    {

        Ruta_Optima_Id,

        Estatus_Ruta_Optima,

        Material_Solicitado_Id,

        Cantidad_Solicitado,

        Cantidad_Entregado,

        Unidad_Material_Solicitado_Id,

        Unidad_Material_Entregado_Id,

        Unidad_Material_Entregado,

        Ubicacion_Almacenamiento_Id,

        Ubicacion_Almacenamiento,

        Estatus_Surtido_Id,

        Estatus_Surtido,

        Ubicacion_Almacenamiento_De_Surtido_Id,

        Ubicacion_Almacenamiento_De_Surtido,

        Surtido_Por_Id,

        Fecha_Ultima_Actualizacion,

        Material,

        Material_Descripcion,

        Unidad_Material_Solicitado,

        Usuario_Sistema,

        Tmp_Ruta_Optima_Transaccion_Id,

        Material_Ubicacion_Almacenamiento_De_Surtido_Id,

        Area_Servicio,

        Solicitado_Por,

        Folio_Solicitud,

        Material_QR,

        Cantidad_Entregado_QR,

        Ubicacion_Origen_QR,

        Ubicacion_Destino_QR,

        Clave_Tipo_Ubicacion,
    }

    public partial class Grid_Consulta_Surtido_Material_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_De_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento_De_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _surtido_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _tmp_Ruta_Optima_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Almacenamiento_De_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Servicio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _folio_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cantidad_Entregado_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Origen_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Destino_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _clave_Tipo_Ubicacion;

        public Grid_Consulta_Surtido_Material_VModel()
        {
        }

        public Grid_Consulta_Surtido_Material_VModel(BusinessRules r) :
                base(r)
        {
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

        public string Estatus_Ruta_Optima
        {
            get
            {
                return _estatus_Ruta_Optima;
            }
            set
            {
                _estatus_Ruta_Optima = value;
                UpdateFieldValue("Estatus_Ruta_Optima", value);
            }
        }

        public long? Material_Solicitado_Id
        {
            get
            {
                return _material_Solicitado_Id;
            }
            set
            {
                _material_Solicitado_Id = value;
                UpdateFieldValue("Material_Solicitado_Id", value);
            }
        }

        public decimal? Cantidad_Solicitado
        {
            get
            {
                return _cantidad_Solicitado;
            }
            set
            {
                _cantidad_Solicitado = value;
                UpdateFieldValue("Cantidad_Solicitado", value);
            }
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

        public int? Unidad_Material_Solicitado_Id
        {
            get
            {
                return _unidad_Material_Solicitado_Id;
            }
            set
            {
                _unidad_Material_Solicitado_Id = value;
                UpdateFieldValue("Unidad_Material_Solicitado_Id", value);
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

        public string Unidad_Material_Entregado
        {
            get
            {
                return _unidad_Material_Entregado;
            }
            set
            {
                _unidad_Material_Entregado = value;
                UpdateFieldValue("Unidad_Material_Entregado", value);
            }
        }

        public int? Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _ubicacion_Almacenamiento_Id;
            }
            set
            {
                _ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_Id", value);
            }
        }

        public string Ubicacion_Almacenamiento
        {
            get
            {
                return _ubicacion_Almacenamiento;
            }
            set
            {
                _ubicacion_Almacenamiento = value;
                UpdateFieldValue("Ubicacion_Almacenamiento", value);
            }
        }

        public int? Estatus_Surtido_Id
        {
            get
            {
                return _estatus_Surtido_Id;
            }
            set
            {
                _estatus_Surtido_Id = value;
                UpdateFieldValue("Estatus_Surtido_Id", value);
            }
        }

        public string Estatus_Surtido
        {
            get
            {
                return _estatus_Surtido;
            }
            set
            {
                _estatus_Surtido = value;
                UpdateFieldValue("Estatus_Surtido", value);
            }
        }

        public int? Ubicacion_Almacenamiento_De_Surtido_Id
        {
            get
            {
                return _ubicacion_Almacenamiento_De_Surtido_Id;
            }
            set
            {
                _ubicacion_Almacenamiento_De_Surtido_Id = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_De_Surtido_Id", value);
            }
        }

        public string Ubicacion_Almacenamiento_De_Surtido
        {
            get
            {
                return _ubicacion_Almacenamiento_De_Surtido;
            }
            set
            {
                _ubicacion_Almacenamiento_De_Surtido = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_De_Surtido", value);
            }
        }

        public System.Guid? Surtido_Por_Id
        {
            get
            {
                return _surtido_Por_Id;
            }
            set
            {
                _surtido_Por_Id = value;
                UpdateFieldValue("Surtido_Por_Id", value);
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

        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                _material = value;
                UpdateFieldValue("Material", value);
            }
        }

        public string Material_Descripcion
        {
            get
            {
                return _material_Descripcion;
            }
            set
            {
                _material_Descripcion = value;
                UpdateFieldValue("Material_Descripcion", value);
            }
        }

        public string Unidad_Material_Solicitado
        {
            get
            {
                return _unidad_Material_Solicitado;
            }
            set
            {
                _unidad_Material_Solicitado = value;
                UpdateFieldValue("Unidad_Material_Solicitado", value);
            }
        }

        public string Usuario_Sistema
        {
            get
            {
                return _usuario_Sistema;
            }
            set
            {
                _usuario_Sistema = value;
                UpdateFieldValue("Usuario_Sistema", value);
            }
        }

        public System.Guid? Tmp_Ruta_Optima_Transaccion_Id
        {
            get
            {
                return _tmp_Ruta_Optima_Transaccion_Id;
            }
            set
            {
                _tmp_Ruta_Optima_Transaccion_Id = value;
                UpdateFieldValue("Tmp_Ruta_Optima_Transaccion_Id", value);
            }
        }

        public long? Material_Ubicacion_Almacenamiento_De_Surtido_Id
        {
            get
            {
                return _material_Ubicacion_Almacenamiento_De_Surtido_Id;
            }
            set
            {
                _material_Ubicacion_Almacenamiento_De_Surtido_Id = value;
                UpdateFieldValue("Material_Ubicacion_Almacenamiento_De_Surtido_Id", value);
            }
        }

        public string Area_Servicio
        {
            get
            {
                return _area_Servicio;
            }
            set
            {
                _area_Servicio = value;
                UpdateFieldValue("Area_Servicio", value);
            }
        }

        public string Solicitado_Por
        {
            get
            {
                return _solicitado_Por;
            }
            set
            {
                _solicitado_Por = value;
                UpdateFieldValue("Solicitado_Por", value);
            }
        }

        public long? Folio_Solicitud
        {
            get
            {
                return _folio_Solicitud;
            }
            set
            {
                _folio_Solicitud = value;
                UpdateFieldValue("Folio_Solicitud", value);
            }
        }

        public string Material_QR
        {
            get
            {
                return _material_QR;
            }
            set
            {
                _material_QR = value;
                UpdateFieldValue("Material_QR", value);
            }
        }

        public string Cantidad_Entregado_QR
        {
            get
            {
                return _cantidad_Entregado_QR;
            }
            set
            {
                _cantidad_Entregado_QR = value;
                UpdateFieldValue("Cantidad_Entregado_QR", value);
            }
        }

        public string Ubicacion_Origen_QR
        {
            get
            {
                return _ubicacion_Origen_QR;
            }
            set
            {
                _ubicacion_Origen_QR = value;
                UpdateFieldValue("Ubicacion_Origen_QR", value);
            }
        }

        public string Ubicacion_Destino_QR
        {
            get
            {
                return _ubicacion_Destino_QR;
            }
            set
            {
                _ubicacion_Destino_QR = value;
                UpdateFieldValue("Ubicacion_Destino_QR", value);
            }
        }

        public int? Clave_Tipo_Ubicacion
        {
            get
            {
                return _clave_Tipo_Ubicacion;
            }
            set
            {
                _clave_Tipo_Ubicacion = value;
                UpdateFieldValue("Clave_Tipo_Ubicacion", value);
            }
        }

        public FieldValue this[Grid_Consulta_Surtido_Material_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
