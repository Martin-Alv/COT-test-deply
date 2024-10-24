using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Escaneo_Validador_Embarque1DataField
    {

        Escaneo_Validador_Embarque_Id,

        Folio_Escaneo,

        Seccion_Capturada,

        Material_Tarima,

        SOrde_SItem_Tarima,

        Etiqueta_Embarque_Detalle_Id,

        EtiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle,

        Folio_Etiqueta_Embarque_Detalle,

        Material_Embarque,

        SOrde_SItem_Emabarque,

        Delivery_Id,

        Delivery,

        Delivery_Delivery,

        Material_Delivery,

        SOrde_SItem_Delivery,

        Delivery_Packing_List,

        Sorder_Sitem_Packing_List,

        Cantidad_Material,

        Resultado_Validacion_Embarque_Id,

        Resultado_Validacion_Embarque,

        Es_Correcto,

        Es_Incorrecto,

        Es_Correcto_En_Progreso,

        Es_Incorrecto_En_Progreso,

        Mensaje_Sistema_Id,

        Transaccion_Escaneo,

        Mensaje_Sistema,

        Creado_Por,

        Fecha_Creacion,

        Actualizado_Por,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        MensajeValidacionAplicada,

        Creado_Por_Id,

        Folio_Etiqueta_Embarque,

        Material_Tarima_Dos,

        SOrde_SItem_Tarima_Dos,

        SOrde_SItem_Packing_List,

        Folio_Etiqueta_Embarque_Tres,

        Material_Tarima_Tres,

        SOrde_SItem_Tarima_Tres,

        Delivery_Dos,

        Resultado_Validacion,

        Folio_Etiqueta_Embarque_SeccionUno,

        Folio_Etiqueta_Embarque_SeccionDos,

        Folio_Etiqueta_Embarque_SeccionTres,

        Delivery_SeccionTres,

        Folio_Escaneo_Id,

        Mostrar_Campos_Sistema,

        Folio_Escaneo_Anterior,

        Captura_Iniciada,

        Sales_Order_Uno,

        Sales_Item_Uno,

        Sales_Order_Dos,

        Sales_Item_Dos,

        Sales_Order_Tres,

        Sales_Item_Tres,

        Sales_Order_Packing,

        Sales_Item_Packing,
    }

    public partial class Escaneo_Validador_Embarque1Model : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _escaneo_Validador_Embarque_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _folio_Escaneo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _seccion_Capturada;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Tarima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Tarima;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiqueta_Embarque_Detalle_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _etiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _folio_Etiqueta_Embarque_Detalle;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Embarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Emabarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _delivery_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _delivery;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delivery_Delivery;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Delivery;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Delivery;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delivery_Packing_List;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sorder_Sitem_Packing_List;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _cantidad_Material;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _resultado_Validacion_Embarque_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _resultado_Validacion_Embarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Correcto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Incorrecto;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Correcto_En_Progreso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _es_Incorrecto_En_Progreso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _mensaje_Sistema_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _transaccion_Escaneo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mensaje_Sistema;

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
        private string _mensajeValidacionAplicada;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _creado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio_Etiqueta_Embarque;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Tarima_Dos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Tarima_Dos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Packing_List;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _folio_Etiqueta_Embarque_Tres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _material_Tarima_Tres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sOrde_SItem_Tarima_Tres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _delivery_Dos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _resultado_Validacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _folio_Etiqueta_Embarque_SeccionUno;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _folio_Etiqueta_Embarque_SeccionDos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _folio_Etiqueta_Embarque_SeccionTres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _delivery_SeccionTres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _folio_Escaneo_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _mostrar_Campos_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _folio_Escaneo_Anterior;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _captura_Iniciada;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Order_Uno;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Item_Uno;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Order_Dos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Item_Dos;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Order_Tres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Item_Tres;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Order_Packing;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sales_Item_Packing;

        public Escaneo_Validador_Embarque1Model()
        {
        }

        public Escaneo_Validador_Embarque1Model(BusinessRules r) :
                base(r)
        {
        }

        public long? Escaneo_Validador_Embarque_Id
        {
            get
            {
                return _escaneo_Validador_Embarque_Id;
            }
            set
            {
                _escaneo_Validador_Embarque_Id = value;
                UpdateFieldValue("Escaneo_Validador_Embarque_Id", value);
            }
        }

        public long? Folio_Escaneo
        {
            get
            {
                return _folio_Escaneo;
            }
            set
            {
                _folio_Escaneo = value;
                UpdateFieldValue("Folio_Escaneo", value);
            }
        }

        public short? Seccion_Capturada
        {
            get
            {
                return _seccion_Capturada;
            }
            set
            {
                _seccion_Capturada = value;
                UpdateFieldValue("Seccion_Capturada", value);
            }
        }

        public string Material_Tarima
        {
            get
            {
                return _material_Tarima;
            }
            set
            {
                _material_Tarima = value;
                UpdateFieldValue("Material_Tarima", value);
            }
        }

        public string SOrde_SItem_Tarima
        {
            get
            {
                return _sOrde_SItem_Tarima;
            }
            set
            {
                _sOrde_SItem_Tarima = value;
                UpdateFieldValue("SOrde_SItem_Tarima", value);
            }
        }

        public int? Etiqueta_Embarque_Detalle_Id
        {
            get
            {
                return _etiqueta_Embarque_Detalle_Id;
            }
            set
            {
                _etiqueta_Embarque_Detalle_Id = value;
                UpdateFieldValue("Etiqueta_Embarque_Detalle_Id", value);
            }
        }

        public int? EtiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle
        {
            get
            {
                return _etiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle;
            }
            set
            {
                _etiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle = value;
                UpdateFieldValue("EtiquetaEmbarqueDetalleFolioEtiquetaEmbarqueDetalle", value);
            }
        }

        public string Folio_Etiqueta_Embarque_Detalle
        {
            get
            {
                return _folio_Etiqueta_Embarque_Detalle;
            }
            set
            {
                _folio_Etiqueta_Embarque_Detalle = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_Detalle", value);
            }
        }

        public string Material_Embarque
        {
            get
            {
                return _material_Embarque;
            }
            set
            {
                _material_Embarque = value;
                UpdateFieldValue("Material_Embarque", value);
            }
        }

        public string SOrde_SItem_Emabarque
        {
            get
            {
                return _sOrde_SItem_Emabarque;
            }
            set
            {
                _sOrde_SItem_Emabarque = value;
                UpdateFieldValue("SOrde_SItem_Emabarque", value);
            }
        }

        public long? Delivery_Id
        {
            get
            {
                return _delivery_Id;
            }
            set
            {
                _delivery_Id = value;
                UpdateFieldValue("Delivery_Id", value);
            }
        }

        public long? Delivery
        {
            get
            {
                return _delivery;
            }
            set
            {
                _delivery = value;
                UpdateFieldValue("Delivery", value);
            }
        }

        public string Delivery_Delivery
        {
            get
            {
                return _delivery_Delivery;
            }
            set
            {
                _delivery_Delivery = value;
                UpdateFieldValue("Delivery_Delivery", value);
            }
        }

        public string Material_Delivery
        {
            get
            {
                return _material_Delivery;
            }
            set
            {
                _material_Delivery = value;
                UpdateFieldValue("Material_Delivery", value);
            }
        }

        public string SOrde_SItem_Delivery
        {
            get
            {
                return _sOrde_SItem_Delivery;
            }
            set
            {
                _sOrde_SItem_Delivery = value;
                UpdateFieldValue("SOrde_SItem_Delivery", value);
            }
        }

        public string Delivery_Packing_List
        {
            get
            {
                return _delivery_Packing_List;
            }
            set
            {
                _delivery_Packing_List = value;
                UpdateFieldValue("Delivery_Packing_List", value);
            }
        }

        public string Sorder_Sitem_Packing_List
        {
            get
            {
                return _sorder_Sitem_Packing_List;
            }
            set
            {
                _sorder_Sitem_Packing_List = value;
                UpdateFieldValue("Sorder_Sitem_Packing_List", value);
            }
        }

        public decimal? Cantidad_Material
        {
            get
            {
                return _cantidad_Material;
            }
            set
            {
                _cantidad_Material = value;
                UpdateFieldValue("Cantidad_Material", value);
            }
        }

        public int? Resultado_Validacion_Embarque_Id
        {
            get
            {
                return _resultado_Validacion_Embarque_Id;
            }
            set
            {
                _resultado_Validacion_Embarque_Id = value;
                UpdateFieldValue("Resultado_Validacion_Embarque_Id", value);
            }
        }

        public string Resultado_Validacion_Embarque
        {
            get
            {
                return _resultado_Validacion_Embarque;
            }
            set
            {
                _resultado_Validacion_Embarque = value;
                UpdateFieldValue("Resultado_Validacion_Embarque", value);
            }
        }

        public bool? Es_Correcto
        {
            get
            {
                return _es_Correcto;
            }
            set
            {
                _es_Correcto = value;
                UpdateFieldValue("Es_Correcto", value);
            }
        }

        public bool? Es_Incorrecto
        {
            get
            {
                return _es_Incorrecto;
            }
            set
            {
                _es_Incorrecto = value;
                UpdateFieldValue("Es_Incorrecto", value);
            }
        }

        public bool? Es_Correcto_En_Progreso
        {
            get
            {
                return _es_Correcto_En_Progreso;
            }
            set
            {
                _es_Correcto_En_Progreso = value;
                UpdateFieldValue("Es_Correcto_En_Progreso", value);
            }
        }

        public bool? Es_Incorrecto_En_Progreso
        {
            get
            {
                return _es_Incorrecto_En_Progreso;
            }
            set
            {
                _es_Incorrecto_En_Progreso = value;
                UpdateFieldValue("Es_Incorrecto_En_Progreso", value);
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

        public System.Guid? Transaccion_Escaneo
        {
            get
            {
                return _transaccion_Escaneo;
            }
            set
            {
                _transaccion_Escaneo = value;
                UpdateFieldValue("Transaccion_Escaneo", value);
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

        public string MensajeValidacionAplicada
        {
            get
            {
                return _mensajeValidacionAplicada;
            }
            set
            {
                _mensajeValidacionAplicada = value;
                UpdateFieldValue("MensajeValidacionAplicada", value);
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

        public int? Folio_Etiqueta_Embarque
        {
            get
            {
                return _folio_Etiqueta_Embarque;
            }
            set
            {
                _folio_Etiqueta_Embarque = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque", value);
            }
        }

        public string Material_Tarima_Dos
        {
            get
            {
                return _material_Tarima_Dos;
            }
            set
            {
                _material_Tarima_Dos = value;
                UpdateFieldValue("Material_Tarima_Dos", value);
            }
        }

        public string SOrde_SItem_Tarima_Dos
        {
            get
            {
                return _sOrde_SItem_Tarima_Dos;
            }
            set
            {
                _sOrde_SItem_Tarima_Dos = value;
                UpdateFieldValue("SOrde_SItem_Tarima_Dos", value);
            }
        }

        public string SOrde_SItem_Packing_List
        {
            get
            {
                return _sOrde_SItem_Packing_List;
            }
            set
            {
                _sOrde_SItem_Packing_List = value;
                UpdateFieldValue("SOrde_SItem_Packing_List", value);
            }
        }

        public int? Folio_Etiqueta_Embarque_Tres
        {
            get
            {
                return _folio_Etiqueta_Embarque_Tres;
            }
            set
            {
                _folio_Etiqueta_Embarque_Tres = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_Tres", value);
            }
        }

        public string Material_Tarima_Tres
        {
            get
            {
                return _material_Tarima_Tres;
            }
            set
            {
                _material_Tarima_Tres = value;
                UpdateFieldValue("Material_Tarima_Tres", value);
            }
        }

        public string SOrde_SItem_Tarima_Tres
        {
            get
            {
                return _sOrde_SItem_Tarima_Tres;
            }
            set
            {
                _sOrde_SItem_Tarima_Tres = value;
                UpdateFieldValue("SOrde_SItem_Tarima_Tres", value);
            }
        }

        public long? Delivery_Dos
        {
            get
            {
                return _delivery_Dos;
            }
            set
            {
                _delivery_Dos = value;
                UpdateFieldValue("Delivery_Dos", value);
            }
        }

        public string Resultado_Validacion
        {
            get
            {
                return _resultado_Validacion;
            }
            set
            {
                _resultado_Validacion = value;
                UpdateFieldValue("Resultado_Validacion", value);
            }
        }

        public string Folio_Etiqueta_Embarque_SeccionUno
        {
            get
            {
                return _folio_Etiqueta_Embarque_SeccionUno;
            }
            set
            {
                _folio_Etiqueta_Embarque_SeccionUno = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_SeccionUno", value);
            }
        }

        public string Folio_Etiqueta_Embarque_SeccionDos
        {
            get
            {
                return _folio_Etiqueta_Embarque_SeccionDos;
            }
            set
            {
                _folio_Etiqueta_Embarque_SeccionDos = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_SeccionDos", value);
            }
        }

        public string Folio_Etiqueta_Embarque_SeccionTres
        {
            get
            {
                return _folio_Etiqueta_Embarque_SeccionTres;
            }
            set
            {
                _folio_Etiqueta_Embarque_SeccionTres = value;
                UpdateFieldValue("Folio_Etiqueta_Embarque_SeccionTres", value);
            }
        }

        public string Delivery_SeccionTres
        {
            get
            {
                return _delivery_SeccionTres;
            }
            set
            {
                _delivery_SeccionTres = value;
                UpdateFieldValue("Delivery_SeccionTres", value);
            }
        }

        public long? Folio_Escaneo_Id
        {
            get
            {
                return _folio_Escaneo_Id;
            }
            set
            {
                _folio_Escaneo_Id = value;
                UpdateFieldValue("Folio_Escaneo_Id", value);
            }
        }

        public bool? Mostrar_Campos_Sistema
        {
            get
            {
                return _mostrar_Campos_Sistema;
            }
            set
            {
                _mostrar_Campos_Sistema = value;
                UpdateFieldValue("Mostrar_Campos_Sistema", value);
            }
        }

        public long? Folio_Escaneo_Anterior
        {
            get
            {
                return _folio_Escaneo_Anterior;
            }
            set
            {
                _folio_Escaneo_Anterior = value;
                UpdateFieldValue("Folio_Escaneo_Anterior", value);
            }
        }

        public bool? Captura_Iniciada
        {
            get
            {
                return _captura_Iniciada;
            }
            set
            {
                _captura_Iniciada = value;
                UpdateFieldValue("Captura_Iniciada", value);
            }
        }

        public string Sales_Order_Uno
        {
            get
            {
                return _sales_Order_Uno;
            }
            set
            {
                _sales_Order_Uno = value;
                UpdateFieldValue("Sales_Order_Uno", value);
            }
        }

        public string Sales_Item_Uno
        {
            get
            {
                return _sales_Item_Uno;
            }
            set
            {
                _sales_Item_Uno = value;
                UpdateFieldValue("Sales_Item_Uno", value);
            }
        }

        public string Sales_Order_Dos
        {
            get
            {
                return _sales_Order_Dos;
            }
            set
            {
                _sales_Order_Dos = value;
                UpdateFieldValue("Sales_Order_Dos", value);
            }
        }

        public string Sales_Item_Dos
        {
            get
            {
                return _sales_Item_Dos;
            }
            set
            {
                _sales_Item_Dos = value;
                UpdateFieldValue("Sales_Item_Dos", value);
            }
        }

        public string Sales_Order_Tres
        {
            get
            {
                return _sales_Order_Tres;
            }
            set
            {
                _sales_Order_Tres = value;
                UpdateFieldValue("Sales_Order_Tres", value);
            }
        }

        public string Sales_Item_Tres
        {
            get
            {
                return _sales_Item_Tres;
            }
            set
            {
                _sales_Item_Tres = value;
                UpdateFieldValue("Sales_Item_Tres", value);
            }
        }

        public string Sales_Order_Packing
        {
            get
            {
                return _sales_Order_Packing;
            }
            set
            {
                _sales_Order_Packing = value;
                UpdateFieldValue("Sales_Order_Packing", value);
            }
        }

        public string Sales_Item_Packing
        {
            get
            {
                return _sales_Item_Packing;
            }
            set
            {
                _sales_Item_Packing = value;
                UpdateFieldValue("Sales_Item_Packing", value);
            }
        }

        public FieldValue this[Escaneo_Validador_Embarque1DataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
