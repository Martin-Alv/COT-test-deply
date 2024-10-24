using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Ruta_Optima_Incan_A_Ejecutar_VDataField
    {

        Tmp_Ruta_Optima_Transaccion_Id,

        Numero_Grupo_Ruta_Optima,

        Ruta_Optima_Id,

        Material_Id,

        Material,

        Material_Descripcion,

        Unidad_Material_Solicitado_Id,

        Unidad_Material_Solicitado,

        Material_Unidad_Material_Id,

        Unidad_Material_Id,

        Unidad_Material,

        Cantidad_Solicitado,

        Unidad_Material_Entregado_Id,

        Unidad_Material_Entregado,

        Cantidad_Entregado,

        Ubicacion_Almacenamiento_Id,

        Ubicacion_Almacenamiento,

        Ubicacion_Almacenamiento_De_Surtido_Id,

        Ubicacion_Almacenamiento_De_Surtido,

        Creado_Por_Id,

        Transaccion_Id,

        Solicitud_Material,

        Tiempo_Transcurrido,

        Material_Ubicacion,

        Material_Ubicacion_Stock_Id,

        Total_Stock_En_Ubicacion_Almacenamiento_Seleccionado,
    }

    public partial class Grid_Ruta_Optima_Incan_A_Ejecutar_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Ruta_Optima_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Solicitado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Unidad_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_De_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento_De_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _solicitud_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tiempo_Transcurrido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Ubicacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Stock_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _total_Stock_En_Ubicacion_Almacenamiento_Seleccionado;

        public Grid_Ruta_Optima_Incan_A_Ejecutar_VModel()
        {
        }

        public Grid_Ruta_Optima_Incan_A_Ejecutar_VModel(BusinessRules r) :
                base(r)
        {
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

        public int? Numero_Grupo_Ruta_Optima
        {
            get
            {
                return _numero_Grupo_Ruta_Optima;
            }
            set
            {
                _numero_Grupo_Ruta_Optima = value;
                UpdateFieldValue("Numero_Grupo_Ruta_Optima", value);
            }
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

        public int? Unidad_Material_Solicitado_Id
        {
            get
            {
                return _unidad_Material_Solicitado_Id;
            }
            set
            {
                _unidad_Material_Solicitado_Id = value;
                UpdateFieldValue("Unidad_Material_Solicitado_Id", value);
            }
        }

        public string Unidad_Material_Solicitado
        {
            get
            {
                return _unidad_Material_Solicitado;
            }
            set
            {
                _unidad_Material_Solicitado = value;
                UpdateFieldValue("Unidad_Material_Solicitado", value);
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

        public int? Unidad_Material_Entregado_Id
        {
            get
            {
                return _unidad_Material_Entregado_Id;
            }
            set
            {
                _unidad_Material_Entregado_Id = value;
                UpdateFieldValue("Unidad_Material_Entregado_Id", value);
            }
        }

        public string Unidad_Material_Entregado
        {
            get
            {
                return _unidad_Material_Entregado;
            }
            set
            {
                _unidad_Material_Entregado = value;
                UpdateFieldValue("Unidad_Material_Entregado", value);
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

        public int? Ubicacion_Almacenamiento_De_Surtido_Id
        {
            get
            {
                return _ubicacion_Almacenamiento_De_Surtido_Id;
            }
            set
            {
                _ubicacion_Almacenamiento_De_Surtido_Id = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_De_Surtido_Id", value);
            }
        }

        public string Ubicacion_Almacenamiento_De_Surtido
        {
            get
            {
                return _ubicacion_Almacenamiento_De_Surtido;
            }
            set
            {
                _ubicacion_Almacenamiento_De_Surtido = value;
                UpdateFieldValue("Ubicacion_Almacenamiento_De_Surtido", value);
            }
        }

        public System.Guid? Creado_Por_Id
        {
            get
            {
                return _creado_Por_Id;
            }
            set
            {
                _creado_Por_Id = value;
                UpdateFieldValue("Creado_Por_Id", value);
            }
        }

        public string Transaccion_Id
        {
            get
            {
                return _transaccion_Id;
            }
            set
            {
                _transaccion_Id = value;
                UpdateFieldValue("Transaccion_Id", value);
            }
        }

        public string Solicitud_Material
        {
            get
            {
                return _solicitud_Material;
            }
            set
            {
                _solicitud_Material = value;
                UpdateFieldValue("Solicitud_Material", value);
            }
        }

        public int? Tiempo_Transcurrido
        {
            get
            {
                return _tiempo_Transcurrido;
            }
            set
            {
                _tiempo_Transcurrido = value;
                UpdateFieldValue("Tiempo_Transcurrido", value);
            }
        }

        public string Material_Ubicacion
        {
            get
            {
                return _material_Ubicacion;
            }
            set
            {
                _material_Ubicacion = value;
                UpdateFieldValue("Material_Ubicacion", value);
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

        public decimal? Total_Stock_En_Ubicacion_Almacenamiento_Seleccionado
        {
            get
            {
                return _total_Stock_En_Ubicacion_Almacenamiento_Seleccionado;
            }
            set
            {
                _total_Stock_En_Ubicacion_Almacenamiento_Seleccionado = value;
                UpdateFieldValue("Total_Stock_En_Ubicacion_Almacenamiento_Seleccionado", value);
            }
        }

        public FieldValue this[Grid_Ruta_Optima_Incan_A_Ejecutar_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
