using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Temporal_ZINV1DataField
    {

        Temporal_ZINV_Id,

        Plant,

        S_Loc,

        Stock_Category,

        Storage_Type,

        Storage_Bin,

        Material_Number,

        Total_Stock,

        Total_Value,

        Phy_Inv_Ind_CC,

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

    public partial class Temporal_ZINV1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _temporal_ZINV_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _plant;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _s_Loc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stock_Category;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storage_Type;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storage_Bin;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Number;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _total_Stock;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _total_Value;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phy_Inv_Ind_CC;

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

        public Temporal_ZINV1Model()
        {
        }

        public Temporal_ZINV1Model(BusinessRules r) :
                base(r)
        {
        }

        public int? Temporal_ZINV_Id
        {
            get
            {
                return _temporal_ZINV_Id;
            }
            set
            {
                _temporal_ZINV_Id = value;
                UpdateFieldValue("Temporal_ZINV_Id", value);
            }
        }

        public string Plant
        {
            get
            {
                return _plant;
            }
            set
            {
                _plant = value;
                UpdateFieldValue("Plant", value);
            }
        }

        public string S_Loc
        {
            get
            {
                return _s_Loc;
            }
            set
            {
                _s_Loc = value;
                UpdateFieldValue("S_Loc", value);
            }
        }

        public string Stock_Category
        {
            get
            {
                return _stock_Category;
            }
            set
            {
                _stock_Category = value;
                UpdateFieldValue("Stock_Category", value);
            }
        }

        public string Storage_Type
        {
            get
            {
                return _storage_Type;
            }
            set
            {
                _storage_Type = value;
                UpdateFieldValue("Storage_Type", value);
            }
        }

        public string Storage_Bin
        {
            get
            {
                return _storage_Bin;
            }
            set
            {
                _storage_Bin = value;
                UpdateFieldValue("Storage_Bin", value);
            }
        }

        public string Material_Number
        {
            get
            {
                return _material_Number;
            }
            set
            {
                _material_Number = value;
                UpdateFieldValue("Material_Number", value);
            }
        }

        public string Total_Stock
        {
            get
            {
                return _total_Stock;
            }
            set
            {
                _total_Stock = value;
                UpdateFieldValue("Total_Stock", value);
            }
        }

        public string Total_Value
        {
            get
            {
                return _total_Value;
            }
            set
            {
                _total_Value = value;
                UpdateFieldValue("Total_Value", value);
            }
        }

        public string Phy_Inv_Ind_CC
        {
            get
            {
                return _phy_Inv_Ind_CC;
            }
            set
            {
                _phy_Inv_Ind_CC = value;
                UpdateFieldValue("Phy_Inv_Ind_CC", value);
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

        public FieldValue this[Temporal_ZINV1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
