using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Temporal_Etiqueta_Proveedor1_2_1DataField
    {

        Temporal_Etiqueta_Proveedor_Id,

        Temporal_Etiqueta_Proveedor,

        Tipo_Factura,

        Factura,

        Fecha,

        Referencia,

        Comprador,

        Parte,

        Clase,

        Descripcion,

        Desc_Ingles,

        Fracccion,

        Tipo_Tasa,

        Tasa,

        Pais_Origen,

        HTS,

        Orden_Compra,

        Clave_Proveedor,

        Nombre_Proveedor,

        Cantidad_Piezas,

        Unidad_De_Medida,

        Peso,

        Peso_Bruto,

        Costo_Unitario,

        Total_DLLS,

        Cantidad_En_UMC,

        UM_Comercial,

        Cant_Bultos,

        Desc_Bultos,

        Tipo,

        Permiso_Regla_8,

        Clave_Proveedor_Mx,

        Nombre_Proveedor_Mx,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Creado_Por,

        Estatus_Procesamiento_Id,

        Estatus_Procesamiento,

        Mensaje_Sistema_Id,

        Mensaje_Sistema,

        Error,

        Carga,

        Creado_Por_Id,
    }

    public partial class Temporal_Etiqueta_Proveedor1_2_1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_Etiqueta_Proveedor_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _temporal_Etiqueta_Proveedor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Factura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _factura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _referencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comprador;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _parte;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clase;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _desc_Ingles;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _fracccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Tasa;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _tasa;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pais_Origen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hTS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _orden_Compra;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _clave_Proveedor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Proveedor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Piezas;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_De_Medida;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _peso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _peso_Bruto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _costo_Unitario;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _total_DLLS;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_En_UMC;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _uM_Comercial;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cant_Bultos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _desc_Bultos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _tipo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _permiso_Regla_8;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clave_Proveedor_Mx;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Proveedor_Mx;

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
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Procesamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _error;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _carga;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        public Temporal_Etiqueta_Proveedor1_2_1Model()
        {
        }

        public Temporal_Etiqueta_Proveedor1_2_1Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Temporal_Etiqueta_Proveedor_Id
        {
            get
            {
                return _temporal_Etiqueta_Proveedor_Id;
            }
            set
            {
                _temporal_Etiqueta_Proveedor_Id = value;
                UpdateFieldValue("Temporal_Etiqueta_Proveedor_Id", value);
            }
        }

        public string Temporal_Etiqueta_Proveedor
        {
            get
            {
                return _temporal_Etiqueta_Proveedor;
            }
            set
            {
                _temporal_Etiqueta_Proveedor = value;
                UpdateFieldValue("Temporal_Etiqueta_Proveedor", value);
            }
        }

        public string Tipo_Factura
        {
            get
            {
                return _tipo_Factura;
            }
            set
            {
                _tipo_Factura = value;
                UpdateFieldValue("Tipo_Factura", value);
            }
        }

        public string Factura
        {
            get
            {
                return _factura;
            }
            set
            {
                _factura = value;
                UpdateFieldValue("Factura", value);
            }
        }

        public DateTime? Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
                UpdateFieldValue("Fecha", value);
            }
        }

        public string Referencia
        {
            get
            {
                return _referencia;
            }
            set
            {
                _referencia = value;
                UpdateFieldValue("Referencia", value);
            }
        }

        public string Comprador
        {
            get
            {
                return _comprador;
            }
            set
            {
                _comprador = value;
                UpdateFieldValue("Comprador", value);
            }
        }

        public string Parte
        {
            get
            {
                return _parte;
            }
            set
            {
                _parte = value;
                UpdateFieldValue("Parte", value);
            }
        }

        public string Clase
        {
            get
            {
                return _clase;
            }
            set
            {
                _clase = value;
                UpdateFieldValue("Clase", value);
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
                UpdateFieldValue("Descripcion", value);
            }
        }

        public string Desc_Ingles
        {
            get
            {
                return _desc_Ingles;
            }
            set
            {
                _desc_Ingles = value;
                UpdateFieldValue("Desc_Ingles", value);
            }
        }

        public decimal? Fracccion
        {
            get
            {
                return _fracccion;
            }
            set
            {
                _fracccion = value;
                UpdateFieldValue("Fracccion", value);
            }
        }

        public string Tipo_Tasa
        {
            get
            {
                return _tipo_Tasa;
            }
            set
            {
                _tipo_Tasa = value;
                UpdateFieldValue("Tipo_Tasa", value);
            }
        }

        public decimal? Tasa
        {
            get
            {
                return _tasa;
            }
            set
            {
                _tasa = value;
                UpdateFieldValue("Tasa", value);
            }
        }

        public string Pais_Origen
        {
            get
            {
                return _pais_Origen;
            }
            set
            {
                _pais_Origen = value;
                UpdateFieldValue("Pais_Origen", value);
            }
        }

        public string HTS
        {
            get
            {
                return _hTS;
            }
            set
            {
                _hTS = value;
                UpdateFieldValue("HTS", value);
            }
        }

        public decimal? Orden_Compra
        {
            get
            {
                return _orden_Compra;
            }
            set
            {
                _orden_Compra = value;
                UpdateFieldValue("Orden_Compra", value);
            }
        }

        public decimal? Clave_Proveedor
        {
            get
            {
                return _clave_Proveedor;
            }
            set
            {
                _clave_Proveedor = value;
                UpdateFieldValue("Clave_Proveedor", value);
            }
        }

        public string Nombre_Proveedor
        {
            get
            {
                return _nombre_Proveedor;
            }
            set
            {
                _nombre_Proveedor = value;
                UpdateFieldValue("Nombre_Proveedor", value);
            }
        }

        public decimal? Cantidad_Piezas
        {
            get
            {
                return _cantidad_Piezas;
            }
            set
            {
                _cantidad_Piezas = value;
                UpdateFieldValue("Cantidad_Piezas", value);
            }
        }

        public string Unidad_De_Medida
        {
            get
            {
                return _unidad_De_Medida;
            }
            set
            {
                _unidad_De_Medida = value;
                UpdateFieldValue("Unidad_De_Medida", value);
            }
        }

        public decimal? Peso
        {
            get
            {
                return _peso;
            }
            set
            {
                _peso = value;
                UpdateFieldValue("Peso", value);
            }
        }

        public decimal? Peso_Bruto
        {
            get
            {
                return _peso_Bruto;
            }
            set
            {
                _peso_Bruto = value;
                UpdateFieldValue("Peso_Bruto", value);
            }
        }

        public decimal? Costo_Unitario
        {
            get
            {
                return _costo_Unitario;
            }
            set
            {
                _costo_Unitario = value;
                UpdateFieldValue("Costo_Unitario", value);
            }
        }

        public decimal? Total_DLLS
        {
            get
            {
                return _total_DLLS;
            }
            set
            {
                _total_DLLS = value;
                UpdateFieldValue("Total_DLLS", value);
            }
        }

        public decimal? Cantidad_En_UMC
        {
            get
            {
                return _cantidad_En_UMC;
            }
            set
            {
                _cantidad_En_UMC = value;
                UpdateFieldValue("Cantidad_En_UMC", value);
            }
        }

        public string UM_Comercial
        {
            get
            {
                return _uM_Comercial;
            }
            set
            {
                _uM_Comercial = value;
                UpdateFieldValue("UM_Comercial", value);
            }
        }

        public decimal? Cant_Bultos
        {
            get
            {
                return _cant_Bultos;
            }
            set
            {
                _cant_Bultos = value;
                UpdateFieldValue("Cant_Bultos", value);
            }
        }

        public decimal? Desc_Bultos
        {
            get
            {
                return _desc_Bultos;
            }
            set
            {
                _desc_Bultos = value;
                UpdateFieldValue("Desc_Bultos", value);
            }
        }

        public decimal? Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
                UpdateFieldValue("Tipo", value);
            }
        }

        public string Permiso_Regla_8
        {
            get
            {
                return _permiso_Regla_8;
            }
            set
            {
                _permiso_Regla_8 = value;
                UpdateFieldValue("Permiso_Regla_8", value);
            }
        }

        public string Clave_Proveedor_Mx
        {
            get
            {
                return _clave_Proveedor_Mx;
            }
            set
            {
                _clave_Proveedor_Mx = value;
                UpdateFieldValue("Clave_Proveedor_Mx", value);
            }
        }

        public string Nombre_Proveedor_Mx
        {
            get
            {
                return _nombre_Proveedor_Mx;
            }
            set
            {
                _nombre_Proveedor_Mx = value;
                UpdateFieldValue("Nombre_Proveedor_Mx", value);
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

        public int? Carga
        {
            get
            {
                return _carga;
            }
            set
            {
                _carga = value;
                UpdateFieldValue("Carga", value);
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

        public FieldValue this[Temporal_Etiqueta_Proveedor1_2_1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
