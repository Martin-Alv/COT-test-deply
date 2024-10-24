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
        
        /// <summary>Rule "CancelarTransferencia" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS03".
        /// </summary>
        [Rule("r107")]
        //START public void r107Implementation(Documento_ComentarioModel instance)
        public void r107Implementation(Documento_ComentarioModel instance)
        {
            // This is the placeholder for method implementation.
            //Declaración de variables
            int Tipo_Operacion_Id = 3; //3: Cancelar Transferencia de Material
            long Movimiento_Ruta_Optima_Id = instance.Movimiento_Ruta_Optima_Id ?? 0;
            int Tipo_Movimiento_Id = instance.Tipo_Movimiento_Id ?? 0; // 1: Devolución de Materiales, 2: Transferencia de materiales
            long Transferencia_Material_Id = instance.Material_Id ?? 0;
            decimal Cantidad_A_Transferir = 0; // instance.Cantidad_A_Transferir ?? 0;
            decimal Cantidad_Transferido = 0; // instance.Cantidad_Transferido ?? 0;
            int Unidad_Material_Transferido_Id = 0; // instance.Unidad_Material_Transferido_Id ?? 0;
            int Transferencia_Ubicacion_Almacenamiento_Id = 0; // instance.Transferencia_En_Ubicacion_Almacenamiento_Id ?? 0;
            string Tmp_Mov_Ruta_Optima_Transaccion_Id = ""; // instance.Tmp_Ruta_Optima_Transaccion_Id ?? "";
            string Movimiento = instance.Movimiento ?? "";
            int Motivo_Cancelacion_Id = instance.Motivo_Movimiento_Id ?? 0;
            string Comentario_Cancelacion = instance.Comentarios ?? "";


            string Mensaje_Sistema = "";
            int Mensaje_Sistema_Id = 0;
            bool resultadoCancelarTransferencia;

            if (Tipo_Movimiento_Id == 0)
                Tipo_Movimiento_Id = 2; // 1: Devolución de Materiales, 2: Transferencia de materiales

            //START if (Movimiento_Ruta_Optima_Id == 0)
            if (Movimiento_Ruta_Optima_Id == 0)
            {
                Result.ShowMessage("El identificador de la Transferencia de Material es obligatorio!");
            }
            else
            //START else
            {
                resultadoCancelarTransferencia = ActualizarMovimientoMaterial(
                    Tipo_Operacion_Id
                    , Movimiento_Ruta_Optima_Id
                    , Tipo_Movimiento_Id
                    //Para devoluciones
                    , 0 //Devolucion_Material_Id
                    , 0 //Cantidad_A_Devolver
                    , 0 //Cantidad_Devuelto
                    , 0 //Unidad_Material_Devuelto_Id
                    , 0 //Devolucion_Ubicacion_Almacenamiento_Id
                    , 0
                        //Para transferencias
                    , Transferencia_Material_Id
                    , Cantidad_A_Transferir
                    , Cantidad_Transferido
                    , Unidad_Material_Transferido_Id
                    , Transferencia_Ubicacion_Almacenamiento_Id
                    ,0
                    //
                    , Movimiento
                    , Tmp_Mov_Ruta_Optima_Transaccion_Id
                    //Cancelacion
                    ,Motivo_Cancelacion_Id
                    ,Comentario_Cancelacion
                    //
                    , out Mensaje_Sistema
                    , out Mensaje_Sistema_Id
                );


                if (resultadoCancelarTransferencia == false || (resultadoCancelarTransferencia == true && Mensaje_Sistema_Id != 1))
                {
                    RegistrarEnBitacora(0, Mensaje_Sistema_Id, "", Mensaje_Sistema);
                    Result.ShowMessage(Mensaje_Sistema);                    
                }
                else
                {
                    if (resultadoCancelarTransferencia == true && Mensaje_Sistema_Id == 1)
                    {
                        Result.ShowMessage(Mensaje_Sistema);
                        Result.Continue();
                    }
                }
            }
        }
        //END public void r107Implementation(Documento_ComentarioModel instance)
    }
}
