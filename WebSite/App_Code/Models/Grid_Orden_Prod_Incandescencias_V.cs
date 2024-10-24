using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Orden_Prod_Incandescencias_VDataField
    {

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        Fecha_Produccion,

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

        Area_Servicio_Id,

        Usuario_Aplicacion_Id,

        Usuario_Id,

        Existe_En_Prod_Mat,

        Etiqueta_Existe_En_Prod_Mat,

        Valida_Mat_Almacen,
    }

    public partial class Grid_Orden_Prod_Incandescencias_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Produccion;

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
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usuario_Aplicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _existe_En_Prod_Mat;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _etiqueta_Existe_En_Prod_Mat;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _valida_Mat_Almacen;

        public Grid_Orden_Prod_Incandescencias_VModel()
        {
        }

        public Grid_Orden_Prod_Incandescencias_VModel(BusinessRules r) :
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

        public int? Existe_En_Prod_Mat
        {
            get
            {
                return _existe_En_Prod_Mat;
            }
            set
            {
                _existe_En_Prod_Mat = value;
                UpdateFieldValue("Existe_En_Prod_Mat", value);
            }
        }

        public string Etiqueta_Existe_En_Prod_Mat
        {
            get
            {
                return _etiqueta_Existe_En_Prod_Mat;
            }
            set
            {
                _etiqueta_Existe_En_Prod_Mat = value;
                UpdateFieldValue("Etiqueta_Existe_En_Prod_Mat", value);
            }
        }

        public string Valida_Mat_Almacen
        {
            get
            {
                return _valida_Mat_Almacen;
            }
            set
            {
                _valida_Mat_Almacen = value;
                UpdateFieldValue("Valida_Mat_Almacen", value);
            }
        }

        public FieldValue this[Grid_Orden_Prod_Incandescencias_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
