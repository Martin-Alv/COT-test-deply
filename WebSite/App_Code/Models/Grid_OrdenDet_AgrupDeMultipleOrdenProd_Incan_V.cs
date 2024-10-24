using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VDataField
    {

        Material_Id,

        Material,

        Material_Descripcion,

        Cantidad_Mat_Total_Para_Producir,

        Cantidad_Mat_Solicitado_Previamente,

        Cantidad_Mat_Restante_Por_Solicitar,

        Cantidad_Mat_A_Solicitar,

        Seleccion_Temporal_Transaccion_Id,

        Material_Orden_Produccion,

        Material_Producto,

        Material_Orden_Produccion_Detalle,

        Material_Cantidad_Para_Producir,

        Material_Familia,

        Material_Area_Entrega,

        Material_Ubicacion_Almacen,

        Material_Ubicacion_Piso,

        Material_Agrupado_De_Multiple_Orden_Produccion_Id,

        Cantidad_Solicitado,

        Area_Entrega_Id,
    }

    public partial class Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Total_Para_Producir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Solicitado_Previamente;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_Restante_Por_Solicitar;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Mat_A_Solicitar;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _seleccion_Temporal_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Producto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Orden_Produccion_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Cantidad_Para_Producir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Familia;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Ubicacion_Almacen;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Ubicacion_Piso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Agrupado_De_Multiple_Orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        public Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VModel()
        {
        }

        public Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VModel(BusinessRules r) :
                base(r)
        {
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

        public System.Guid? Seleccion_Temporal_Transaccion_Id
        {
            get
            {
                return _seleccion_Temporal_Transaccion_Id;
            }
            set
            {
                _seleccion_Temporal_Transaccion_Id = value;
                UpdateFieldValue("Seleccion_Temporal_Transaccion_Id", value);
            }
        }

        public string Material_Orden_Produccion
        {
            get
            {
                return _material_Orden_Produccion;
            }
            set
            {
                _material_Orden_Produccion = value;
                UpdateFieldValue("Material_Orden_Produccion", value);
            }
        }

        public string Material_Producto
        {
            get
            {
                return _material_Producto;
            }
            set
            {
                _material_Producto = value;
                UpdateFieldValue("Material_Producto", value);
            }
        }

        public string Material_Orden_Produccion_Detalle
        {
            get
            {
                return _material_Orden_Produccion_Detalle;
            }
            set
            {
                _material_Orden_Produccion_Detalle = value;
                UpdateFieldValue("Material_Orden_Produccion_Detalle", value);
            }
        }

        public string Material_Cantidad_Para_Producir
        {
            get
            {
                return _material_Cantidad_Para_Producir;
            }
            set
            {
                _material_Cantidad_Para_Producir = value;
                UpdateFieldValue("Material_Cantidad_Para_Producir", value);
            }
        }

        public string Material_Familia
        {
            get
            {
                return _material_Familia;
            }
            set
            {
                _material_Familia = value;
                UpdateFieldValue("Material_Familia", value);
            }
        }

        public string Material_Area_Entrega
        {
            get
            {
                return _material_Area_Entrega;
            }
            set
            {
                _material_Area_Entrega = value;
                UpdateFieldValue("Material_Area_Entrega", value);
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

        public long? Material_Agrupado_De_Multiple_Orden_Produccion_Id
        {
            get
            {
                return _material_Agrupado_De_Multiple_Orden_Produccion_Id;
            }
            set
            {
                _material_Agrupado_De_Multiple_Orden_Produccion_Id = value;
                UpdateFieldValue("Material_Agrupado_De_Multiple_Orden_Produccion_Id", value);
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

        public FieldValue this[Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
