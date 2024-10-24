using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Mov_Transfer_Ruta_Optima_A_Ejecutar_VDataField
    {

        Tmp_Ruta_Optima_Transaccion_Id,

        Numero_Grupo_Ruta_Optima,

        Movimiento_Ruta_Optima_Id,

        Cantidad_A_Transferir,

        Transferencia_En_Ubicacion_Almacenamiento_Id,

        Creado_Por_Id,

        Transaccion_Id,

        Tipo_Movimiento_Id,

        Transferencia_Material_Id,

        Transferencia_Material,

        Transferencia_Material_Desc,

        Cantidad_Transferido,

        Unidad_Material_Transferido_Id,

        Unidad_Material_Transferido,

        Transferencia_En_Ubicacion_Almacenamiento,

        Transferencia_Ubicacion_Almacenamiento_Id,

        Transferencia_Ubicacion_Almacenamiento,

        Movimiento,

        Material_Ubicacion_Stock_Id,

        Tiene_RH,
    }

    public partial class Mov_Transfer_Ruta_Optima_A_Ejecutar_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Ruta_Optima_Transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _numero_Grupo_Ruta_Optima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Ruta_Optima_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_A_Transferir;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_En_Ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _transferencia_Material_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Material_Desc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Transferido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Transferido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Transferido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_En_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transferencia_Ubicacion_Almacenamiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transferencia_Ubicacion_Almacenamiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Ubicacion_Stock_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _tiene_RH;

        public Mov_Transfer_Ruta_Optima_A_Ejecutar_VModel()
        {
        }

        public Mov_Transfer_Ruta_Optima_A_Ejecutar_VModel(BusinessRules r) :
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

        public decimal? Cantidad_A_Transferir
        {
            get
            {
                return _cantidad_A_Transferir;
            }
            set
            {
                _cantidad_A_Transferir = value;
                UpdateFieldValue("Cantidad_A_Transferir", value);
            }
        }

        public int? Transferencia_En_Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _transferencia_En_Ubicacion_Almacenamiento_Id;
            }
            set
            {
                _transferencia_En_Ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Transferencia_En_Ubicacion_Almacenamiento_Id", value);
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

        public long? Transferencia_Material_Id
        {
            get
            {
                return _transferencia_Material_Id;
            }
            set
            {
                _transferencia_Material_Id = value;
                UpdateFieldValue("Transferencia_Material_Id", value);
            }
        }

        public string Transferencia_Material
        {
            get
            {
                return _transferencia_Material;
            }
            set
            {
                _transferencia_Material = value;
                UpdateFieldValue("Transferencia_Material", value);
            }
        }

        public string Transferencia_Material_Desc
        {
            get
            {
                return _transferencia_Material_Desc;
            }
            set
            {
                _transferencia_Material_Desc = value;
                UpdateFieldValue("Transferencia_Material_Desc", value);
            }
        }

        public decimal? Cantidad_Transferido
        {
            get
            {
                return _cantidad_Transferido;
            }
            set
            {
                _cantidad_Transferido = value;
                UpdateFieldValue("Cantidad_Transferido", value);
            }
        }

        public int? Unidad_Material_Transferido_Id
        {
            get
            {
                return _unidad_Material_Transferido_Id;
            }
            set
            {
                _unidad_Material_Transferido_Id = value;
                UpdateFieldValue("Unidad_Material_Transferido_Id", value);
            }
        }

        public string Unidad_Material_Transferido
        {
            get
            {
                return _unidad_Material_Transferido;
            }
            set
            {
                _unidad_Material_Transferido = value;
                UpdateFieldValue("Unidad_Material_Transferido", value);
            }
        }

        public string Transferencia_En_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_En_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_En_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_En_Ubicacion_Almacenamiento", value);
            }
        }

        public int? Transferencia_Ubicacion_Almacenamiento_Id
        {
            get
            {
                return _transferencia_Ubicacion_Almacenamiento_Id;
            }
            set
            {
                _transferencia_Ubicacion_Almacenamiento_Id = value;
                UpdateFieldValue("Transferencia_Ubicacion_Almacenamiento_Id", value);
            }
        }

        public string Transferencia_Ubicacion_Almacenamiento
        {
            get
            {
                return _transferencia_Ubicacion_Almacenamiento;
            }
            set
            {
                _transferencia_Ubicacion_Almacenamiento = value;
                UpdateFieldValue("Transferencia_Ubicacion_Almacenamiento", value);
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

        public bool? Tiene_RH
        {
            get
            {
                return _tiene_RH;
            }
            set
            {
                _tiene_RH = value;
                UpdateFieldValue("Tiene_RH", value);
            }
        }

        public FieldValue this[Mov_Transfer_Ruta_Optima_A_Ejecutar_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
