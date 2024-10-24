using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Grid_Movimiento_Transfer_Pte_VDataField
    {

        Fila,

        Area_Entrega_Id,

        Area_Entrega,

        Nivel_Prioridad_Surtido_Id,

        Nivel_Prioridad_Surtido,

        Nivel_Prioridad_Surtido_Valor,

        Usuario_Aplicacion_Id,

        Usuario_Id,

        Usuario_Sistema,

        Movimiento_Id,

        Movimiento_Folio,

        Tipo_Movimiento_Id,

        Tipo_Movimiento,

        Movimiento_Material,

        Movimiento_Solicitado_Por_Id,

        Movimiento_Solicitado_Por,

        Area_Servicio_Id,

        Area_Servicio,

        Fecha_Solicitud_Movimiento,

        Tmp_Mov_Ruta_Optima_Transaccion_Id,
    }

    public partial class Grid_Movimiento_Transfer_Pte_VModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _fila;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Entrega_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Entrega;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nivel_Prioridad_Surtido_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nivel_Prioridad_Surtido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nivel_Prioridad_Surtido_Valor;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usuario_Aplicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _movimiento_Folio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _tipo_Movimiento_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tipo_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _movimiento_Solicitado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _movimiento_Solicitado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _area_Servicio_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _area_Servicio;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud_Movimiento;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tmp_Mov_Ruta_Optima_Transaccion_Id;

        public Grid_Movimiento_Transfer_Pte_VModel()
        {
        }

        public Grid_Movimiento_Transfer_Pte_VModel(BusinessRules r) :
                base(r)
        {
        }

        public long? Fila
        {
            get
            {
                return _fila;
            }
            set
            {
                _fila = value;
                UpdateFieldValue("Fila", value);
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

        public string Area_Entrega
        {
            get
            {
                return _area_Entrega;
            }
            set
            {
                _area_Entrega = value;
                UpdateFieldValue("Area_Entrega", value);
            }
        }

        public int? Nivel_Prioridad_Surtido_Id
        {
            get
            {
                return _nivel_Prioridad_Surtido_Id;
            }
            set
            {
                _nivel_Prioridad_Surtido_Id = value;
                UpdateFieldValue("Nivel_Prioridad_Surtido_Id", value);
            }
        }

        public string Nivel_Prioridad_Surtido
        {
            get
            {
                return _nivel_Prioridad_Surtido;
            }
            set
            {
                _nivel_Prioridad_Surtido = value;
                UpdateFieldValue("Nivel_Prioridad_Surtido", value);
            }
        }

        public int? Nivel_Prioridad_Surtido_Valor
        {
            get
            {
                return _nivel_Prioridad_Surtido_Valor;
            }
            set
            {
                _nivel_Prioridad_Surtido_Valor = value;
                UpdateFieldValue("Nivel_Prioridad_Surtido_Valor", value);
            }
        }

        public int? Usuario_Aplicacion_Id
        {
            get
            {
                return _usuario_Aplicacion_Id;
            }
            set
            {
                _usuario_Aplicacion_Id = value;
                UpdateFieldValue("Usuario_Aplicacion_Id", value);
            }
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

        public string Usuario_Sistema
        {
            get
            {
                return _usuario_Sistema;
            }
            set
            {
                _usuario_Sistema = value;
                UpdateFieldValue("Usuario_Sistema", value);
            }
        }

        public long? Movimiento_Id
        {
            get
            {
                return _movimiento_Id;
            }
            set
            {
                _movimiento_Id = value;
                UpdateFieldValue("Movimiento_Id", value);
            }
        }

        public long? Movimiento_Folio
        {
            get
            {
                return _movimiento_Folio;
            }
            set
            {
                _movimiento_Folio = value;
                UpdateFieldValue("Movimiento_Folio", value);
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

        public string Tipo_Movimiento
        {
            get
            {
                return _tipo_Movimiento;
            }
            set
            {
                _tipo_Movimiento = value;
                UpdateFieldValue("Tipo_Movimiento", value);
            }
        }

        public string Movimiento_Material
        {
            get
            {
                return _movimiento_Material;
            }
            set
            {
                _movimiento_Material = value;
                UpdateFieldValue("Movimiento_Material", value);
            }
        }

        public System.Guid? Movimiento_Solicitado_Por_Id
        {
            get
            {
                return _movimiento_Solicitado_Por_Id;
            }
            set
            {
                _movimiento_Solicitado_Por_Id = value;
                UpdateFieldValue("Movimiento_Solicitado_Por_Id", value);
            }
        }

        public string Movimiento_Solicitado_Por
        {
            get
            {
                return _movimiento_Solicitado_Por;
            }
            set
            {
                _movimiento_Solicitado_Por = value;
                UpdateFieldValue("Movimiento_Solicitado_Por", value);
            }
        }

        public int? Area_Servicio_Id
        {
            get
            {
                return _area_Servicio_Id;
            }
            set
            {
                _area_Servicio_Id = value;
                UpdateFieldValue("Area_Servicio_Id", value);
            }
        }

        public string Area_Servicio
        {
            get
            {
                return _area_Servicio;
            }
            set
            {
                _area_Servicio = value;
                UpdateFieldValue("Area_Servicio", value);
            }
        }

        public DateTime? Fecha_Solicitud_Movimiento
        {
            get
            {
                return _fecha_Solicitud_Movimiento;
            }
            set
            {
                _fecha_Solicitud_Movimiento = value;
                UpdateFieldValue("Fecha_Solicitud_Movimiento", value);
            }
        }

        public string Tmp_Mov_Ruta_Optima_Transaccion_Id
        {
            get
            {
                return _tmp_Mov_Ruta_Optima_Transaccion_Id;
            }
            set
            {
                _tmp_Mov_Ruta_Optima_Transaccion_Id = value;
                UpdateFieldValue("Tmp_Mov_Ruta_Optima_Transaccion_Id", value);
            }
        }

        public FieldValue this[Grid_Movimiento_Transfer_Pte_VDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
