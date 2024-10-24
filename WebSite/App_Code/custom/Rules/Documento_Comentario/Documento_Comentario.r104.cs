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
	public partial class Documento_ComentarioBusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>
        /// This method will execute in any view after an action
        /// with a command name that matches "Insert".
        /// </summary>
        [Rule("r104")]
        public void r104Implementation(Documento_ComentarioModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            int tipoOperacionId = instance.Tipo_Operacion_Id ?? 0;
            //string tmpRutaOptimaTransaccionId = instance.Tmp_Ruta_Optima_Transaccion_Id;
            Int64 rutaOptimaId = instance.Ruta_Optima_Id ?? 0;
            Int64 materialSurtidoId = instance.Material_Surtido_Id ?? 0;
            Int64 materialId = instance.Material_Id ?? 0;
            int documentoComentarioId = instance.Documento_Comentario_Id ?? 0;
            int registradoDesdeId = instance.Registrado_Desde_Id ?? 0;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;


            resultadoEjecucion = ValidarDocumentoComentario(
                tipoOperacionId
                ,registradoDesdeId
                ,materialId
                ,documentoComentarioId
                ,rutaOptimaId
                ,materialSurtidoId
               // ,""
                //---                
                , out MensajeSistema
                , out MensajeSistemaId
                //, out ProcesoSistemaId
            );

            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {
                RegistrarEnBitacora(ProcesoSistemaId, MensajeSistemaId, "", MensajeSistema);
                Result.ShowMessage(MensajeSistema);
            }
            else
            {
                if (resultadoEjecucion == true && MensajeSistemaId == 1)
                {
                    Result.ShowMessage(MensajeSistema);
                    //Result.Refresh(); // Refrescamos el grid
                    Result.Continue();
                }
            }
        }
    }
}
