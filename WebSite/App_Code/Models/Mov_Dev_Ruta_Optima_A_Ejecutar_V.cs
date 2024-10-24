using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Mov_Dev_Ruta_Optima_A_Ejecutar_VDataField
    {

        Tmp_Ruta_Optima_Transaccion_Id,

        Numero_Grupo_Ruta_Optima,

        Movimiento_Ruta_Optima_Id,

        Cantidad_A_Devolver,

        Unidad_Material_Devuelto_Id,

        Devolucion_En_Ubicacion_Almacenamiento_Id,

        Devolucion_En_Ubicacion_Almacenamiento,

        Creado_Por_Id,

        Transaccion_Id,

        Devolucion_Ubicacion_Almacenamiento_Id,

        Devolucion_Material_Id,

        Devolucion_Material,

        Devolucion_Material_Desc,

        Devolucion_Ubicacion_Almacenamiento,

        Cantidad_Devuelto,

        Unidad_Material_Devuelto,

        Movimiento,

        Tipo_Movimiento_Id,

        Material_Ubicacion_Stock_Id,
    }

    public partial class Mov_Dev_Ruta_Optima_A_Ejecutar_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Ruta_Optima_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_A_Devolver;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Devuelto_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_En_Ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_En_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _devolucion_Ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _devolucion_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Material_Desc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _devolucion_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Devuelto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Devuelto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Stock_Id;

        public Mov_Dev_Ruta_Optima_A_Ejecutar_VModel()
        {
        }

        public Mov_Dev_Ruta_Optima_A_Ejecutar_VModel(BusinessRules r) :
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

        public decimal? Numero_Grupo_Ruta_Optima
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

        public long? Movimiento_Ruta_Optima_Id
        {
            get
            {
                return _movimiento_Ruta_Optima_Id;
            }
            set
            {
                _movimiento_Ruta_Optima_Id = value;
                UpdateFieldValue("Movimiento_Ruta_Optima_Id", value);
            }
        }

        public decimal? Cantidad_A_Devolver
        {
            get
            {
                return _cantidad_A_Devolver;
            }
            set
            {
                _cantidad_A_Devolver = value;
                UpdateFieldValue("Cantidad_A_Devolver", value);
            }
        }

        public int? Unidad_Material_Devuelto_Id
        {
            get
            {
                return _unidad_Material_Devuelto_Id;
            }
            set
            {
                _unidad_Material_Devuelto_Id = value;
                UpdateFieldValue("Unidad_Material_Devuelto_Id", value);
            }
        }

        public int? Devolucion_En_Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _devolucion_En_Ubicacion_Almacenamiento_Id;
            }
            set
            {
                _devolucion_En_Ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Devolucion_En_Ubicacion_Almacenamiento_Id", value);
            }
        }

        public string Devolucion_En_Ubicacion_Almacenamiento
        {
            get
            {
                return _devolucion_En_Ubicacion_Almacenamiento;
            }
            set
            {
                _devolucion_En_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Devolucion_En_Ubicacion_Almacenamiento", value);
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

        public int? Devolucion_Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _devolucion_Ubicacion_Almacenamiento_Id;
            }
            set
            {
                _devolucion_Ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Devolucion_Ubicacion_Almacenamiento_Id", value);
            }
        }

        public long? Devolucion_Material_Id
        {
            get
            {
                return _devolucion_Material_Id;
            }
            set
            {
                _devolucion_Material_Id = value;
                UpdateFieldValue("Devolucion_Material_Id", value);
            }
        }

        public string Devolucion_Material
        {
            get
            {
                return _devolucion_Material;
            }
            set
            {
                _devolucion_Material = value;
                UpdateFieldValue("Devolucion_Material", value);
            }
        }

        public string Devolucion_Material_Desc
        {
            get
            {
                return _devolucion_Material_Desc;
            }
            set
            {
                _devolucion_Material_Desc = value;
                UpdateFieldValue("Devolucion_Material_Desc", value);
            }
        }

        public string Devolucion_Ubicacion_Almacenamiento
        {
            get
            {
                return _devolucion_Ubicacion_Almacenamiento;
            }
            set
            {
                _devolucion_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Devolucion_Ubicacion_Almacenamiento", value);
            }
        }

        public decimal? Cantidad_Devuelto
        {
            get
            {
                return _cantidad_Devuelto;
            }
            set
            {
                _cantidad_Devuelto = value;
                UpdateFieldValue("Cantidad_Devuelto", value);
            }
        }

        public string Unidad_Material_Devuelto
        {
            get
            {
                return _unidad_Material_Devuelto;
            }
            set
            {
                _unidad_Material_Devuelto = value;
                UpdateFieldValue("Unidad_Material_Devuelto", value);
            }
        }

        public string Movimiento
        {
            get
            {
                return _movimiento;
            }
            set
            {
                _movimiento = value;
                UpdateFieldValue("Movimiento", value);
            }
        }

        public int? Tipo_Movimiento_Id
        {
            get
            {
                return _tipo_Movimiento_Id;
            }
            set
            {
                _tipo_Movimiento_Id = value;
                UpdateFieldValue("Tipo_Movimiento_Id", value);
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

        public FieldValue this[Mov_Dev_Ruta_Optima_A_Ejecutar_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
