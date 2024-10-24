using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Solicitud1DataField
    {

        Solicitud_Id,

        Area_Servicio_Id,

        Area_Servicio,

        Unidad_Material_Entregado_Id,

        Unidad_Material_Entregado,

        Fecha_Solicitud,

        Fecha_Entrega,

        Estatus_Solicitud_Id,

        Estatus_Solicitud,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Entregado_Por_Id,

        Entregado_Por,

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        Orden_Produccion_Detalle_Id,

        Orden_Produccion_Detalle,

        Solicitado_Por_Id,

        Solicitado_Por,

        Familia_Id,

        Familia_Clave,

        Producto_Id,

        Producto_Clave,

        Material_Solicitado_Id,

        Material,

        Unidad_Material_Solicitado_Id,

        Unidad_Material_Solicitado,

        Cantidad_Solicitado,

        Cantidad_Entregado,

        Solicitud_Transaccion_Id,

        Area_Entrega_Id,

        Area_Entrega,

        Tipo_Solicitud_Id,

        Tipo_Solicitud,

        Categoria_Solicitud_Id,

        Categoria_Solicitud,

        Es_De_Kanban,

        Es_Otro,

        Es_Interplanta,

        Es_Solicitud_Rollo,

        Es_Urgencia_Compra,

        Motivo_Solicitud,

        Registrado_Desde_Id,

        Registrado_Desde,

        Categoria_Id,

        Categoria_Clave,

        Motivo_Solicitud_Id,

        Motivo_Solicitud_Motivo_Solicitud,

        Motivo_Solicitud_Es_Otro,

        Solicitud_Numero_Orden_Produccion,

        Fecha_Captura,

        Capturado_Por_Id,

        Capturado_Por,

        Fecha_Surtido,

        Motivo_Cancelacion_Id,

        Motivo_Cancelacion,

        Captura_Transaccion_Id,

        Subtipo_Solicitud_Id,

        Subtipo_Solicitud,

        SubtipoSolic_Es_Solic_Mat_Normal,

        SubtipoSolic_Es_Solic_Mat_Pickeo_Incan,

        Dato_Solicitud_Urgencia_Compras,
    }

    public partial class Solicitud1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Servicio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Solicitud;

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
        private System.Guid? _entregado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _entregado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _familia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _solicitud_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _categoria_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_De_Kanban;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Otro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Interplanta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Solicitud_Rollo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Urgencia_Compra;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _registrado_Desde_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registrado_Desde;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _categoria_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Solicitud_Motivo_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _motivo_Solicitud_Es_Otro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Captura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _capturado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _capturado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Cancelacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _captura_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _subtipo_Solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _subtipo_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _subtipoSolic_Es_Solic_Mat_Normal;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _subtipoSolic_Es_Solic_Mat_Pickeo_Incan;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dato_Solicitud_Urgencia_Compras;

        public Solicitud1Model()
        {
        }

        public Solicitud1Model(BusinessRules r) :
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

        public int? Area_Servicio_Id
        {
            get
            {
                return _area_Servicio_Id;
            }
            set
            {
                _area_Servicio_Id = value;
                UpdateFieldValue("Area_Servicio_Id", value);
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

        public DateTime? Fecha_Entrega
        {
            get
            {
                return _fecha_Entrega;
            }
            set
            {
                _fecha_Entrega = value;
                UpdateFieldValue("Fecha_Entrega", value);
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

        public System.Guid? Entregado_Por_Id
        {
            get
            {
                return _entregado_Por_Id;
            }
            set
            {
                _entregado_Por_Id = value;
                UpdateFieldValue("Entregado_Por_Id", value);
            }
        }

        public string Entregado_Por
        {
            get
            {
                return _entregado_Por;
            }
            set
            {
                _entregado_Por = value;
                UpdateFieldValue("Entregado_Por", value);
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

        public long? Numero_Orden_Produccion
        {
            get
            {
                return _numero_Orden_Produccion;
            }
            set
            {
                _numero_Orden_Produccion = value;
                UpdateFieldValue("Numero_Orden_Produccion", value);
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

        public long? Orden_Produccion_Detalle
        {
            get
            {
                return _orden_Produccion_Detalle;
            }
            set
            {
                _orden_Produccion_Detalle = value;
                UpdateFieldValue("Orden_Produccion_Detalle", value);
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

        public int? Familia_Id
        {
            get
            {
                return _familia_Id;
            }
            set
            {
                _familia_Id = value;
                UpdateFieldValue("Familia_Id", value);
            }
        }

        public string Familia_Clave
        {
            get
            {
                return _familia_Clave;
            }
            set
            {
                _familia_Clave = value;
                UpdateFieldValue("Familia_Clave", value);
            }
        }

        public int? Producto_Id
        {
            get
            {
                return _producto_Id;
            }
            set
            {
                _producto_Id = value;
                UpdateFieldValue("Producto_Id", value);
            }
        }

        public string Producto_Clave
        {
            get
            {
                return _producto_Clave;
            }
            set
            {
                _producto_Clave = value;
                UpdateFieldValue("Producto_Clave", value);
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

        public System.Guid? Solicitud_Transaccion_Id
        {
            get
            {
                return _solicitud_Transaccion_Id;
            }
            set
            {
                _solicitud_Transaccion_Id = value;
                UpdateFieldValue("Solicitud_Transaccion_Id", value);
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

        public int? Tipo_Solicitud_Id
        {
            get
            {
                return _tipo_Solicitud_Id;
            }
            set
            {
                _tipo_Solicitud_Id = value;
                UpdateFieldValue("Tipo_Solicitud_Id", value);
            }
        }

        public string Tipo_Solicitud
        {
            get
            {
                return _tipo_Solicitud;
            }
            set
            {
                _tipo_Solicitud = value;
                UpdateFieldValue("Tipo_Solicitud", value);
            }
        }

        public int? Categoria_Solicitud_Id
        {
            get
            {
                return _categoria_Solicitud_Id;
            }
            set
            {
                _categoria_Solicitud_Id = value;
                UpdateFieldValue("Categoria_Solicitud_Id", value);
            }
        }

        public string Categoria_Solicitud
        {
            get
            {
                return _categoria_Solicitud;
            }
            set
            {
                _categoria_Solicitud = value;
                UpdateFieldValue("Categoria_Solicitud", value);
            }
        }

        public bool? Es_De_Kanban
        {
            get
            {
                return _es_De_Kanban;
            }
            set
            {
                _es_De_Kanban = value;
                UpdateFieldValue("Es_De_Kanban", value);
            }
        }

        public bool? Es_Otro
        {
            get
            {
                return _es_Otro;
            }
            set
            {
                _es_Otro = value;
                UpdateFieldValue("Es_Otro", value);
            }
        }

        public bool? Es_Interplanta
        {
            get
            {
                return _es_Interplanta;
            }
            set
            {
                _es_Interplanta = value;
                UpdateFieldValue("Es_Interplanta", value);
            }
        }

        public bool? Es_Solicitud_Rollo
        {
            get
            {
                return _es_Solicitud_Rollo;
            }
            set
            {
                _es_Solicitud_Rollo = value;
                UpdateFieldValue("Es_Solicitud_Rollo", value);
            }
        }

        public bool? Es_Urgencia_Compra
        {
            get
            {
                return _es_Urgencia_Compra;
            }
            set
            {
                _es_Urgencia_Compra = value;
                UpdateFieldValue("Es_Urgencia_Compra", value);
            }
        }

        public string Motivo_Solicitud
        {
            get
            {
                return _motivo_Solicitud;
            }
            set
            {
                _motivo_Solicitud = value;
                UpdateFieldValue("Motivo_Solicitud", value);
            }
        }

        public short? Registrado_Desde_Id
        {
            get
            {
                return _registrado_Desde_Id;
            }
            set
            {
                _registrado_Desde_Id = value;
                UpdateFieldValue("Registrado_Desde_Id", value);
            }
        }

        public string Registrado_Desde
        {
            get
            {
                return _registrado_Desde;
            }
            set
            {
                _registrado_Desde = value;
                UpdateFieldValue("Registrado_Desde", value);
            }
        }

        public int? Categoria_Id
        {
            get
            {
                return _categoria_Id;
            }
            set
            {
                _categoria_Id = value;
                UpdateFieldValue("Categoria_Id", value);
            }
        }

        public string Categoria_Clave
        {
            get
            {
                return _categoria_Clave;
            }
            set
            {
                _categoria_Clave = value;
                UpdateFieldValue("Categoria_Clave", value);
            }
        }

        public int? Motivo_Solicitud_Id
        {
            get
            {
                return _motivo_Solicitud_Id;
            }
            set
            {
                _motivo_Solicitud_Id = value;
                UpdateFieldValue("Motivo_Solicitud_Id", value);
            }
        }

        public string Motivo_Solicitud_Motivo_Solicitud
        {
            get
            {
                return _motivo_Solicitud_Motivo_Solicitud;
            }
            set
            {
                _motivo_Solicitud_Motivo_Solicitud = value;
                UpdateFieldValue("Motivo_Solicitud_Motivo_Solicitud", value);
            }
        }

        public bool? Motivo_Solicitud_Es_Otro
        {
            get
            {
                return _motivo_Solicitud_Es_Otro;
            }
            set
            {
                _motivo_Solicitud_Es_Otro = value;
                UpdateFieldValue("Motivo_Solicitud_Es_Otro", value);
            }
        }

        public long? Solicitud_Numero_Orden_Produccion
        {
            get
            {
                return _solicitud_Numero_Orden_Produccion;
            }
            set
            {
                _solicitud_Numero_Orden_Produccion = value;
                UpdateFieldValue("Solicitud_Numero_Orden_Produccion", value);
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

        public System.Guid? Capturado_Por_Id
        {
            get
            {
                return _capturado_Por_Id;
            }
            set
            {
                _capturado_Por_Id = value;
                UpdateFieldValue("Capturado_Por_Id", value);
            }
        }

        public string Capturado_Por
        {
            get
            {
                return _capturado_Por;
            }
            set
            {
                _capturado_Por = value;
                UpdateFieldValue("Capturado_Por", value);
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

        public int? Motivo_Cancelacion_Id
        {
            get
            {
                return _motivo_Cancelacion_Id;
            }
            set
            {
                _motivo_Cancelacion_Id = value;
                UpdateFieldValue("Motivo_Cancelacion_Id", value);
            }
        }

        public string Motivo_Cancelacion
        {
            get
            {
                return _motivo_Cancelacion;
            }
            set
            {
                _motivo_Cancelacion = value;
                UpdateFieldValue("Motivo_Cancelacion", value);
            }
        }

        public string Captura_Transaccion_Id
        {
            get
            {
                return _captura_Transaccion_Id;
            }
            set
            {
                _captura_Transaccion_Id = value;
                UpdateFieldValue("Captura_Transaccion_Id", value);
            }
        }

        public int? Subtipo_Solicitud_Id
        {
            get
            {
                return _subtipo_Solicitud_Id;
            }
            set
            {
                _subtipo_Solicitud_Id = value;
                UpdateFieldValue("Subtipo_Solicitud_Id", value);
            }
        }

        public string Subtipo_Solicitud
        {
            get
            {
                return _subtipo_Solicitud;
            }
            set
            {
                _subtipo_Solicitud = value;
                UpdateFieldValue("Subtipo_Solicitud", value);
            }
        }

        public bool? SubtipoSolic_Es_Solic_Mat_Normal
        {
            get
            {
                return _subtipoSolic_Es_Solic_Mat_Normal;
            }
            set
            {
                _subtipoSolic_Es_Solic_Mat_Normal = value;
                UpdateFieldValue("SubtipoSolic_Es_Solic_Mat_Normal", value);
            }
        }

        public bool? SubtipoSolic_Es_Solic_Mat_Pickeo_Incan
        {
            get
            {
                return _subtipoSolic_Es_Solic_Mat_Pickeo_Incan;
            }
            set
            {
                _subtipoSolic_Es_Solic_Mat_Pickeo_Incan = value;
                UpdateFieldValue("SubtipoSolic_Es_Solic_Mat_Pickeo_Incan", value);
            }
        }

        public string Dato_Solicitud_Urgencia_Compras
        {
            get
            {
                return _dato_Solicitud_Urgencia_Compras;
            }
            set
            {
                _dato_Solicitud_Urgencia_Compras = value;
                UpdateFieldValue("Dato_Solicitud_Urgencia_Compras", value);
            }
        }

        public FieldValue this[Solicitud1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
