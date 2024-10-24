using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Movimiento2DataField
    {

        Movimiento_Id,

        Area_Servicio_Id,

        Area_Servicio,

        Tipo_Movimiento_Id,

        Tipo_Movimiento,

        Tipo_Movimiento_Es_Solicitud_Devolucion,

        Tipo_Movimiento_Es_Solicitud_Transferencia,

        Estatus_Movimiento_Id,

        Estatus_Movimiento,

        Estatus_Movimiento_Aplica_A_Devolucion,

        Estatus_Movimiento_Significa_Pendiente,

        Estatus_Movimiento_Aplica_A_Transferencia,

        Fecha_Solicitud_Movimiento,

        Area_Entrega_Id,

        Area_Entrega,

        Devolucion_Ubicacion_Origen_Id,

        Devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion,

        Devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion,

        Devolucion_Ubicacion_Destino_Id,

        Devolucion_Ubicacion_Destino_Area_Entrega,

        Estatus_Devolucion_Id,

        Estatus_Devolucion,

        Fecha_Devolucion,

        Devolucion_Fecha_Cancelacion,

        Transferencia_Ubicacion_Origen_Id,

        Transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento,

        Transferencia_Ubicacion_Destino_Id,

        Transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento,

        Fecha_Transferencia,

        Transferencia_Fecha_Cancelacion,

        Estatus_Transferencia_Id,

        Estatus_Transferencia,

        Movimiento_Ruta_Optima_Id,

        Numero_Grupo_Ruta_Optima,

        Movimiento_Solicitado_Por,

        Movimiento_Iniciado_Por,

        Movimiento_Realizado_Por,

        Movimiento_Cancelado_Por,

        Movimiento_Capturado_Por,

        Es_Capturado,

        Fecha_Captura_Movimiento,

        Captura_Transaccion_Id,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Movimiento_Folio,

        Movimiento_Solicitado_Por_Id,

        Movimiento_Iniciado_Por_Id,

        Movimiento_Realizado_Por_Id,

        Movimiento_Cancelado_Por_Id,

        Movimiento_Capturado_Por_Id,

        Movimiento_Motivo_Cancelacion_Id,

        Movimiento_Motivo_Cancelacion,
    }

    public partial class Movimiento2Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Servicio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tipo_Movimiento_Es_Solicitud_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tipo_Movimiento_Es_Solicitud_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _estatus_Movimiento_Aplica_A_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _estatus_Movimiento_Significa_Pendiente;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _estatus_Movimiento_Aplica_A_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Ubicacion_Destino_Area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Devolucion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _devolucion_Fecha_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Ubicacion_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Ubicacion_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _transferencia_Fecha_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Transferencia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Iniciado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Realizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Cancelado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Capturado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Capturado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Captura_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _captura_Transaccion_Id;

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
        private long? _movimiento_Folio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Solicitado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Iniciado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Realizado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Cancelado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Capturado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _movimiento_Motivo_Cancelacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Motivo_Cancelacion;

        public Movimiento2Model()
        {
        }

        public Movimiento2Model(BusinessRules r) :
                base(r)
        {
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

        public int? Estatus_Movimiento_Id
        {
            get
            {
                return _estatus_Movimiento_Id;
            }
            set
            {
                _estatus_Movimiento_Id = value;
                UpdateFieldValue("Estatus_Movimiento_Id", value);
            }
        }

        public string Estatus_Movimiento
        {
            get
            {
                return _estatus_Movimiento;
            }
            set
            {
                _estatus_Movimiento = value;
                UpdateFieldValue("Estatus_Movimiento", value);
            }
        }

        public bool? Estatus_Movimiento_Aplica_A_Devolucion
        {
            get
            {
                return _estatus_Movimiento_Aplica_A_Devolucion;
            }
            set
            {
                _estatus_Movimiento_Aplica_A_Devolucion = value;
                UpdateFieldValue("Estatus_Movimiento_Aplica_A_Devolucion", value);
            }
        }

        public bool? Estatus_Movimiento_Significa_Pendiente
        {
            get
            {
                return _estatus_Movimiento_Significa_Pendiente;
            }
            set
            {
                _estatus_Movimiento_Significa_Pendiente = value;
                UpdateFieldValue("Estatus_Movimiento_Significa_Pendiente", value);
            }
        }

        public bool? Estatus_Movimiento_Aplica_A_Transferencia
        {
            get
            {
                return _estatus_Movimiento_Aplica_A_Transferencia;
            }
            set
            {
                _estatus_Movimiento_Aplica_A_Transferencia = value;
                UpdateFieldValue("Estatus_Movimiento_Aplica_A_Transferencia", value);
            }
        }

        public DateTime? Fecha_Solicitud_Movimiento
        {
            get
            {
                return _fecha_Solicitud_Movimiento;
            }
            set
            {
                _fecha_Solicitud_Movimiento = value;
                UpdateFieldValue("Fecha_Solicitud_Movimiento", value);
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

        public int? Devolucion_Ubicacion_Origen_Id
        {
            get
            {
                return _devolucion_Ubicacion_Origen_Id;
            }
            set
            {
                _devolucion_Ubicacion_Origen_Id = value;
                UpdateFieldValue("Devolucion_Ubicacion_Origen_Id", value);
            }
        }

        public int? Devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion
        {
            get
            {
                return _devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion;
            }
            set
            {
                _devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion = value;
                UpdateFieldValue("Devolucion_Ubicacion_Origen_Clave_Tipo_Ubicacion", value);
            }
        }

        public string Devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion
        {
            get
            {
                return _devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion;
            }
            set
            {
                _devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion = value;
                UpdateFieldValue("Devolucion_Ubicacion_Origen_Descripcion_Tipo_Ubicacion", value);
            }
        }

        public int? Devolucion_Ubicacion_Destino_Id
        {
            get
            {
                return _devolucion_Ubicacion_Destino_Id;
            }
            set
            {
                _devolucion_Ubicacion_Destino_Id = value;
                UpdateFieldValue("Devolucion_Ubicacion_Destino_Id", value);
            }
        }

        public string Devolucion_Ubicacion_Destino_Area_Entrega
        {
            get
            {
                return _devolucion_Ubicacion_Destino_Area_Entrega;
            }
            set
            {
                _devolucion_Ubicacion_Destino_Area_Entrega = value;
                UpdateFieldValue("Devolucion_Ubicacion_Destino_Area_Entrega", value);
            }
        }

        public int? Estatus_Devolucion_Id
        {
            get
            {
                return _estatus_Devolucion_Id;
            }
            set
            {
                _estatus_Devolucion_Id = value;
                UpdateFieldValue("Estatus_Devolucion_Id", value);
            }
        }

        public string Estatus_Devolucion
        {
            get
            {
                return _estatus_Devolucion;
            }
            set
            {
                _estatus_Devolucion = value;
                UpdateFieldValue("Estatus_Devolucion", value);
            }
        }

        public DateTime? Fecha_Devolucion
        {
            get
            {
                return _fecha_Devolucion;
            }
            set
            {
                _fecha_Devolucion = value;
                UpdateFieldValue("Fecha_Devolucion", value);
            }
        }

        public DateTime? Devolucion_Fecha_Cancelacion
        {
            get
            {
                return _devolucion_Fecha_Cancelacion;
            }
            set
            {
                _devolucion_Fecha_Cancelacion = value;
                UpdateFieldValue("Devolucion_Fecha_Cancelacion", value);
            }
        }

        public int? Transferencia_Ubicacion_Origen_Id
        {
            get
            {
                return _transferencia_Ubicacion_Origen_Id;
            }
            set
            {
                _transferencia_Ubicacion_Origen_Id = value;
                UpdateFieldValue("Transferencia_Ubicacion_Origen_Id", value);
            }
        }

        public string Transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_Ubicacion_Origen_Ubicacion_Almacenamiento", value);
            }
        }

        public int? Transferencia_Ubicacion_Destino_Id
        {
            get
            {
                return _transferencia_Ubicacion_Destino_Id;
            }
            set
            {
                _transferencia_Ubicacion_Destino_Id = value;
                UpdateFieldValue("Transferencia_Ubicacion_Destino_Id", value);
            }
        }

        public string Transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_Ubicacion_Destino_Ubicacion_Almacenamiento", value);
            }
        }

        public DateTime? Fecha_Transferencia
        {
            get
            {
                return _fecha_Transferencia;
            }
            set
            {
                _fecha_Transferencia = value;
                UpdateFieldValue("Fecha_Transferencia", value);
            }
        }

        public DateTime? Transferencia_Fecha_Cancelacion
        {
            get
            {
                return _transferencia_Fecha_Cancelacion;
            }
            set
            {
                _transferencia_Fecha_Cancelacion = value;
                UpdateFieldValue("Transferencia_Fecha_Cancelacion", value);
            }
        }

        public int? Estatus_Transferencia_Id
        {
            get
            {
                return _estatus_Transferencia_Id;
            }
            set
            {
                _estatus_Transferencia_Id = value;
                UpdateFieldValue("Estatus_Transferencia_Id", value);
            }
        }

        public string Estatus_Transferencia
        {
            get
            {
                return _estatus_Transferencia;
            }
            set
            {
                _estatus_Transferencia = value;
                UpdateFieldValue("Estatus_Transferencia", value);
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

        public string Movimiento_Solicitado_Por
        {
            get
            {
                return _movimiento_Solicitado_Por;
            }
            set
            {
                _movimiento_Solicitado_Por = value;
                UpdateFieldValue("Movimiento_Solicitado_Por", value);
            }
        }

        public string Movimiento_Iniciado_Por
        {
            get
            {
                return _movimiento_Iniciado_Por;
            }
            set
            {
                _movimiento_Iniciado_Por = value;
                UpdateFieldValue("Movimiento_Iniciado_Por", value);
            }
        }

        public string Movimiento_Realizado_Por
        {
            get
            {
                return _movimiento_Realizado_Por;
            }
            set
            {
                _movimiento_Realizado_Por = value;
                UpdateFieldValue("Movimiento_Realizado_Por", value);
            }
        }

        public string Movimiento_Cancelado_Por
        {
            get
            {
                return _movimiento_Cancelado_Por;
            }
            set
            {
                _movimiento_Cancelado_Por = value;
                UpdateFieldValue("Movimiento_Cancelado_Por", value);
            }
        }

        public string Movimiento_Capturado_Por
        {
            get
            {
                return _movimiento_Capturado_Por;
            }
            set
            {
                _movimiento_Capturado_Por = value;
                UpdateFieldValue("Movimiento_Capturado_Por", value);
            }
        }

        public bool? Es_Capturado
        {
            get
            {
                return _es_Capturado;
            }
            set
            {
                _es_Capturado = value;
                UpdateFieldValue("Es_Capturado", value);
            }
        }

        public DateTime? Fecha_Captura_Movimiento
        {
            get
            {
                return _fecha_Captura_Movimiento;
            }
            set
            {
                _fecha_Captura_Movimiento = value;
                UpdateFieldValue("Fecha_Captura_Movimiento", value);
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

        public long? Movimiento_Folio
        {
            get
            {
                return _movimiento_Folio;
            }
            set
            {
                _movimiento_Folio = value;
                UpdateFieldValue("Movimiento_Folio", value);
            }
        }

        public System.Guid? Movimiento_Solicitado_Por_Id
        {
            get
            {
                return _movimiento_Solicitado_Por_Id;
            }
            set
            {
                _movimiento_Solicitado_Por_Id = value;
                UpdateFieldValue("Movimiento_Solicitado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Iniciado_Por_Id
        {
            get
            {
                return _movimiento_Iniciado_Por_Id;
            }
            set
            {
                _movimiento_Iniciado_Por_Id = value;
                UpdateFieldValue("Movimiento_Iniciado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Realizado_Por_Id
        {
            get
            {
                return _movimiento_Realizado_Por_Id;
            }
            set
            {
                _movimiento_Realizado_Por_Id = value;
                UpdateFieldValue("Movimiento_Realizado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Cancelado_Por_Id
        {
            get
            {
                return _movimiento_Cancelado_Por_Id;
            }
            set
            {
                _movimiento_Cancelado_Por_Id = value;
                UpdateFieldValue("Movimiento_Cancelado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Capturado_Por_Id
        {
            get
            {
                return _movimiento_Capturado_Por_Id;
            }
            set
            {
                _movimiento_Capturado_Por_Id = value;
                UpdateFieldValue("Movimiento_Capturado_Por_Id", value);
            }
        }

        public int? Movimiento_Motivo_Cancelacion_Id
        {
            get
            {
                return _movimiento_Motivo_Cancelacion_Id;
            }
            set
            {
                _movimiento_Motivo_Cancelacion_Id = value;
                UpdateFieldValue("Movimiento_Motivo_Cancelacion_Id", value);
            }
        }

        public string Movimiento_Motivo_Cancelacion
        {
            get
            {
                return _movimiento_Motivo_Cancelacion;
            }
            set
            {
                _movimiento_Motivo_Cancelacion = value;
                UpdateFieldValue("Movimiento_Motivo_Cancelacion", value);
            }
        }

        public FieldValue this[Movimiento2DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
