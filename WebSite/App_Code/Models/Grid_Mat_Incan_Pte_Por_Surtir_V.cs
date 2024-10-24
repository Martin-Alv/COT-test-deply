using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Mat_Incan_Pte_Por_Surtir_VDataField
    {

        Usuario_Id,

        Orden_Produccion_Id,

        Numero_Orden_Produccion,

        Area_Entrega_Id,

        Orden_Solicitud,

        Orden_Material,

        Orden_Solicitado_Por,

        Orden_Material_Id,

        Tmp_Ruta_Optima_Transaccion_Id,
    }

    public partial class Grid_Mat_Incan_Pte_Por_Surtir_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Solicitud;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Ruta_Optima_Transaccion_Id;

        public Grid_Mat_Incan_Pte_Por_Surtir_VModel()
        {
        }

        public Grid_Mat_Incan_Pte_Por_Surtir_VModel(BusinessRules r) :
                base(r)
        {
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

        public string Orden_Solicitud
        {
            get
            {
                return _orden_Solicitud;
            }
            set
            {
                _orden_Solicitud = value;
                UpdateFieldValue("Orden_Solicitud", value);
            }
        }

        public string Orden_Material
        {
            get
            {
                return _orden_Material;
            }
            set
            {
                _orden_Material = value;
                UpdateFieldValue("Orden_Material", value);
            }
        }

        public string Orden_Solicitado_Por
        {
            get
            {
                return _orden_Solicitado_Por;
            }
            set
            {
                _orden_Solicitado_Por = value;
                UpdateFieldValue("Orden_Solicitado_Por", value);
            }
        }

        public string Orden_Material_Id
        {
            get
            {
                return _orden_Material_Id;
            }
            set
            {
                _orden_Material_Id = value;
                UpdateFieldValue("Orden_Material_Id", value);
            }
        }

        public string Tmp_Ruta_Optima_Transaccion_Id
        {
            get
            {
                return _tmp_Ruta_Optima_Transaccion_Id;
            }
            set
            {
                _tmp_Ruta_Optima_Transaccion_Id = value;
                UpdateFieldValue("Tmp_Ruta_Optima_Transaccion_Id", value);
            }
        }

        public FieldValue this[Grid_Mat_Incan_Pte_Por_Surtir_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
