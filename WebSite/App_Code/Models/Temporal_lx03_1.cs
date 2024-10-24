using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Temporal_lx03_1DataField
    {

        Temporal_lx03_Id,

        Typ,

        StorageBin,

        SLoc,

        Material,

        Plnt,

        TotalStock,

        Batch,

        S,

        S_2,

        SpecialStockNumber,

        TiL,

        Availablestock,

        Stockforputaway,

        GRDate,

        Time,

        Quant,

        Carga_Id,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Estatus_Procesamiento_Id,

        Estatus_Procesamiento,

        PO,

        Mensaje_Sistema,

        Mensaje_Sistema_Id,
    }

    public partial class Temporal_lx03_1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_lx03_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _typ;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storageBin;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sLoc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plnt;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _totalStock;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _batch;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _s;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _s_2;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _specialStockNumber;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tiL;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _availablestock;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stockforputaway;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gRDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _time;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _quant;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _carga_Id;

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
        private int? _estatus_Procesamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Procesamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _pO;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        public Temporal_lx03_1Model()
        {
        }

        public Temporal_lx03_1Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Temporal_lx03_Id
        {
            get
            {
                return _temporal_lx03_Id;
            }
            set
            {
                _temporal_lx03_Id = value;
                UpdateFieldValue("Temporal_lx03_Id", value);
            }
        }

        public string Typ
        {
            get
            {
                return _typ;
            }
            set
            {
                _typ = value;
                UpdateFieldValue("Typ", value);
            }
        }

        public string StorageBin
        {
            get
            {
                return _storageBin;
            }
            set
            {
                _storageBin = value;
                UpdateFieldValue("StorageBin", value);
            }
        }

        public string SLoc
        {
            get
            {
                return _sLoc;
            }
            set
            {
                _sLoc = value;
                UpdateFieldValue("SLoc", value);
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

        public string Plnt
        {
            get
            {
                return _plnt;
            }
            set
            {
                _plnt = value;
                UpdateFieldValue("Plnt", value);
            }
        }

        public string TotalStock
        {
            get
            {
                return _totalStock;
            }
            set
            {
                _totalStock = value;
                UpdateFieldValue("TotalStock", value);
            }
        }

        public string Batch
        {
            get
            {
                return _batch;
            }
            set
            {
                _batch = value;
                UpdateFieldValue("Batch", value);
            }
        }

        public string S
        {
            get
            {
                return _s;
            }
            set
            {
                _s = value;
                UpdateFieldValue("S", value);
            }
        }

        public string S_2
        {
            get
            {
                return _s_2;
            }
            set
            {
                _s_2 = value;
                UpdateFieldValue("S_2", value);
            }
        }

        public string SpecialStockNumber
        {
            get
            {
                return _specialStockNumber;
            }
            set
            {
                _specialStockNumber = value;
                UpdateFieldValue("SpecialStockNumber", value);
            }
        }

        public string TiL
        {
            get
            {
                return _tiL;
            }
            set
            {
                _tiL = value;
                UpdateFieldValue("TiL", value);
            }
        }

        public string Availablestock
        {
            get
            {
                return _availablestock;
            }
            set
            {
                _availablestock = value;
                UpdateFieldValue("Availablestock", value);
            }
        }

        public string Stockforputaway
        {
            get
            {
                return _stockforputaway;
            }
            set
            {
                _stockforputaway = value;
                UpdateFieldValue("Stockforputaway", value);
            }
        }

        public string GRDate
        {
            get
            {
                return _gRDate;
            }
            set
            {
                _gRDate = value;
                UpdateFieldValue("GRDate", value);
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                UpdateFieldValue("Time", value);
            }
        }

        public string Quant
        {
            get
            {
                return _quant;
            }
            set
            {
                _quant = value;
                UpdateFieldValue("Quant", value);
            }
        }

        public int? Carga_Id
        {
            get
            {
                return _carga_Id;
            }
            set
            {
                _carga_Id = value;
                UpdateFieldValue("Carga_Id", value);
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

        public decimal? PO
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

        public FieldValue this[Temporal_lx03_1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
