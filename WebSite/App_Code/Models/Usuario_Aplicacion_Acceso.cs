using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;

namespace eaton.Models
{
    public enum Usuario_Aplicacion_AccesoDataField
    {

        Usuario_Aplicacion_Acceso_Id,

        Usuario_Aplicacion_Id,

        Nombre_Completo,

        Usuario_Id,

        Usuario_Sistema,

        Nip,

        Numero_Actualizacion_Acceso,

        Creado_Por,

        Fecha_Creacion,

        Fecha_Ultima_Actualizacion,

        Estatus_Registro_Id,

        Estatus_Registro,

        Actualizado_Por,

        Fecha_Ultimo_Acceso,

        Numero_Intento_Acceso,

        Fecha_Ultimo_Acceso_Fallido,

        Fecha_Ultimo_Bloqueo,

        Desbloqueado_Por_Id,

        Desbloqueado_Por,

        Desbloquear,

        Bloqueado,
    }

    public partial class Usuario_Aplicacion_AccesoModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usuario_Aplicacion_Acceso_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _usuario_Aplicacion_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nombre_Completo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _usuario_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _usuario_Sistema;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nip;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Actualizacion_Acceso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _creado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Creacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultima_Actualizacion;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _estatus_Registro_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _estatus_Registro;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _actualizado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultimo_Acceso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _numero_Intento_Acceso;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultimo_Acceso_Fallido;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _fecha_Ultimo_Bloqueo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _desbloqueado_Por_Id;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _desbloqueado_Por;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _desbloquear;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _bloqueado;

        public Usuario_Aplicacion_AccesoModel()
        {
        }

        public Usuario_Aplicacion_AccesoModel(BusinessRules r) :
                base(r)
        {
        }

        public int? Usuario_Aplicacion_Acceso_Id
        {
            get
            {
                return _usuario_Aplicacion_Acceso_Id;
            }
            set
            {
                _usuario_Aplicacion_Acceso_Id = value;
                UpdateFieldValue("Usuario_Aplicacion_Acceso_Id", value);
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

        public string Nombre_Completo
        {
            get
            {
                return _nombre_Completo;
            }
            set
            {
                _nombre_Completo = value;
                UpdateFieldValue("Nombre_Completo", value);
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

        public string Nip
        {
            get
            {
                return _nip;
            }
            set
            {
                _nip = value;
                UpdateFieldValue("Nip", value);
            }
        }

        public int? Numero_Actualizacion_Acceso
        {
            get
            {
                return _numero_Actualizacion_Acceso;
            }
            set
            {
                _numero_Actualizacion_Acceso = value;
                UpdateFieldValue("Numero_Actualizacion_Acceso", value);
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

        public DateTime? Fecha_Ultimo_Acceso
        {
            get
            {
                return _fecha_Ultimo_Acceso;
            }
            set
            {
                _fecha_Ultimo_Acceso = value;
                UpdateFieldValue("Fecha_Ultimo_Acceso", value);
            }
        }

        public int? Numero_Intento_Acceso
        {
            get
            {
                return _numero_Intento_Acceso;
            }
            set
            {
                _numero_Intento_Acceso = value;
                UpdateFieldValue("Numero_Intento_Acceso", value);
            }
        }

        public DateTime? Fecha_Ultimo_Acceso_Fallido
        {
            get
            {
                return _fecha_Ultimo_Acceso_Fallido;
            }
            set
            {
                _fecha_Ultimo_Acceso_Fallido = value;
                UpdateFieldValue("Fecha_Ultimo_Acceso_Fallido", value);
            }
        }

        public DateTime? Fecha_Ultimo_Bloqueo
        {
            get
            {
                return _fecha_Ultimo_Bloqueo;
            }
            set
            {
                _fecha_Ultimo_Bloqueo = value;
                UpdateFieldValue("Fecha_Ultimo_Bloqueo", value);
            }
        }

        public System.Guid? Desbloqueado_Por_Id
        {
            get
            {
                return _desbloqueado_Por_Id;
            }
            set
            {
                _desbloqueado_Por_Id = value;
                UpdateFieldValue("Desbloqueado_Por_Id", value);
            }
        }

        public string Desbloqueado_Por
        {
            get
            {
                return _desbloqueado_Por;
            }
            set
            {
                _desbloqueado_Por = value;
                UpdateFieldValue("Desbloqueado_Por", value);
            }
        }

        public bool? Desbloquear
        {
            get
            {
                return _desbloquear;
            }
            set
            {
                _desbloquear = value;
                UpdateFieldValue("Desbloquear", value);
            }
        }

        public bool? Bloqueado
        {
            get
            {
                return _bloqueado;
            }
            set
            {
                _bloqueado = value;
                UpdateFieldValue("Bloqueado", value);
            }
        }

        public FieldValue this[Usuario_Aplicacion_AccesoDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
