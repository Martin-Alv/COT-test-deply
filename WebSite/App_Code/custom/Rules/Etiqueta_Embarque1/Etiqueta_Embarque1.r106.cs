﻿using System;
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
    public partial class Etiqueta_Embarque1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r106")]
        public void r106Implementation(Etiqueta_Embarque1Model instance)
        {
            // This is the placeholder for method implementation.
            int etiqueta_Embarque_Id = instance.Etiqueta_Embarque_Id ?? 0;

            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            bool resultadoGenerarEtiquetaEmbarqueDetalle;
            int Operacion = 1;

            //GenerarEtiquetaDetalleProveedor
            resultadoGenerarEtiquetaEmbarqueDetalle = GenerarDetallesEtiquetaEmbarque(etiqueta_Embarque_Id, Operacion, out MensajeSistema, out MensajeSistemaId);


            if (resultadoGenerarEtiquetaEmbarqueDetalle == false || (resultadoGenerarEtiquetaEmbarqueDetalle == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(0, MensajeSistemaId, "", MensajeSistema);
                //Result.ExecuteOnClient("$appfactory.find('Etiqueta_Embarque1', 'Controller').sync();");
                Result.ShowMessage(MensajeSistema);
                //Result.ShowAlert(MensajeSistema);
                //Result.Refresh();
            }
            else
            {
                if (resultadoGenerarEtiquetaEmbarqueDetalle == true && MensajeSistemaId == 1)
                {
                    Result.ShowMessage(MensajeSistema);
                    //Result.ExecuteOnClient("$appfactory.find('Etiqueta_Embarque1', 'Controller').sync();");
                    Result.Continue();
                }
            }

        }
    }
}