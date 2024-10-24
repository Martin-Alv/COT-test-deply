using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using eaton.Rules;

using System.Windows.Forms;

namespace eaton.Services
{
    public partial class ApplicationServices
    {        

        // START public override bool UserLogin(string username, string password, bool createPersistentCookie)
        public override bool UserLogin(string username, string password, bool createPersistentCookie)
        {
            bool resultadoEjecucionSP;
            string mensajeSistema = "";
            int mensajeSistemaId = 0;
            int usuarioValido = 0;

            SharedBusinessRules sb = new SharedBusinessRules();
            resultadoEjecucionSP = sb.ValidarUsuarioAplicacionAcceso(username, password, out mensajeSistemaId, out mensajeSistema, out usuarioValido);

            if (mensajeSistemaId == 1 && usuarioValido == 1)
            {
                FormsAuthentication.SetAuthCookie(username, createPersistentCookie);
                return true;
            }
            else                
                return false;            
        }// END public override bool UserLogin(string username, string password, bool createPersistentCookie)
    }
}