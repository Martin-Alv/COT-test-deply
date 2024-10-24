using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Orden_Detalle_De_Orden_Produccion_VDataField
    {

        Orden_Produccion_Id,

        Fecha_Produccion,

        Material_Id,

        Material,

        Material_Descripcion,

        Numero_Orden_Produccion,

        Producto_Id,

        Producto_Clave,

        Producto_Descripcion,

        Orden_Produccion_Detalle_Id,

        Cantidad_Producto,

        Material_Ubicacion_Piso,

        Material_Ubicacion_Almacen,

        Cantidad_Mat_Para_Producir_Un_Prod,

        Cantidad_Mat_Total_Para_Producir,

        Cantidad_Mat_Solicitado_Previamente,

        Cantidad_Mat_Restante_Por_Solicitar,

        Cantidad_Mat_A_Solicitar,

        Folio_Desviacion,

        Nota_Folio_Desviacion,

        Categoria_Id,

        Categoria_Clave,

        Categoria_Descripcion,

        Familia_Id,

        Familia_Clave,

        Familia_Descripcion,

        Area_Entrega,

        Area_Entrega_Id,

        Area_Servicio_Id,

        Clasificacion,

        Mostrar_Hijos,
    }

    public partial class Grid_Orden_Detalle_De_Orden_Produccion_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Producto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Ubicacion_Piso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Ubicacion_Almacen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Para_Producir_Un_Prod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Total_Para_Producir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Solicitado_Previamente;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Restante_Por_Solicitar;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_A_Solicitar;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio_Desviacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nota_Folio_Desviacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _categoria_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _categoria_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _familia_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _familia_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clasificacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Hijos;

        public Grid_Orden_Detalle_De_Orden_Produccion_VModel()
        {
        }

        public Grid_Orden_Detalle_De_Orden_Produccion_VModel(BusinessRules r) :
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

        public decimal? Cantidad_Producto
        {
            get
            {
                return _cantidad_Producto;
            }
            set
            {
                _cantidad_Producto = value;
                UpdateFieldValue("Cantidad_Producto", value);
            }
        }

        public string Material_Ubicacion_Piso
        {
            get
            {
                return _material_Ubicacion_Piso;
            }
            set
            {
                _material_Ubicacion_Piso = value;
                UpdateFieldValue("Material_Ubicacion_Piso", value);
            }
        }

        public string Material_Ubicacion_Almacen
        {
            get
            {
                return _material_Ubicacion_Almacen;
            }
            set
            {
                _material_Ubicacion_Almacen = value;
                UpdateFieldValue("Material_Ubicacion_Almacen", value);
            }
        }

        public decimal? Cantidad_Mat_Para_Producir_Un_Prod
        {
            get
            {
                return _cantidad_Mat_Para_Producir_Un_Prod;
            }
            set
            {
                _cantidad_Mat_Para_Producir_Un_Prod = value;
                UpdateFieldValue("Cantidad_Mat_Para_Producir_Un_Prod", value);
            }
        }

        public decimal? Cantidad_Mat_Total_Para_Producir
        {
            get
            {
                return _cantidad_Mat_Total_Para_Producir;
            }
            set
            {
                _cantidad_Mat_Total_Para_Producir = value;
                UpdateFieldValue("Cantidad_Mat_Total_Para_Producir", value);
            }
        }

        public decimal? Cantidad_Mat_Solicitado_Previamente
        {
            get
            {
                return _cantidad_Mat_Solicitado_Previamente;
            }
            set
            {
                _cantidad_Mat_Solicitado_Previamente = value;
                UpdateFieldValue("Cantidad_Mat_Solicitado_Previamente", value);
            }
        }

        public decimal? Cantidad_Mat_Restante_Por_Solicitar
        {
            get
            {
                return _cantidad_Mat_Restante_Por_Solicitar;
            }
            set
            {
                _cantidad_Mat_Restante_Por_Solicitar = value;
                UpdateFieldValue("Cantidad_Mat_Restante_Por_Solicitar", value);
            }
        }

        public decimal? Cantidad_Mat_A_Solicitar
        {
            get
            {
                return _cantidad_Mat_A_Solicitar;
            }
            set
            {
                _cantidad_Mat_A_Solicitar = value;
                UpdateFieldValue("Cantidad_Mat_A_Solicitar", value);
            }
        }

        public int? Folio_Desviacion
        {
            get
            {
                return _folio_Desviacion;
            }
            set
            {
                _folio_Desviacion = value;
                UpdateFieldValue("Folio_Desviacion", value);
            }
        }

        public string Nota_Folio_Desviacion
        {
            get
            {
                return _nota_Folio_Desviacion;
            }
            set
            {
                _nota_Folio_Desviacion = value;
                UpdateFieldValue("Nota_Folio_Desviacion", value);
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

        public string Categoria_Descripcion
        {
            get
            {
                return _categoria_Descripcion;
            }
            set
            {
                _categoria_Descripcion = value;
                UpdateFieldValue("Categoria_Descripcion", value);
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

        public string Clasificacion
        {
            get
            {
                return _clasificacion;
            }
            set
            {
                _clasificacion = value;
                UpdateFieldValue("Clasificacion", value);
            }
        }

        public bool? Mostrar_Hijos
        {
            get
            {
                return _mostrar_Hijos;
            }
            set
            {
                _mostrar_Hijos = value;
                UpdateFieldValue("Mostrar_Hijos", value);
            }
        }

        public FieldValue this[Grid_Orden_Detalle_De_Orden_Produccion_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
