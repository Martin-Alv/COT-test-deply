using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Prueba_Hoja_Pdf_VDataField
    {

        Ruta_Optima_Id,

        Material_Solicitado_Id,

        Material,

        Material_QR,

        Cantidad_Entregado,

        Cantidad_Entregado_QR,

        Ubicacion_Almacenamiento,

        Ubicacion_Origen_QR,

        Clave_Tipo_Ubicacion,

        Ubicacion_Destino_QR,

        Surtido_Por_Id,

        Material_Ubicacion_Almacenamiento_De_Surtido_Id,
    }

    public partial class Grid_Prueba_Hoja_Pdf_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cantidad_Entregado_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Origen_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _clave_Tipo_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Destino_QR;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _surtido_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Almacenamiento_De_Surtido_Id;

        public Grid_Prueba_Hoja_Pdf_VModel()
        {
        }

        public Grid_Prueba_Hoja_Pdf_VModel(BusinessRules r) :
                base(r)
        {
        }

        public long? Ruta_Optima_Id
        {
            get
            {
                return _ruta_Optima_Id;
            }
            set
            {
                _ruta_Optima_Id = value;
                UpdateFieldValue("Ruta_Optima_Id", value);
            }
        }

        public long? Material_Solicitado_Id
        {
            get
            {
                return _material_Solicitado_Id;
            }
            set
            {
                _material_Solicitado_Id = value;
                UpdateFieldValue("Material_Solicitado_Id", value);
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

        public decimal? Cantidad_Entregado
        {
            get
            {
                return _cantidad_Entregado;
            }
            set
            {
                _cantidad_Entregado = value;
                UpdateFieldValue("Cantidad_Entregado", value);
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

        public int? Clave_Tipo_Ubicacion
        {
            get
            {
                return _clave_Tipo_Ubicacion;
            }
            set
            {
                _clave_Tipo_Ubicacion = value;
                UpdateFieldValue("Clave_Tipo_Ubicacion", value);
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

        public System.Guid? Surtido_Por_Id
        {
            get
            {
                return _surtido_Por_Id;
            }
            set
            {
                _surtido_Por_Id = value;
                UpdateFieldValue("Surtido_Por_Id", value);
            }
        }

        public long? Material_Ubicacion_Almacenamiento_De_Surtido_Id
        {
            get
            {
                return _material_Ubicacion_Almacenamiento_De_Surtido_Id;
            }
            set
            {
                _material_Ubicacion_Almacenamiento_De_Surtido_Id = value;
                UpdateFieldValue("Material_Ubicacion_Almacenamiento_De_Surtido_Id", value);
            }
        }

        public FieldValue this[Grid_Prueba_Hoja_Pdf_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
