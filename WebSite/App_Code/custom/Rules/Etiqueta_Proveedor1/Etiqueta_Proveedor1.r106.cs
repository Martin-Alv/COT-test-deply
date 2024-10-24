using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

namespace eaton.Rules
{
    public partial class Etiqueta_Proveedor1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Update".
        /// </summary>
        [Rule("r106")]
        public void r106Implementation(Etiqueta_Proveedor1Model instance)
        {
            int etiqueta_Proveedor_Id = instance.Etiqueta_Proveedor_Id ?? 0;

            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            bool resultadoGenerarEtiquetaDetalleProveedor;

            //GenerarEtiquetaDetalleProveedor
            resultadoGenerarEtiquetaDetalleProveedor = GenerarEtiquetaDetalleProveedor(etiqueta_Proveedor_Id, out MensajeSistema, out MensajeSistemaId);


            if (resultadoGenerarEtiquetaDetalleProveedor == false || (resultadoGenerarEtiquetaDetalleProveedor == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, MensajeSistemaId, "", MensajeSistema);
                Result.ExecuteOnClient("$appfactory.find('Etiqueta_Detalle_Proveedor1', 'Controller').sync();");
                Result.ShowMessage(MensajeSistema);
                Result.ShowAlert(MensajeSistema);
                Result.Refresh();
            }
            else
            {
                if (resultadoGenerarEtiquetaDetalleProveedor == true && MensajeSistemaId == 1)
                {
                    Result.ShowMessage(MensajeSistema);
                    Result.ExecuteOnClient("$appfactory.find('Etiqueta_Detalle_Proveedor1', 'Controller').sync();");
                    Result.Continue();
                }
            }
        }
    }
}
