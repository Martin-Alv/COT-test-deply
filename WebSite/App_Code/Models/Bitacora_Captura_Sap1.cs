using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Bitacora_Captura_Sap1DataField
    {

        Bitacora_Captura_Sap_Id,

        Ruta_Optima_Id,

        Ruta_Optima,

        Material_Surtido_Id,

        Material_Surtido,

        Material_Id,

        Material_Material,

        Material_Descripcion,

        Material,

        Cantidad_Entregado,

        Tipo_Surtido_Id,

        Es_Captura_Local,

        Es_Captura_Remota,

        Tipo_Ubicacion_Id,

        Clave_Tipo_Ubicacion,

        Ubicacion_Almacenamiento_Id,

        Ubicacion_Almacenamiento,

        Estatus_Captura_Sap_Id,

        Estatus_Captura_Sap,

        Usuario_Surtidor_Id,

        Usuario_Sistema,

        Nombre_Equipo_Llamada,

        Nombre_Equipo_Captura,

        Mensaje_Sistema_Id,

        Mensaje_Sistema,

        Error,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Creado_Por,

        Fecha_Creacion,

        Fecha_Captura,

        Ubicacion_Origen,

        Ubicacion_Destino,

        Capturado_Por_Id,

        Capturado_Por,

        Tipo_Operacion_Sap_Id,

        Tipo_Operacion_Sap,

        Movimiento_Ruta_Optima_Id,

        Es_Captura_De_Surtido,

        Es_Devolucion_De_Material,

        Es_Transferencia_De_Material,

        Transferencia_Destino_Id,

        Devolucion_Material_Id,

        Devolucion_Material_Descripcion,

        Devolucion_Origen_Id,

        Transferencia_Destino_Ubicacion_Almacenamiento,

        Transferencia_Origen_Ubicacion_Almacenamiento,

        Transferencia_Material_Id,

        Tranferencia_Material,

        Transferencia_Origen_Id,

        Devolucion_Destino_Id,

        Devolucion_Destino_Ubicacion_Almacenamiento,

        Devolucion_Material,

        Numero_Grupo_Ruta_Optima,

        Tipo_Movimiento_Id,

        Tipo_Movimiento,

        Devolucion_Origen_Clave_Tipo_Ubicacion,

        Devolucion_Origen_Descripcion_Tipo_Ubicacion,

        Cantidad_Devuelto,

        Cantidad_Transferido,

        Es_Captura_Manual_Con_Pdf,

        Movimiento_Descto_Stock_En_Piso,

        Es_Paso_Uno_Transferencia,

        Solicitud_Id,
    }

    public partial class Bitacora_Captura_Sap1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _bitacora_Captura_Sap_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _material_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Captura_Local;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Captura_Remota;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Ubicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _clave_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Captura_Sap_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Captura_Sap;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Surtidor_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Equipo_Llamada;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Equipo_Captura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _error;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Captura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Origen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Destino;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _capturado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _capturado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Operacion_Sap_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Operacion_Sap;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Captura_De_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Devolucion_De_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Transferencia_De_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _devolucion_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Destino_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Origen_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _transferencia_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tranferencia_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Destino_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Origen_Clave_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Origen_Descripcion_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Devuelto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Transferido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Captura_Manual_Con_Pdf;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _movimiento_Descto_Stock_En_Piso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Paso_Uno_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;

        public Bitacora_Captura_Sap1Model()
        {
        }

        public Bitacora_Captura_Sap1Model(BusinessRules r) :
                base(r)
        {
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

        public int? Ruta_Optima
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

        public int? Material_Surtido
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

        public string Material_Material
        {
            get
            {
                return _material_Material;
            }
            set
            {
                _material_Material = value;
                UpdateFieldValue("Material_Material", value);
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

        public int? Tipo_Surtido_Id
        {
            get
            {
                return _tipo_Surtido_Id;
            }
            set
            {
                _tipo_Surtido_Id = value;
                UpdateFieldValue("Tipo_Surtido_Id", value);
            }
        }

        public bool? Es_Captura_Local
        {
            get
            {
                return _es_Captura_Local;
            }
            set
            {
                _es_Captura_Local = value;
                UpdateFieldValue("Es_Captura_Local", value);
            }
        }

        public bool? Es_Captura_Remota
        {
            get
            {
                return _es_Captura_Remota;
            }
            set
            {
                _es_Captura_Remota = value;
                UpdateFieldValue("Es_Captura_Remota", value);
            }
        }

        public int? Tipo_Ubicacion_Id
        {
            get
            {
                return _tipo_Ubicacion_Id;
            }
            set
            {
                _tipo_Ubicacion_Id = value;
                UpdateFieldValue("Tipo_Ubicacion_Id", value);
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

        public int? Estatus_Captura_Sap_Id
        {
            get
            {
                return _estatus_Captura_Sap_Id;
            }
            set
            {
                _estatus_Captura_Sap_Id = value;
                UpdateFieldValue("Estatus_Captura_Sap_Id", value);
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

        public string Nombre_Equipo_Llamada
        {
            get
            {
                return _nombre_Equipo_Llamada;
            }
            set
            {
                _nombre_Equipo_Llamada = value;
                UpdateFieldValue("Nombre_Equipo_Llamada", value);
            }
        }

        public string Nombre_Equipo_Captura
        {
            get
            {
                return _nombre_Equipo_Captura;
            }
            set
            {
                _nombre_Equipo_Captura = value;
                UpdateFieldValue("Nombre_Equipo_Captura", value);
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

        public string Ubicacion_Origen
        {
            get
            {
                return _ubicacion_Origen;
            }
            set
            {
                _ubicacion_Origen = value;
                UpdateFieldValue("Ubicacion_Origen", value);
            }
        }

        public int? Ubicacion_Destino
        {
            get
            {
                return _ubicacion_Destino;
            }
            set
            {
                _ubicacion_Destino = value;
                UpdateFieldValue("Ubicacion_Destino", value);
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

        public int? Tipo_Operacion_Sap_Id
        {
            get
            {
                return _tipo_Operacion_Sap_Id;
            }
            set
            {
                _tipo_Operacion_Sap_Id = value;
                UpdateFieldValue("Tipo_Operacion_Sap_Id", value);
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

        public bool? Es_Captura_De_Surtido
        {
            get
            {
                return _es_Captura_De_Surtido;
            }
            set
            {
                _es_Captura_De_Surtido = value;
                UpdateFieldValue("Es_Captura_De_Surtido", value);
            }
        }

        public bool? Es_Devolucion_De_Material
        {
            get
            {
                return _es_Devolucion_De_Material;
            }
            set
            {
                _es_Devolucion_De_Material = value;
                UpdateFieldValue("Es_Devolucion_De_Material", value);
            }
        }

        public bool? Es_Transferencia_De_Material
        {
            get
            {
                return _es_Transferencia_De_Material;
            }
            set
            {
                _es_Transferencia_De_Material = value;
                UpdateFieldValue("Es_Transferencia_De_Material", value);
            }
        }

        public int? Transferencia_Destino_Id
        {
            get
            {
                return _transferencia_Destino_Id;
            }
            set
            {
                _transferencia_Destino_Id = value;
                UpdateFieldValue("Transferencia_Destino_Id", value);
            }
        }

        public long? Devolucion_Material_Id
        {
            get
            {
                return _devolucion_Material_Id;
            }
            set
            {
                _devolucion_Material_Id = value;
                UpdateFieldValue("Devolucion_Material_Id", value);
            }
        }

        public string Devolucion_Material_Descripcion
        {
            get
            {
                return _devolucion_Material_Descripcion;
            }
            set
            {
                _devolucion_Material_Descripcion = value;
                UpdateFieldValue("Devolucion_Material_Descripcion", value);
            }
        }

        public int? Devolucion_Origen_Id
        {
            get
            {
                return _devolucion_Origen_Id;
            }
            set
            {
                _devolucion_Origen_Id = value;
                UpdateFieldValue("Devolucion_Origen_Id", value);
            }
        }

        public string Transferencia_Destino_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_Destino_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_Destino_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_Destino_Ubicacion_Almacenamiento", value);
            }
        }

        public string Transferencia_Origen_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_Origen_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_Origen_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_Origen_Ubicacion_Almacenamiento", value);
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

        public string Tranferencia_Material
        {
            get
            {
                return _tranferencia_Material;
            }
            set
            {
                _tranferencia_Material = value;
                UpdateFieldValue("Tranferencia_Material", value);
            }
        }

        public int? Transferencia_Origen_Id
        {
            get
            {
                return _transferencia_Origen_Id;
            }
            set
            {
                _transferencia_Origen_Id = value;
                UpdateFieldValue("Transferencia_Origen_Id", value);
            }
        }

        public int? Devolucion_Destino_Id
        {
            get
            {
                return _devolucion_Destino_Id;
            }
            set
            {
                _devolucion_Destino_Id = value;
                UpdateFieldValue("Devolucion_Destino_Id", value);
            }
        }

        public string Devolucion_Destino_Ubicacion_Almacenamiento
        {
            get
            {
                return _devolucion_Destino_Ubicacion_Almacenamiento;
            }
            set
            {
                _devolucion_Destino_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Devolucion_Destino_Ubicacion_Almacenamiento", value);
            }
        }

        public string Devolucion_Material
        {
            get
            {
                return _devolucion_Material;
            }
            set
            {
                _devolucion_Material = value;
                UpdateFieldValue("Devolucion_Material", value);
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

        public int? Devolucion_Origen_Clave_Tipo_Ubicacion
        {
            get
            {
                return _devolucion_Origen_Clave_Tipo_Ubicacion;
            }
            set
            {
                _devolucion_Origen_Clave_Tipo_Ubicacion = value;
                UpdateFieldValue("Devolucion_Origen_Clave_Tipo_Ubicacion", value);
            }
        }

        public string Devolucion_Origen_Descripcion_Tipo_Ubicacion
        {
            get
            {
                return _devolucion_Origen_Descripcion_Tipo_Ubicacion;
            }
            set
            {
                _devolucion_Origen_Descripcion_Tipo_Ubicacion = value;
                UpdateFieldValue("Devolucion_Origen_Descripcion_Tipo_Ubicacion", value);
            }
        }

        public decimal? Cantidad_Devuelto
        {
            get
            {
                return _cantidad_Devuelto;
            }
            set
            {
                _cantidad_Devuelto = value;
                UpdateFieldValue("Cantidad_Devuelto", value);
            }
        }

        public decimal? Cantidad_Transferido
        {
            get
            {
                return _cantidad_Transferido;
            }
            set
            {
                _cantidad_Transferido = value;
                UpdateFieldValue("Cantidad_Transferido", value);
            }
        }

        public bool? Es_Captura_Manual_Con_Pdf
        {
            get
            {
                return _es_Captura_Manual_Con_Pdf;
            }
            set
            {
                _es_Captura_Manual_Con_Pdf = value;
                UpdateFieldValue("Es_Captura_Manual_Con_Pdf", value);
            }
        }

        public bool? Movimiento_Descto_Stock_En_Piso
        {
            get
            {
                return _movimiento_Descto_Stock_En_Piso;
            }
            set
            {
                _movimiento_Descto_Stock_En_Piso = value;
                UpdateFieldValue("Movimiento_Descto_Stock_En_Piso", value);
            }
        }

        public bool? Es_Paso_Uno_Transferencia
        {
            get
            {
                return _es_Paso_Uno_Transferencia;
            }
            set
            {
                _es_Paso_Uno_Transferencia = value;
                UpdateFieldValue("Es_Paso_Uno_Transferencia", value);
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

        public FieldValue this[Bitacora_Captura_Sap1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
