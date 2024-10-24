using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Etiqueta_Embarque_Detalle1_1DataField
    {

        Etiqueta_Embarque_Detalle_Id,

        Folio_Etiqueta_Embarque_Detalle,

        Etiqueta_Embarque_Id,

        Folio_Etiqueta_Embarque,

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        DC_S_Planta_Id,

        DC_S_Planta,

        DC_S_Descripcion,

        Producto_Id,

        Producto_Descripcion,

        Producto_Clave,

        PO,

        S_O,

        Cantidad_Total,

        Unidad_Material_Id,

        Unidad_Material,

        Cantidad_De_Bultos,

        Cantidad_En_Etiqueta_Detalle,

        Numero_Bultos,

        Inactivo_Por_Edicion,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,
    }

    public partial class Etiqueta_Embarque_Detalle1_1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiqueta_Embarque_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio_Etiqueta_Embarque_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiqueta_Embarque_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio_Etiqueta_Embarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _dC_S_Planta_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dC_S_Planta;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dC_S_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _producto_Clave;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pO;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _s_O;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Total;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_De_Bultos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_En_Etiqueta_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _numero_Bultos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _inactivo_Por_Edicion;

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

        public Etiqueta_Embarque_Detalle1_1Model()
        {
        }

        public Etiqueta_Embarque_Detalle1_1Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Etiqueta_Embarque_Detalle_Id
        {
            get
            {
                return _etiqueta_Embarque_Detalle_Id;
            }
            set
            {
                _etiqueta_Embarque_Detalle_Id = value;
                UpdateFieldValue("Etiqueta_Embarque_Detalle_Id", value);
            }
        }

        public int? Folio_Etiqueta_Embarque_Detalle
        {
            get
            {
                return _folio_Etiqueta_Embarque_Detalle;
            }
            set
            {
                _folio_Etiqueta_Embarque_Detalle = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_Detalle", value);
            }
        }

        public int? Etiqueta_Embarque_Id
        {
            get
            {
                return _etiqueta_Embarque_Id;
            }
            set
            {
                _etiqueta_Embarque_Id = value;
                UpdateFieldValue("Etiqueta_Embarque_Id", value);
            }
        }

        public int? Folio_Etiqueta_Embarque
        {
            get
            {
                return _folio_Etiqueta_Embarque;
            }
            set
            {
                _folio_Etiqueta_Embarque = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque", value);
            }
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

        public string DC_S_Planta
        {
            get
            {
                return _dC_S_Planta;
            }
            set
            {
                _dC_S_Planta = value;
                UpdateFieldValue("DC_S_Planta", value);
            }
        }

        public string DC_S_Descripcion
        {
            get
            {
                return _dC_S_Descripcion;
            }
            set
            {
                _dC_S_Descripcion = value;
                UpdateFieldValue("DC_S_Descripcion", value);
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

        public string S_O
        {
            get
            {
                return _s_O;
            }
            set
            {
                _s_O = value;
                UpdateFieldValue("S_O", value);
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

        public int? Unidad_Material_Id
        {
            get
            {
                return _unidad_Material_Id;
            }
            set
            {
                _unidad_Material_Id = value;
                UpdateFieldValue("Unidad_Material_Id", value);
            }
        }

        public string Unidad_Material
        {
            get
            {
                return _unidad_Material;
            }
            set
            {
                _unidad_Material = value;
                UpdateFieldValue("Unidad_Material", value);
            }
        }

        public decimal? Cantidad_De_Bultos
        {
            get
            {
                return _cantidad_De_Bultos;
            }
            set
            {
                _cantidad_De_Bultos = value;
                UpdateFieldValue("Cantidad_De_Bultos", value);
            }
        }

        public decimal? Cantidad_En_Etiqueta_Detalle
        {
            get
            {
                return _cantidad_En_Etiqueta_Detalle;
            }
            set
            {
                _cantidad_En_Etiqueta_Detalle = value;
                UpdateFieldValue("Cantidad_En_Etiqueta_Detalle", value);
            }
        }

        public string Numero_Bultos
        {
            get
            {
                return _numero_Bultos;
            }
            set
            {
                _numero_Bultos = value;
                UpdateFieldValue("Numero_Bultos", value);
            }
        }

        public bool? Inactivo_Por_Edicion
        {
            get
            {
                return _inactivo_Por_Edicion;
            }
            set
            {
                _inactivo_Por_Edicion = value;
                UpdateFieldValue("Inactivo_Por_Edicion", value);
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

        public FieldValue this[Etiqueta_Embarque_Detalle1_1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
