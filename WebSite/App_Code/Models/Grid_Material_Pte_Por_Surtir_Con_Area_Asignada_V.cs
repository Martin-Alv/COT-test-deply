using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VDataField
    {

        Usuario_Id,

        Material_Id,

        Material,

        Material_Descripcion,

        Cantidad_Solicitado,

        Material_Unidad_Material_Id,

        Unidad_Material_Id,

        Unidad_Material,

        Ubicacion_Almacenamiento_Id,

        Ubicacion_Almacenamiento,

        Orden_Produccion_Solicitud_Material,

        Solicitado_Por,

        Material_Ubicacion_Stock_Id,

        Tmp_Material_Surtido_Transaccion_Id,

        Material_QR,

        Cantidad_Entregado_QR,

        Ubicacion_Origen_QR,

        Ubicacion_Destino_QR,
    }

    public partial class Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Unidad_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orden_Produccion_Solicitud_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Stock_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Material_Surtido_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cantidad_Entregado_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Origen_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Destino_QR;

        public Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VModel()
        {
        }

        public Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VModel(BusinessRules r) :
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

        public long? Material_Unidad_Material_Id
        {
            get
            {
                return _material_Unidad_Material_Id;
            }
            set
            {
                _material_Unidad_Material_Id = value;
                UpdateFieldValue("Material_Unidad_Material_Id", value);
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

        public int? Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _ubicacion_Almacenamiento_Id;
            }
            set
            {
                _ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_Id", value);
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

        public string Orden_Produccion_Solicitud_Material
        {
            get
            {
                return _orden_Produccion_Solicitud_Material;
            }
            set
            {
                _orden_Produccion_Solicitud_Material = value;
                UpdateFieldValue("Orden_Produccion_Solicitud_Material", value);
            }
        }

        public string Solicitado_Por
        {
            get
            {
                return _solicitado_Por;
            }
            set
            {
                _solicitado_Por = value;
                UpdateFieldValue("Solicitado_Por", value);
            }
        }

        public long? Material_Ubicacion_Stock_Id
        {
            get
            {
                return _material_Ubicacion_Stock_Id;
            }
            set
            {
                _material_Ubicacion_Stock_Id = value;
                UpdateFieldValue("Material_Ubicacion_Stock_Id", value);
            }
        }

        public string Tmp_Material_Surtido_Transaccion_Id
        {
            get
            {
                return _tmp_Material_Surtido_Transaccion_Id;
            }
            set
            {
                _tmp_Material_Surtido_Transaccion_Id = value;
                UpdateFieldValue("Tmp_Material_Surtido_Transaccion_Id", value);
            }
        }

        public string Material_QR
        {
            get
            {
                return _material_QR;
            }
            set
            {
                _material_QR = value;
                UpdateFieldValue("Material_QR", value);
            }
        }

        public string Cantidad_Entregado_QR
        {
            get
            {
                return _cantidad_Entregado_QR;
            }
            set
            {
                _cantidad_Entregado_QR = value;
                UpdateFieldValue("Cantidad_Entregado_QR", value);
            }
        }

        public string Ubicacion_Origen_QR
        {
            get
            {
                return _ubicacion_Origen_QR;
            }
            set
            {
                _ubicacion_Origen_QR = value;
                UpdateFieldValue("Ubicacion_Origen_QR", value);
            }
        }

        public string Ubicacion_Destino_QR
        {
            get
            {
                return _ubicacion_Destino_QR;
            }
            set
            {
                _ubicacion_Destino_QR = value;
                UpdateFieldValue("Ubicacion_Destino_QR", value);
            }
        }

        public FieldValue this[Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
