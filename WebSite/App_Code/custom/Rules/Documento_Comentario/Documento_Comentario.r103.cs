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
        /// Rule "Cancelar_Surtido" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r103")]
        public void r103Implementation(Documento_ComentarioModel instance)
        {
            // This is the placeholder for method implementation.            
            // Declaración de variables
            int tipoOperacionId = 3;//Cancelar surtido de material            
            Int64 rutaOptimaId = instance.Ruta_Optima_Id ?? 0;
            Int64 materialId = instance.Material_Id ?? 0;
            decimal cantidadSolicitado = instance.Cantidad_Solicitado ?? 0;
            decimal cantidadEntregado = instance.Cantidad_Entregado ?? 0;
            int unidadMaterialEntregadoId = instance.Unidad_Material_Entregado_Id ?? 0;
            int ubicacionAlmacenamientoDeSurtidoId = instance.Ubicacion_Almacenamiento_De_Surtido_Id ?? 0;
            int motivoCancelacionId = instance.Motivo_Cancelacion_Id ?? 0;
            string comentarioCancelacion = instance.Comentarios;

            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            int ProcesoSistemaId = 0;

            if (materialId == 0)
            {
                Result.ShowMessage("El identificador de Material es obligatorio!");
            }
            else
            if (motivoCancelacionId == 0)
            {
                Result.ShowMessage("Debe indicar Motivo de Cancelación.");
            }
            else
            {
                resultadoEjecucion = ActualizarSurtido(
                    tipoOperacionId
                    //,tmpRutaOptimaTransaccionId
                    , rutaOptimaId
                    , 0 //materialSurtidoId
                    , materialId
                    , cantidadSolicitado
                    , cantidadEntregado
                    , unidadMaterialEntregadoId
                    , ubicacionAlmacenamientoDeSurtidoId
                    ,0 // Material_Ubicacion_Stock_Id
                    , motivoCancelacionId
                    , comentarioCancelacion
                    //---                
                    , out MensajeSistema
                    , out MensajeSistemaId
                    , out ProcesoSistemaId
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
                        Result.Continue();
                        //Result.Refresh(); // Refrescamos el grid
                        //Result.RefreshChildren();
                    }
                }
            }
        }
        // END public void r103Implementation(Documento_ComentarioModel instance)
    }
}
