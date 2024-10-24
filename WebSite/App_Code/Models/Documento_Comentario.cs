using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Documento_ComentarioDataField
    {

        Documento_Comentario_Id,

        Orden_Produccion_Id,

        Orden_Produccion,

        Orden_Produccion_Detalle_Id,

        Orden_Produccion_Detalle,

        Producto_Id,

        Producto,

        Material_Id,

        Material,

        Solicitud_Id,

        Solicitud,

        Comentarios,

        PictureFileName,

        PictureContentType,

        PictureLength,

        Es_Comentario,

        Tipo_Comentario_Id,

        Tipo_Comentario,

        Es_Imagen,

        Tipo_Archivo_Id,

        Tipo_Archivo,

        Es_Motivo_Cancelacion,

        Motivo_Cancelacion_Id,

        Motivo_Cancelacion,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Registrado_Desde_Id,

        Registrado_Desde,

        Ruta_Optima_Id,

        Ruta_Optima,

        Material_Surtido_Id,

        Material_Surtido,

        Tipo_Movimiento_Id,

        Tipo_Movimiento,

        Tipo_Movimiento_Es_Solicitud_Devolucion,

        Tipo_Movimiento_Es_Solicitud_Transferencia,

        Motivo_Movimiento_Id,

        Motivo_Movimiento,

        Motivo_Movimiento_Aplica_A_Devolucion,

        Motivo_Movimiento_Aplica_A_Transferencia,

        Movimiento_Ruta_Optima_Id,

        Numero_Grupo_Ruta_Optima,

        Cantidad_Solicitado,

        Cantidad_Entregado,

        Unidad_Material_Entregado_Id,

        Ubicacion_Almacenamiento_De_Surtido_Id,

        Solicitud_Material,

        Tipo_Operacion_Id,

        Movimiento,
    }

    public partial class Documento_ComentarioModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _documento_Comentario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comentarios;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureFileName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pictureContentType;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pictureLength;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Comentario;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Comentario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Comentario;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Imagen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Archivo_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Archivo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Motivo_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Cancelacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Cancelacion;

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
        private short? _registrado_Desde_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registrado_Desde;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tipo_Movimiento_Es_Solicitud_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tipo_Movimiento_Es_Solicitud_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _motivo_Movimiento_Aplica_A_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _motivo_Movimiento_Aplica_A_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_De_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitud_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Operacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento;

        public Documento_ComentarioModel()
        {
        }

        public Documento_ComentarioModel(BusinessRules r) :
                base(r)
        {
        }

        public int? Documento_Comentario_Id
        {
            get
            {
                return _documento_Comentario_Id;
            }
            set
            {
                _documento_Comentario_Id = value;
                UpdateFieldValue("Documento_Comentario_Id", value);
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

        public long? Orden_Produccion
        {
            get
            {
                return _orden_Produccion;
            }
            set
            {
                _orden_Produccion = value;
                UpdateFieldValue("Orden_Produccion", value);
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

        public string Producto
        {
            get
            {
                return _producto;
            }
            set
            {
                _producto = value;
                UpdateFieldValue("Producto", value);
            }
        }

        public long? Material_Id
        {
            get
            {
                return _material_Id;
            }
            set
            {
                _material_Id = value;
                UpdateFieldValue("Material_Id", value);
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

        public long? Solicitud
        {
            get
            {
                return _solicitud;
            }
            set
            {
                _solicitud = value;
                UpdateFieldValue("Solicitud", value);
            }
        }

        public string Comentarios
        {
            get
            {
                return _comentarios;
            }
            set
            {
                _comentarios = value;
                UpdateFieldValue("Comentarios", value);
            }
        }

        public string PictureFileName
        {
            get
            {
                return _pictureFileName;
            }
            set
            {
                _pictureFileName = value;
                UpdateFieldValue("PictureFileName", value);
            }
        }

        public string PictureContentType
        {
            get
            {
                return _pictureContentType;
            }
            set
            {
                _pictureContentType = value;
                UpdateFieldValue("PictureContentType", value);
            }
        }

        public int? PictureLength
        {
            get
            {
                return _pictureLength;
            }
            set
            {
                _pictureLength = value;
                UpdateFieldValue("PictureLength", value);
            }
        }

        public bool? Es_Comentario
        {
            get
            {
                return _es_Comentario;
            }
            set
            {
                _es_Comentario = value;
                UpdateFieldValue("Es_Comentario", value);
            }
        }

        public int? Tipo_Comentario_Id
        {
            get
            {
                return _tipo_Comentario_Id;
            }
            set
            {
                _tipo_Comentario_Id = value;
                UpdateFieldValue("Tipo_Comentario_Id", value);
            }
        }

        public string Tipo_Comentario
        {
            get
            {
                return _tipo_Comentario;
            }
            set
            {
                _tipo_Comentario = value;
                UpdateFieldValue("Tipo_Comentario", value);
            }
        }

        public bool? Es_Imagen
        {
            get
            {
                return _es_Imagen;
            }
            set
            {
                _es_Imagen = value;
                UpdateFieldValue("Es_Imagen", value);
            }
        }

        public int? Tipo_Archivo_Id
        {
            get
            {
                return _tipo_Archivo_Id;
            }
            set
            {
                _tipo_Archivo_Id = value;
                UpdateFieldValue("Tipo_Archivo_Id", value);
            }
        }

        public string Tipo_Archivo
        {
            get
            {
                return _tipo_Archivo;
            }
            set
            {
                _tipo_Archivo = value;
                UpdateFieldValue("Tipo_Archivo", value);
            }
        }

        public bool? Es_Motivo_Cancelacion
        {
            get
            {
                return _es_Motivo_Cancelacion;
            }
            set
            {
                _es_Motivo_Cancelacion = value;
                UpdateFieldValue("Es_Motivo_Cancelacion", value);
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

        public long? Ruta_Optima
        {
            get
            {
                return _ruta_Optima;
            }
            set
            {
                _ruta_Optima = value;
                UpdateFieldValue("Ruta_Optima", value);
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

        public long? Material_Surtido
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

        public string Tipo_Movimiento
        {
            get
            {
                return _tipo_Movimiento;
            }
            set
            {
                _tipo_Movimiento = value;
                UpdateFieldValue("Tipo_Movimiento", value);
            }
        }

        public bool? Tipo_Movimiento_Es_Solicitud_Devolucion
        {
            get
            {
                return _tipo_Movimiento_Es_Solicitud_Devolucion;
            }
            set
            {
                _tipo_Movimiento_Es_Solicitud_Devolucion = value;
                UpdateFieldValue("Tipo_Movimiento_Es_Solicitud_Devolucion", value);
            }
        }

        public bool? Tipo_Movimiento_Es_Solicitud_Transferencia
        {
            get
            {
                return _tipo_Movimiento_Es_Solicitud_Transferencia;
            }
            set
            {
                _tipo_Movimiento_Es_Solicitud_Transferencia = value;
                UpdateFieldValue("Tipo_Movimiento_Es_Solicitud_Transferencia", value);
            }
        }

        public int? Motivo_Movimiento_Id
        {
            get
            {
                return _motivo_Movimiento_Id;
            }
            set
            {
                _motivo_Movimiento_Id = value;
                UpdateFieldValue("Motivo_Movimiento_Id", value);
            }
        }

        public string Motivo_Movimiento
        {
            get
            {
                return _motivo_Movimiento;
            }
            set
            {
                _motivo_Movimiento = value;
                UpdateFieldValue("Motivo_Movimiento", value);
            }
        }

        public bool? Motivo_Movimiento_Aplica_A_Devolucion
        {
            get
            {
                return _motivo_Movimiento_Aplica_A_Devolucion;
            }
            set
            {
                _motivo_Movimiento_Aplica_A_Devolucion = value;
                UpdateFieldValue("Motivo_Movimiento_Aplica_A_Devolucion", value);
            }
        }

        public bool? Motivo_Movimiento_Aplica_A_Transferencia
        {
            get
            {
                return _motivo_Movimiento_Aplica_A_Transferencia;
            }
            set
            {
                _motivo_Movimiento_Aplica_A_Transferencia = value;
                UpdateFieldValue("Motivo_Movimiento_Aplica_A_Transferencia", value);
            }
        }

        public long? Movimiento_Ruta_Optima_Id
        {
            get
            {
                return _movimiento_Ruta_Optima_Id;
            }
            set
            {
                _movimiento_Ruta_Optima_Id = value;
                UpdateFieldValue("Movimiento_Ruta_Optima_Id", value);
            }
        }

        public decimal? Numero_Grupo_Ruta_Optima
        {
            get
            {
                return _numero_Grupo_Ruta_Optima;
            }
            set
            {
                _numero_Grupo_Ruta_Optima = value;
                UpdateFieldValue("Numero_Grupo_Ruta_Optima", value);
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

        public string Solicitud_Material
        {
            get
            {
                return _solicitud_Material;
            }
            set
            {
                _solicitud_Material = value;
                UpdateFieldValue("Solicitud_Material", value);
            }
        }

        public int? Tipo_Operacion_Id
        {
            get
            {
                return _tipo_Operacion_Id;
            }
            set
            {
                _tipo_Operacion_Id = value;
                UpdateFieldValue("Tipo_Operacion_Id", value);
            }
        }

        public string Movimiento
        {
            get
            {
                return _movimiento;
            }
            set
            {
                _movimiento = value;
                UpdateFieldValue("Movimiento", value);
            }
        }

        public FieldValue this[Documento_ComentarioDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
