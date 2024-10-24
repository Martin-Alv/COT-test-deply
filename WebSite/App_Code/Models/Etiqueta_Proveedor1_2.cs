using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Etiqueta_Proveedor1_2DataField
    {

        Etiqueta_Proveedor_Id,

        Folio,

        Proveedor_ERSL_Id,

        Proveedor_ERSL,

        Orden_Compra,

        Factura,

        Material_Id,

        Material,

        Material_Descripcion,

        Cantidad_Total,

        Cantidad_Entrega,

        Unidad_Material_Total_Id,

        Unidad_Material_Total,

        Unidad_Material_Entrega_Id,

        Unidad_Material_Entrega,

        Cantidad_Por_Unidad_Entrega,

        Numero_Referencia,

        Ubicacion_Id,

        Ubicacion_Almacenamiento,

        Transfer,

        Usuario_Sistema_Comprador_Id,

        Usuario_Comprador_Nombre_Completo,

        Comentarios,

        Es_Cargado_Por_Excel,

        Es_Creado_Por_Formulario,

        Fecha_Etiqueta,

        Actualizado_Por,

        Fecha_Creacion,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Usuario_Etiqueta,

        Creado_Por,

        Usuario_Etiqueta_Id,

        Transaccion_Procesamiento,

        Carga,

        Usuario_Sistema_Proveedor_Id,

        Valores_Etiqueta_Padre,
    }

    public partial class Etiqueta_Proveedor1_2Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiqueta_Proveedor_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _proveedor_ERSL_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _proveedor_ERSL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Compra;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _factura;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Total;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Total_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Total;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Por_Unidad_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Referencia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transfer;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Sistema_Comprador_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Comprador_Nombre_Completo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comentarios;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Cargado_Por_Excel;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Creado_Por_Formulario;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Etiqueta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Etiqueta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Etiqueta_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _transaccion_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _carga;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Sistema_Proveedor_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valores_Etiqueta_Padre;

        public Etiqueta_Proveedor1_2Model()
        {
        }

        public Etiqueta_Proveedor1_2Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Etiqueta_Proveedor_Id
        {
            get
            {
                return _etiqueta_Proveedor_Id;
            }
            set
            {
                _etiqueta_Proveedor_Id = value;
                UpdateFieldValue("Etiqueta_Proveedor_Id", value);
            }
        }

        public int? Folio
        {
            get
            {
                return _folio;
            }
            set
            {
                _folio = value;
                UpdateFieldValue("Folio", value);
            }
        }

        public int? Proveedor_ERSL_Id
        {
            get
            {
                return _proveedor_ERSL_Id;
            }
            set
            {
                _proveedor_ERSL_Id = value;
                UpdateFieldValue("Proveedor_ERSL_Id", value);
            }
        }

        public string Proveedor_ERSL
        {
            get
            {
                return _proveedor_ERSL;
            }
            set
            {
                _proveedor_ERSL = value;
                UpdateFieldValue("Proveedor_ERSL", value);
            }
        }

        public string Orden_Compra
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

        public decimal? Cantidad_Total
        {
            get
            {
                return _cantidad_Total;
            }
            set
            {
                _cantidad_Total = value;
                UpdateFieldValue("Cantidad_Total", value);
            }
        }

        public decimal? Cantidad_Entrega
        {
            get
            {
                return _cantidad_Entrega;
            }
            set
            {
                _cantidad_Entrega = value;
                UpdateFieldValue("Cantidad_Entrega", value);
            }
        }

        public int? Unidad_Material_Total_Id
        {
            get
            {
                return _unidad_Material_Total_Id;
            }
            set
            {
                _unidad_Material_Total_Id = value;
                UpdateFieldValue("Unidad_Material_Total_Id", value);
            }
        }

        public string Unidad_Material_Total
        {
            get
            {
                return _unidad_Material_Total;
            }
            set
            {
                _unidad_Material_Total = value;
                UpdateFieldValue("Unidad_Material_Total", value);
            }
        }

        public int? Unidad_Material_Entrega_Id
        {
            get
            {
                return _unidad_Material_Entrega_Id;
            }
            set
            {
                _unidad_Material_Entrega_Id = value;
                UpdateFieldValue("Unidad_Material_Entrega_Id", value);
            }
        }

        public string Unidad_Material_Entrega
        {
            get
            {
                return _unidad_Material_Entrega;
            }
            set
            {
                _unidad_Material_Entrega = value;
                UpdateFieldValue("Unidad_Material_Entrega", value);
            }
        }

        public decimal? Cantidad_Por_Unidad_Entrega
        {
            get
            {
                return _cantidad_Por_Unidad_Entrega;
            }
            set
            {
                _cantidad_Por_Unidad_Entrega = value;
                UpdateFieldValue("Cantidad_Por_Unidad_Entrega", value);
            }
        }

        public string Numero_Referencia
        {
            get
            {
                return _numero_Referencia;
            }
            set
            {
                _numero_Referencia = value;
                UpdateFieldValue("Numero_Referencia", value);
            }
        }

        public int? Ubicacion_Id
        {
            get
            {
                return _ubicacion_Id;
            }
            set
            {
                _ubicacion_Id = value;
                UpdateFieldValue("Ubicacion_Id", value);
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

        public string Transfer
        {
            get
            {
                return _transfer;
            }
            set
            {
                _transfer = value;
                UpdateFieldValue("Transfer", value);
            }
        }

        public System.Guid? Usuario_Sistema_Comprador_Id
        {
            get
            {
                return _usuario_Sistema_Comprador_Id;
            }
            set
            {
                _usuario_Sistema_Comprador_Id = value;
                UpdateFieldValue("Usuario_Sistema_Comprador_Id", value);
            }
        }

        public string Usuario_Comprador_Nombre_Completo
        {
            get
            {
                return _usuario_Comprador_Nombre_Completo;
            }
            set
            {
                _usuario_Comprador_Nombre_Completo = value;
                UpdateFieldValue("Usuario_Comprador_Nombre_Completo", value);
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

        public bool? Es_Cargado_Por_Excel
        {
            get
            {
                return _es_Cargado_Por_Excel;
            }
            set
            {
                _es_Cargado_Por_Excel = value;
                UpdateFieldValue("Es_Cargado_Por_Excel", value);
            }
        }

        public bool? Es_Creado_Por_Formulario
        {
            get
            {
                return _es_Creado_Por_Formulario;
            }
            set
            {
                _es_Creado_Por_Formulario = value;
                UpdateFieldValue("Es_Creado_Por_Formulario", value);
            }
        }

        public DateTime? Fecha_Etiqueta
        {
            get
            {
                return _fecha_Etiqueta;
            }
            set
            {
                _fecha_Etiqueta = value;
                UpdateFieldValue("Fecha_Etiqueta", value);
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

        public string Usuario_Etiqueta
        {
            get
            {
                return _usuario_Etiqueta;
            }
            set
            {
                _usuario_Etiqueta = value;
                UpdateFieldValue("Usuario_Etiqueta", value);
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

        public System.Guid? Usuario_Etiqueta_Id
        {
            get
            {
                return _usuario_Etiqueta_Id;
            }
            set
            {
                _usuario_Etiqueta_Id = value;
                UpdateFieldValue("Usuario_Etiqueta_Id", value);
            }
        }

        public System.Guid? Transaccion_Procesamiento
        {
            get
            {
                return _transaccion_Procesamiento;
            }
            set
            {
                _transaccion_Procesamiento = value;
                UpdateFieldValue("Transaccion_Procesamiento", value);
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

        public System.Guid? Usuario_Sistema_Proveedor_Id
        {
            get
            {
                return _usuario_Sistema_Proveedor_Id;
            }
            set
            {
                _usuario_Sistema_Proveedor_Id = value;
                UpdateFieldValue("Usuario_Sistema_Proveedor_Id", value);
            }
        }

        public string Valores_Etiqueta_Padre
        {
            get
            {
                return _valores_Etiqueta_Padre;
            }
            set
            {
                _valores_Etiqueta_Padre = value;
                UpdateFieldValue("Valores_Etiqueta_Padre", value);
            }
        }

        public FieldValue this[Etiqueta_Proveedor1_2DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
