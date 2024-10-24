using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Movimiento_Detalle2DataField
    {

        Movimiento_Detalle_Id,

        Movimiento_Id,

        Movimiento_Folio,

        Devolucion_Material_Id,

        Dev_Material,

        Dev_Material_Descripcion,

        Devolucion_Ubicacion_Origen_Id,

        Clave_Tipo_Ubicacion,

        Descripcion_Tipo_Ubicacion,

        Devolucion_Ubicacion_Destino_Id,

        Area_Entrega,

        Estatus_Devolucion_Id,

        Estatus_Devolucion,

        Cantidad_A_Devolver,

        Cantidad_Devuelto,

        Unidad_Material_A_Devolver_Id,

        Unidad_Material_A_Devolver,

        Unidad_Material_Devuelto_Id,

        Unidad_Material_Devuelto,

        Fecha_Devolucion,

        Devolucion_Fecha_Cancelacion,

        Transferencia_Material_Id,

        Transferencia_Material,

        Transferencia_Material_Descripcion,

        Transferencia_Ubicacion_Origen_Id,

        Transferencia_Ubicacion_Origen,

        Transferencia_Ubicacion_Destino_Id,

        Transferencia_Ubicacion_Destino,

        Unidad_Material_A_Transferir_Id,

        Unidad_Material_A_Transferir,

        Unidad_Material_Transferido_Id,

        Unidad_Material_Transferido,

        Fecha_Transferencia,

        Transferencia_Fecha_Cancelacion,

        Estatus_Transferencia_Id,

        Estatus_Transferencia,

        Motivo_Movimiento_Id,

        Motivo_Movimiento,

        Fecha_Solicitud_Movimiento,

        Estatus_Movimiento_Id,

        Estatus_Movimiento,

        Estatus_Movimiento_Aplica_A_Devolucion,

        Estatus_Movimiento_Significa_Pendiente,

        Estatus_Movimiento_Aplica_A_Transferencia,

        Movimiento_Det_Solicitado_Por,

        Movimiento_Det_Iniciado_Por,

        Movimiento_Det_Realizado_Por,

        Movimiento_Det_Cancelado_Por,

        Movimiento_Det_Capturado_Por,

        Es_Capturado,

        Fecha_Captura_Movimiento_Detalle,

        Captura_Transaccion_Id,

        Movimiento_Ruta_Optima_Id,

        Numero_Grupo_Ruta_Optima,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Movimiento_Detalle_Solicitado_Por_Id,

        Movimiento_Detalle_Iniciado_Por_Id,

        Movimiento_Detalle_Realizado_Por_Id,

        Movimiento_Detalle_Cancelado_Por_Id,

        Movimiento_Detalle_Capturado_Por_Id,

        Movimiento_Motivo_Cancelacion_Id,

        Movimiento_Motivo_Cancelacion,

        Cantidad_A_Transferir,

        Cantidad_Transferido,

        Material_Es_Kanban,

        Area_Entrega_Id,

        Area_Entrega_Area_Entrega,

        Registrado_Desde_Id,

        Registrado_Desde,
    }

    public partial class Movimiento_Detalle2Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Folio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _devolucion_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dev_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dev_Material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _clave_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Devolucion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_A_Devolver;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Devuelto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_A_Devolver_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_A_Devolver;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Devuelto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Devuelto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Devolucion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _devolucion_Fecha_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _transferencia_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Ubicacion_Origen_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Ubicacion_Origen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Ubicacion_Destino_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Ubicacion_Destino;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_A_Transferir_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_A_Transferir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Transferido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Transferido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _transferencia_Fecha_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Transferencia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Transferencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _motivo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _motivo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud_Movimiento;

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
        private string _movimiento_Det_Solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Det_Iniciado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Det_Realizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Det_Cancelado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Det_Capturado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Capturado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Captura_Movimiento_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _captura_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

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
        private System.Guid? _movimiento_Detalle_Solicitado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Detalle_Iniciado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Detalle_Realizado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Detalle_Cancelado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Detalle_Capturado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _movimiento_Motivo_Cancelacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Motivo_Cancelacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_A_Transferir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Transferido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _material_Es_Kanban;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega_Area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _registrado_Desde_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registrado_Desde;

        public Movimiento_Detalle2Model()
        {
        }

        public Movimiento_Detalle2Model(BusinessRules r) :
                base(r)
        {
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

        public string Dev_Material
        {
            get
            {
                return _dev_Material;
            }
            set
            {
                _dev_Material = value;
                UpdateFieldValue("Dev_Material", value);
            }
        }

        public string Dev_Material_Descripcion
        {
            get
            {
                return _dev_Material_Descripcion;
            }
            set
            {
                _dev_Material_Descripcion = value;
                UpdateFieldValue("Dev_Material_Descripcion", value);
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

        public string Descripcion_Tipo_Ubicacion
        {
            get
            {
                return _descripcion_Tipo_Ubicacion;
            }
            set
            {
                _descripcion_Tipo_Ubicacion = value;
                UpdateFieldValue("Descripcion_Tipo_Ubicacion", value);
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

        public decimal? Cantidad_A_Devolver
        {
            get
            {
                return _cantidad_A_Devolver;
            }
            set
            {
                _cantidad_A_Devolver = value;
                UpdateFieldValue("Cantidad_A_Devolver", value);
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

        public int? Unidad_Material_A_Devolver_Id
        {
            get
            {
                return _unidad_Material_A_Devolver_Id;
            }
            set
            {
                _unidad_Material_A_Devolver_Id = value;
                UpdateFieldValue("Unidad_Material_A_Devolver_Id", value);
            }
        }

        public string Unidad_Material_A_Devolver
        {
            get
            {
                return _unidad_Material_A_Devolver;
            }
            set
            {
                _unidad_Material_A_Devolver = value;
                UpdateFieldValue("Unidad_Material_A_Devolver", value);
            }
        }

        public int? Unidad_Material_Devuelto_Id
        {
            get
            {
                return _unidad_Material_Devuelto_Id;
            }
            set
            {
                _unidad_Material_Devuelto_Id = value;
                UpdateFieldValue("Unidad_Material_Devuelto_Id", value);
            }
        }

        public string Unidad_Material_Devuelto
        {
            get
            {
                return _unidad_Material_Devuelto;
            }
            set
            {
                _unidad_Material_Devuelto = value;
                UpdateFieldValue("Unidad_Material_Devuelto", value);
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

        public string Transferencia_Ubicacion_Origen
        {
            get
            {
                return _transferencia_Ubicacion_Origen;
            }
            set
            {
                _transferencia_Ubicacion_Origen = value;
                UpdateFieldValue("Transferencia_Ubicacion_Origen", value);
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

        public string Transferencia_Ubicacion_Destino
        {
            get
            {
                return _transferencia_Ubicacion_Destino;
            }
            set
            {
                _transferencia_Ubicacion_Destino = value;
                UpdateFieldValue("Transferencia_Ubicacion_Destino", value);
            }
        }

        public int? Unidad_Material_A_Transferir_Id
        {
            get
            {
                return _unidad_Material_A_Transferir_Id;
            }
            set
            {
                _unidad_Material_A_Transferir_Id = value;
                UpdateFieldValue("Unidad_Material_A_Transferir_Id", value);
            }
        }

        public string Unidad_Material_A_Transferir
        {
            get
            {
                return _unidad_Material_A_Transferir;
            }
            set
            {
                _unidad_Material_A_Transferir = value;
                UpdateFieldValue("Unidad_Material_A_Transferir", value);
            }
        }

        public int? Unidad_Material_Transferido_Id
        {
            get
            {
                return _unidad_Material_Transferido_Id;
            }
            set
            {
                _unidad_Material_Transferido_Id = value;
                UpdateFieldValue("Unidad_Material_Transferido_Id", value);
            }
        }

        public string Unidad_Material_Transferido
        {
            get
            {
                return _unidad_Material_Transferido;
            }
            set
            {
                _unidad_Material_Transferido = value;
                UpdateFieldValue("Unidad_Material_Transferido", value);
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

        public string Movimiento_Det_Solicitado_Por
        {
            get
            {
                return _movimiento_Det_Solicitado_Por;
            }
            set
            {
                _movimiento_Det_Solicitado_Por = value;
                UpdateFieldValue("Movimiento_Det_Solicitado_Por", value);
            }
        }

        public string Movimiento_Det_Iniciado_Por
        {
            get
            {
                return _movimiento_Det_Iniciado_Por;
            }
            set
            {
                _movimiento_Det_Iniciado_Por = value;
                UpdateFieldValue("Movimiento_Det_Iniciado_Por", value);
            }
        }

        public string Movimiento_Det_Realizado_Por
        {
            get
            {
                return _movimiento_Det_Realizado_Por;
            }
            set
            {
                _movimiento_Det_Realizado_Por = value;
                UpdateFieldValue("Movimiento_Det_Realizado_Por", value);
            }
        }

        public string Movimiento_Det_Cancelado_Por
        {
            get
            {
                return _movimiento_Det_Cancelado_Por;
            }
            set
            {
                _movimiento_Det_Cancelado_Por = value;
                UpdateFieldValue("Movimiento_Det_Cancelado_Por", value);
            }
        }

        public string Movimiento_Det_Capturado_Por
        {
            get
            {
                return _movimiento_Det_Capturado_Por;
            }
            set
            {
                _movimiento_Det_Capturado_Por = value;
                UpdateFieldValue("Movimiento_Det_Capturado_Por", value);
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

        public DateTime? Fecha_Captura_Movimiento_Detalle
        {
            get
            {
                return _fecha_Captura_Movimiento_Detalle;
            }
            set
            {
                _fecha_Captura_Movimiento_Detalle = value;
                UpdateFieldValue("Fecha_Captura_Movimiento_Detalle", value);
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

        public System.Guid? Movimiento_Detalle_Solicitado_Por_Id
        {
            get
            {
                return _movimiento_Detalle_Solicitado_Por_Id;
            }
            set
            {
                _movimiento_Detalle_Solicitado_Por_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Solicitado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Detalle_Iniciado_Por_Id
        {
            get
            {
                return _movimiento_Detalle_Iniciado_Por_Id;
            }
            set
            {
                _movimiento_Detalle_Iniciado_Por_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Iniciado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Detalle_Realizado_Por_Id
        {
            get
            {
                return _movimiento_Detalle_Realizado_Por_Id;
            }
            set
            {
                _movimiento_Detalle_Realizado_Por_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Realizado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Detalle_Cancelado_Por_Id
        {
            get
            {
                return _movimiento_Detalle_Cancelado_Por_Id;
            }
            set
            {
                _movimiento_Detalle_Cancelado_Por_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Cancelado_Por_Id", value);
            }
        }

        public System.Guid? Movimiento_Detalle_Capturado_Por_Id
        {
            get
            {
                return _movimiento_Detalle_Capturado_Por_Id;
            }
            set
            {
                _movimiento_Detalle_Capturado_Por_Id = value;
                UpdateFieldValue("Movimiento_Detalle_Capturado_Por_Id", value);
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

        public decimal? Cantidad_A_Transferir
        {
            get
            {
                return _cantidad_A_Transferir;
            }
            set
            {
                _cantidad_A_Transferir = value;
                UpdateFieldValue("Cantidad_A_Transferir", value);
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

        public bool? Material_Es_Kanban
        {
            get
            {
                return _material_Es_Kanban;
            }
            set
            {
                _material_Es_Kanban = value;
                UpdateFieldValue("Material_Es_Kanban", value);
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

        public string Area_Entrega_Area_Entrega
        {
            get
            {
                return _area_Entrega_Area_Entrega;
            }
            set
            {
                _area_Entrega_Area_Entrega = value;
                UpdateFieldValue("Area_Entrega_Area_Entrega", value);
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

        public FieldValue this[Movimiento_Detalle2DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
