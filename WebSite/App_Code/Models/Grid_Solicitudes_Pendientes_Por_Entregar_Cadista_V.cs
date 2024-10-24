using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VDataField
    {

        Solicitud_Id,

        Orden_Produccion_Id,

        Orden_Produccion_Detalle_Id,

        Ruta_Optima_Id,

        Material_Surtido_Id,

        Solicitado_Por_Id,

        Solicitado_Por,

        Material_Solicitado_Id,

        Material_Solicitado,

        Material_Descripcion_Solicitado,

        Cantidad_Solicitado,

        Unidad_Material_Solicitado_Id,

        Unidad_Material_Solicitado,

        Fecha_Solicitud,

        Estatus_Solicitud_Id,

        Estatus_Solicitud,

        Fecha_Surtido,

        Bitacora_Captura_Sap_Id,

        Material_Surtido,

        Cantidad_Surtido,

        Unidad_Material_Surtido,

        Fecha_Captura,

        Estatus_Captura_Sap,

        Tipo_Operacion_Sap,

        Etiqueta_Id,

        Numero_Etiqueta,

        Estatus_Etiqueta,

        Fecha_Impresion,

        Usuario_Cadista_Id,

        Usuario_Cadista,

        Usuario_Surtidor_Id,

        Usuario_Surtidor,

        Area_Entrega_Id,

        Area_Entrega,

        Fecha_Entrega_Cadista,

        Entregado_Por_Usuario_Cadista_Id,

        Entregado_Por_Usuario_Cadista,
    }

    public partial class Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _bitacora_Captura_Sap_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Captura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Captura_Sap;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Operacion_Sap;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiqueta_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Etiqueta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Etiqueta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Impresion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Cadista_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Cadista;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Surtidor_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Surtidor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Entrega_Cadista;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _entregado_Por_Usuario_Cadista_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _entregado_Por_Usuario_Cadista;

        public Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VModel()
        {
        }

        public Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VModel(BusinessRules r) :
                base(r)
        {
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

        public long? Orden_Produccion_Detalle_Id
        {
            get
            {
                return _orden_Produccion_Detalle_Id;
            }
            set
            {
                _orden_Produccion_Detalle_Id = value;
                UpdateFieldValue("Orden_Produccion_Detalle_Id", value);
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

        public long? Material_Surtido_Id
        {
            get
            {
                return _material_Surtido_Id;
            }
            set
            {
                _material_Surtido_Id = value;
                UpdateFieldValue("Material_Surtido_Id", value);
            }
        }

        public System.Guid? Solicitado_Por_Id
        {
            get
            {
                return _solicitado_Por_Id;
            }
            set
            {
                _solicitado_Por_Id = value;
                UpdateFieldValue("Solicitado_Por_Id", value);
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

        public string Material_Solicitado
        {
            get
            {
                return _material_Solicitado;
            }
            set
            {
                _material_Solicitado = value;
                UpdateFieldValue("Material_Solicitado", value);
            }
        }

        public string Material_Descripcion_Solicitado
        {
            get
            {
                return _material_Descripcion_Solicitado;
            }
            set
            {
                _material_Descripcion_Solicitado = value;
                UpdateFieldValue("Material_Descripcion_Solicitado", value);
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

        public DateTime? Fecha_Solicitud
        {
            get
            {
                return _fecha_Solicitud;
            }
            set
            {
                _fecha_Solicitud = value;
                UpdateFieldValue("Fecha_Solicitud", value);
            }
        }

        public int? Estatus_Solicitud_Id
        {
            get
            {
                return _estatus_Solicitud_Id;
            }
            set
            {
                _estatus_Solicitud_Id = value;
                UpdateFieldValue("Estatus_Solicitud_Id", value);
            }
        }

        public string Estatus_Solicitud
        {
            get
            {
                return _estatus_Solicitud;
            }
            set
            {
                _estatus_Solicitud = value;
                UpdateFieldValue("Estatus_Solicitud", value);
            }
        }

        public DateTime? Fecha_Surtido
        {
            get
            {
                return _fecha_Surtido;
            }
            set
            {
                _fecha_Surtido = value;
                UpdateFieldValue("Fecha_Surtido", value);
            }
        }

        public long? Bitacora_Captura_Sap_Id
        {
            get
            {
                return _bitacora_Captura_Sap_Id;
            }
            set
            {
                _bitacora_Captura_Sap_Id = value;
                UpdateFieldValue("Bitacora_Captura_Sap_Id", value);
            }
        }

        public string Material_Surtido
        {
            get
            {
                return _material_Surtido;
            }
            set
            {
                _material_Surtido = value;
                UpdateFieldValue("Material_Surtido", value);
            }
        }

        public decimal? Cantidad_Surtido
        {
            get
            {
                return _cantidad_Surtido;
            }
            set
            {
                _cantidad_Surtido = value;
                UpdateFieldValue("Cantidad_Surtido", value);
            }
        }

        public string Unidad_Material_Surtido
        {
            get
            {
                return _unidad_Material_Surtido;
            }
            set
            {
                _unidad_Material_Surtido = value;
                UpdateFieldValue("Unidad_Material_Surtido", value);
            }
        }

        public DateTime? Fecha_Captura
        {
            get
            {
                return _fecha_Captura;
            }
            set
            {
                _fecha_Captura = value;
                UpdateFieldValue("Fecha_Captura", value);
            }
        }

        public string Estatus_Captura_Sap
        {
            get
            {
                return _estatus_Captura_Sap;
            }
            set
            {
                _estatus_Captura_Sap = value;
                UpdateFieldValue("Estatus_Captura_Sap", value);
            }
        }

        public string Tipo_Operacion_Sap
        {
            get
            {
                return _tipo_Operacion_Sap;
            }
            set
            {
                _tipo_Operacion_Sap = value;
                UpdateFieldValue("Tipo_Operacion_Sap", value);
            }
        }

        public int? Etiqueta_Id
        {
            get
            {
                return _etiqueta_Id;
            }
            set
            {
                _etiqueta_Id = value;
                UpdateFieldValue("Etiqueta_Id", value);
            }
        }

        public int? Numero_Etiqueta
        {
            get
            {
                return _numero_Etiqueta;
            }
            set
            {
                _numero_Etiqueta = value;
                UpdateFieldValue("Numero_Etiqueta", value);
            }
        }

        public string Estatus_Etiqueta
        {
            get
            {
                return _estatus_Etiqueta;
            }
            set
            {
                _estatus_Etiqueta = value;
                UpdateFieldValue("Estatus_Etiqueta", value);
            }
        }

        public DateTime? Fecha_Impresion
        {
            get
            {
                return _fecha_Impresion;
            }
            set
            {
                _fecha_Impresion = value;
                UpdateFieldValue("Fecha_Impresion", value);
            }
        }

        public System.Guid? Usuario_Cadista_Id
        {
            get
            {
                return _usuario_Cadista_Id;
            }
            set
            {
                _usuario_Cadista_Id = value;
                UpdateFieldValue("Usuario_Cadista_Id", value);
            }
        }

        public string Usuario_Cadista
        {
            get
            {
                return _usuario_Cadista;
            }
            set
            {
                _usuario_Cadista = value;
                UpdateFieldValue("Usuario_Cadista", value);
            }
        }

        public System.Guid? Usuario_Surtidor_Id
        {
            get
            {
                return _usuario_Surtidor_Id;
            }
            set
            {
                _usuario_Surtidor_Id = value;
                UpdateFieldValue("Usuario_Surtidor_Id", value);
            }
        }

        public string Usuario_Surtidor
        {
            get
            {
                return _usuario_Surtidor;
            }
            set
            {
                _usuario_Surtidor = value;
                UpdateFieldValue("Usuario_Surtidor", value);
            }
        }

        public int? Area_Entrega_Id
        {
            get
            {
                return _area_Entrega_Id;
            }
            set
            {
                _area_Entrega_Id = value;
                UpdateFieldValue("Area_Entrega_Id", value);
            }
        }

        public string Area_Entrega
        {
            get
            {
                return _area_Entrega;
            }
            set
            {
                _area_Entrega = value;
                UpdateFieldValue("Area_Entrega", value);
            }
        }

        public DateTime? Fecha_Entrega_Cadista
        {
            get
            {
                return _fecha_Entrega_Cadista;
            }
            set
            {
                _fecha_Entrega_Cadista = value;
                UpdateFieldValue("Fecha_Entrega_Cadista", value);
            }
        }

        public System.Guid? Entregado_Por_Usuario_Cadista_Id
        {
            get
            {
                return _entregado_Por_Usuario_Cadista_Id;
            }
            set
            {
                _entregado_Por_Usuario_Cadista_Id = value;
                UpdateFieldValue("Entregado_Por_Usuario_Cadista_Id", value);
            }
        }

        public string Entregado_Por_Usuario_Cadista
        {
            get
            {
                return _entregado_Por_Usuario_Cadista;
            }
            set
            {
                _entregado_Por_Usuario_Cadista = value;
                UpdateFieldValue("Entregado_Por_Usuario_Cadista", value);
            }
        }

        public FieldValue this[Grid_Solicitudes_Pendientes_Por_Entregar_Cadista_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
