using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
	public partial class Ruta_Optima_A_Ejecutar_VModel : BusinessRulesObjectModel
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _ruta_Optima_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Grupo_Ruta_Optima;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _numero_Orden_Produccion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Produccion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _orden_Produccion_Detalle_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _material_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Descripcion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ubicacion_Almacenamiento;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _transaccion_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Entregado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _solicitud_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Solicitud;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _unidad_Material_Entregado_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _unidad_Material_Entregado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _producto_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Solicitado;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ubicacion_Almacenamiento_Id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _boton_Actualizar_Ruta_Optima;
        
        public Ruta_Optima_A_Ejecutar_VModel()
        {
        }
        
        public Ruta_Optima_A_Ejecutar_VModel(BusinessRules r) : 
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
        
        public DateTime? Fecha_Produccion
        {
            get
            {
                return _fecha_Produccion;
            }
            set
            {
                _fecha_Produccion = value;
                UpdateFieldValue("Fecha_Produccion", value);
            }
        }
        
        public long? Orden_Produccion_Detalle_Id
        {
            get
            {
                return _orden_Produccion_Detalle_Id;
            }
            set
            {
                _orden_Produccion_Detalle_Id = value;
                UpdateFieldValue("Orden_Produccion_Detalle_Id", value);
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
        
        public long? Solicitud_Id
        {
            get
            {
                return _solicitud_Id;
            }
            set
            {
                _solicitud_Id = value;
                UpdateFieldValue("Solicitud_Id", value);
            }
        }
        
        public DateTime? Fecha_Solicitud
        {
            get
            {
                return _fecha_Solicitud;
            }
            set
            {
                _fecha_Solicitud = value;
                UpdateFieldValue("Fecha_Solicitud", value);
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
        
        public string Boton_Actualizar_Ruta_Optima
        {
            get
            {
                return _boton_Actualizar_Ruta_Optima;
            }
            set
            {
                _boton_Actualizar_Ruta_Optima = value;
                UpdateFieldValue("Boton_Actualizar_Ruta_Optima", value);
            }
        }
    }
}
