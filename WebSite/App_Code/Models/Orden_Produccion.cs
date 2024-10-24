using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Orden_ProduccionDataField
    {

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        Fecha_Produccion,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Cantidad,

        Estatus_Orden_Produccion_Id,

        Estatus_Orden_Produccion,

        Producto_Clave,

        Producto_Id,

        Familia_Id,

        Familia_Clave,

        Familia_Descripcion,

        Creado_Por,

        Fecha_Liberacion_Produccion,

        Fecha_Compromiso_Produccion,

        Fecha_Embarque,

        Cantidad_Producido,

        Cantidad_Restante_Por_Producir,

        Planeador_Id,

        Planeador,

        Planta_Id,

        Planta,

        Area_Servicio_Id,

        Area_Servicio,

        Categoria_Id,

        Categoria_Clave,

        DC_S_Planta_Id,

        Numero_Planta,

        PO,

        Cus_Ord,

        Cus_Lin,

        Codigo_Bloqueo,

        No_Entregar_Antes_De,

        Esta_Bloqueado,

        ProductoCatlg,

        Stay,
    }

    public partial class Orden_ProduccionModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Produccion;

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
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _familia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Liberacion_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Compromiso_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Embarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Producido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Restante_Por_Producir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _planeador_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _planeador;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _planta_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _planta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Servicio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _categoria_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dC_S_Planta_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Planta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pO;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _cus_Ord;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cus_Lin;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _codigo_Bloqueo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _no_Entregar_Antes_De;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _esta_Bloqueado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productoCatlg;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stay;

        public Orden_ProduccionModel()
        {
        }

        public Orden_ProduccionModel(BusinessRules r) :
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

        public decimal? Cantidad_Producido
        {
            get
            {
                return _cantidad_Producido;
            }
            set
            {
                _cantidad_Producido = value;
                UpdateFieldValue("Cantidad_Producido", value);
            }
        }

        public decimal? Cantidad_Restante_Por_Producir
        {
            get
            {
                return _cantidad_Restante_Por_Producir;
            }
            set
            {
                _cantidad_Restante_Por_Producir = value;
                UpdateFieldValue("Cantidad_Restante_Por_Producir", value);
            }
        }

        public int? Planeador_Id
        {
            get
            {
                return _planeador_Id;
            }
            set
            {
                _planeador_Id = value;
                UpdateFieldValue("Planeador_Id", value);
            }
        }

        public string Planeador
        {
            get
            {
                return _planeador;
            }
            set
            {
                _planeador = value;
                UpdateFieldValue("Planeador", value);
            }
        }

        public int? Planta_Id
        {
            get
            {
                return _planta_Id;
            }
            set
            {
                _planta_Id = value;
                UpdateFieldValue("Planta_Id", value);
            }
        }

        public string Planta
        {
            get
            {
                return _planta;
            }
            set
            {
                _planta = value;
                UpdateFieldValue("Planta", value);
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

        public int? DC_S_Planta_Id
        {
            get
            {
                return _dC_S_Planta_Id;
            }
            set
            {
                _dC_S_Planta_Id = value;
                UpdateFieldValue("DC_S_Planta_Id", value);
            }
        }

        public string Numero_Planta
        {
            get
            {
                return _numero_Planta;
            }
            set
            {
                _numero_Planta = value;
                UpdateFieldValue("Numero_Planta", value);
            }
        }

        public string PO
        {
            get
            {
                return _pO;
            }
            set
            {
                _pO = value;
                UpdateFieldValue("PO", value);
            }
        }

        public long? Cus_Ord
        {
            get
            {
                return _cus_Ord;
            }
            set
            {
                _cus_Ord = value;
                UpdateFieldValue("Cus_Ord", value);
            }
        }

        public int? Cus_Lin
        {
            get
            {
                return _cus_Lin;
            }
            set
            {
                _cus_Lin = value;
                UpdateFieldValue("Cus_Lin", value);
            }
        }

        public string Codigo_Bloqueo
        {
            get
            {
                return _codigo_Bloqueo;
            }
            set
            {
                _codigo_Bloqueo = value;
                UpdateFieldValue("Codigo_Bloqueo", value);
            }
        }

        public DateTime? No_Entregar_Antes_De
        {
            get
            {
                return _no_Entregar_Antes_De;
            }
            set
            {
                _no_Entregar_Antes_De = value;
                UpdateFieldValue("No_Entregar_Antes_De", value);
            }
        }

        public bool? Esta_Bloqueado
        {
            get
            {
                return _esta_Bloqueado;
            }
            set
            {
                _esta_Bloqueado = value;
                UpdateFieldValue("Esta_Bloqueado", value);
            }
        }

        public string ProductoCatlg
        {
            get
            {
                return _productoCatlg;
            }
            set
            {
                _productoCatlg = value;
                UpdateFieldValue("ProductoCatlg", value);
            }
        }

        public string Stay
        {
            get
            {
                return _stay;
            }
            set
            {
                _stay = value;
                UpdateFieldValue("Stay", value);
            }
        }

        public FieldValue this[Orden_ProduccionDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
