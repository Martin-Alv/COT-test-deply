using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Orden_Produccion_VDataField
    {

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        Fecha_Produccion,

        EstaBloqueado,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Cantidad,

        Estatus_Orden_Produccion_Id,

        Estatus_Orden_Produccion,

        Producto_Clave,

        Producto_Descripcion,

        Producto_Id,

        Familia_Id,

        Familia_Clave,

        Familia_Descripcion,

        Cantidad_Dias_Produccion,

        Menor_A_Dias_Establecidos,

        Cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud,

        Area_Servicio_Id,

        Usuario_Aplicacion_Id,

        Usuario_Id,

        Habilitar_Crear_Solicitud,

        Existencia_Completa_Cantidad_Material,

        Fecha_Liberacion_Produccion,

        Fecha_Compromiso_Produccion,

        Fecha_Embarque,
    }

    public partial class Grid_Orden_Produccion_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _estaBloqueado;

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
        private decimal? _cantidad;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _familia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cantidad_Dias_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _menor_A_Dias_Establecidos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usuario_Aplicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _habilitar_Crear_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _existencia_Completa_Cantidad_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Liberacion_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Compromiso_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Embarque;

        public Grid_Orden_Produccion_VModel()
        {
        }

        public Grid_Orden_Produccion_VModel(BusinessRules r) :
                base(r)
        {
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

        public DateTime? Fecha_Produccion
        {
            get
            {
                return _fecha_Produccion;
            }
            set
            {
                _fecha_Produccion = value;
                UpdateFieldValue("Fecha_Produccion", value);
            }
        }

        public bool? EstaBloqueado
        {
            get
            {
                return _estaBloqueado;
            }
            set
            {
                _estaBloqueado = value;
                UpdateFieldValue("EstaBloqueado", value);
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

        public decimal? Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
                UpdateFieldValue("Cantidad", value);
            }
        }

        public int? Estatus_Orden_Produccion_Id
        {
            get
            {
                return _estatus_Orden_Produccion_Id;
            }
            set
            {
                _estatus_Orden_Produccion_Id = value;
                UpdateFieldValue("Estatus_Orden_Produccion_Id", value);
            }
        }

        public string Estatus_Orden_Produccion
        {
            get
            {
                return _estatus_Orden_Produccion;
            }
            set
            {
                _estatus_Orden_Produccion = value;
                UpdateFieldValue("Estatus_Orden_Produccion", value);
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

        public string Producto_Descripcion
        {
            get
            {
                return _producto_Descripcion;
            }
            set
            {
                _producto_Descripcion = value;
                UpdateFieldValue("Producto_Descripcion", value);
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

        public string Familia_Descripcion
        {
            get
            {
                return _familia_Descripcion;
            }
            set
            {
                _familia_Descripcion = value;
                UpdateFieldValue("Familia_Descripcion", value);
            }
        }

        public int? Cantidad_Dias_Produccion
        {
            get
            {
                return _cantidad_Dias_Produccion;
            }
            set
            {
                _cantidad_Dias_Produccion = value;
                UpdateFieldValue("Cantidad_Dias_Produccion", value);
            }
        }

        public int? Menor_A_Dias_Establecidos
        {
            get
            {
                return _menor_A_Dias_Establecidos;
            }
            set
            {
                _menor_A_Dias_Establecidos = value;
                UpdateFieldValue("Menor_A_Dias_Establecidos", value);
            }
        }

        public int? Cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud
        {
            get
            {
                return _cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud;
            }
            set
            {
                _cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud = value;
                UpdateFieldValue("Cantidad_Orden_Detalle_Pendiente_Por_Enviar_A_Solicitud", value);
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

        public int? Usuario_Aplicacion_Id
        {
            get
            {
                return _usuario_Aplicacion_Id;
            }
            set
            {
                _usuario_Aplicacion_Id = value;
                UpdateFieldValue("Usuario_Aplicacion_Id", value);
            }
        }

        public System.Guid? Usuario_Id
        {
            get
            {
                return _usuario_Id;
            }
            set
            {
                _usuario_Id = value;
                UpdateFieldValue("Usuario_Id", value);
            }
        }

        public bool? Habilitar_Crear_Solicitud
        {
            get
            {
                return _habilitar_Crear_Solicitud;
            }
            set
            {
                _habilitar_Crear_Solicitud = value;
                UpdateFieldValue("Habilitar_Crear_Solicitud", value);
            }
        }

        public bool? Existencia_Completa_Cantidad_Material
        {
            get
            {
                return _existencia_Completa_Cantidad_Material;
            }
            set
            {
                _existencia_Completa_Cantidad_Material = value;
                UpdateFieldValue("Existencia_Completa_Cantidad_Material", value);
            }
        }

        public DateTime? Fecha_Liberacion_Produccion
        {
            get
            {
                return _fecha_Liberacion_Produccion;
            }
            set
            {
                _fecha_Liberacion_Produccion = value;
                UpdateFieldValue("Fecha_Liberacion_Produccion", value);
            }
        }

        public DateTime? Fecha_Compromiso_Produccion
        {
            get
            {
                return _fecha_Compromiso_Produccion;
            }
            set
            {
                _fecha_Compromiso_Produccion = value;
                UpdateFieldValue("Fecha_Compromiso_Produccion", value);
            }
        }

        public DateTime? Fecha_Embarque
        {
            get
            {
                return _fecha_Embarque;
            }
            set
            {
                _fecha_Embarque = value;
                UpdateFieldValue("Fecha_Embarque", value);
            }
        }

        public FieldValue this[Grid_Orden_Produccion_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
