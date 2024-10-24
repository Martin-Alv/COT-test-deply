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
	public partial class Mov_Dev_Ruta_Optima_A_Ejecutar_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Actualizar_Movimiento_Material" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        //START public void r100Implementation(Mov_Dev_Ruta_Optima_A_Ejecutar_VModel instance)
        public void r100Implementation(Mov_Dev_Ruta_Optima_A_Ejecutar_VModel instance)
        {
            // This is the placeholder for method implementation.
            //Declaración de variables
            int Tipo_Operacion_Id = 1; //1: Actualizar solicitud devolución material en ruta optima.
            long Movimiento_Ruta_Optima_Id = instance.Movimiento_Ruta_Optima_Id ?? 0;
            int Tipo_Movimiento_Id = instance.Tipo_Movimiento_Id ?? 0; // 1: Devolución de Materiales, 2: Transferencia de materiales
            long Devolucion_Material_Id = instance.Devolucion_Material_Id ?? 0;
            decimal Cantidad_A_Devolver = instance.Cantidad_A_Devolver ?? 0;
            decimal Cantidad_Devuelto = instance.Cantidad_Devuelto ?? 0;
            int Unidad_Material_Devuelto_Id = instance.Unidad_Material_Devuelto_Id ?? 0;
            int Devolucion_Ubicacion_Almacenamiento_Id = instance.Devolucion_En_Ubicacion_Almacenamiento_Id ?? 0;
            string Tmp_Mov_Ruta_Optima_Transaccion_Id = instance.Tmp_Ruta_Optima_Transaccion_Id ?? "";
            string Movimiento = instance.Movimiento ?? "";

            long Dev_Material_Ubicacion_Stock_Id = instance.Material_Ubicacion_Stock_Id ?? 0;
            
            string Mensaje_Sistema = "";
            int Mensaje_Sistema_Id = 0;
            bool resultadoActualizarMovMaterial;

            if (Tipo_Movimiento_Id == 0)
                Tipo_Movimiento_Id = 1; // 1: Devolución de Materiales, 2: Transferencia de materiales

            //START if (Movimiento_Ruta_Optima_Id == 0)
            if (Movimiento_Ruta_Optima_Id == 0)
            {
                Result.ShowMessage("El identificador de la Devolución de Material es obligatorio!");
            }
            else
            //START else
            {
                resultadoActualizarMovMaterial = ActualizarMovimientoMaterial(
                    Tipo_Operacion_Id
                    ,Movimiento_Ruta_Optima_Id
                    ,Tipo_Movimiento_Id
                    //Para devoluciones
                    ,Devolucion_Material_Id
                    ,Cantidad_A_Devolver
                    ,Cantidad_Devuelto
                    ,Unidad_Material_Devuelto_Id
                    ,Devolucion_Ubicacion_Almacenamiento_Id
                    ,Dev_Material_Ubicacion_Stock_Id
                    //Para transferencias
                    ,0 //Transferencia_Material_Id
                    ,0 //Cantidad_A_Transferir
                    ,0 //Cantidad_Transferido
                    ,0 //Unidad_Material_Transferido_Id
                    ,0 //Transferencia_Ubicacion_Almacenamiento_Id
                    ,0
                    //
                    ,Movimiento
                    , Tmp_Mov_Ruta_Optima_Transaccion_Id
                    ,0
                    ,""
                    , out Mensaje_Sistema
                    ,out Mensaje_Sistema_Id
                );

                if (resultadoActualizarMovMaterial == false || (resultadoActualizarMovMaterial == true && Mensaje_Sistema_Id != 1))
                {
                    RegistrarEnBitacora(0, Mensaje_Sistema_Id, "", Mensaje_Sistema);
                    Result.ShowMessage(Mensaje_Sistema);
                }
                else
                {
                    if (resultadoActualizarMovMaterial == true && Mensaje_Sistema_Id == 1)
                    {
                        Result.ShowMessage(Mensaje_Sistema);
                    }
                }
            }
            //END else
        }
        //END public void r100Implementation(Mov_Dev_Ruta_Optima_A_Ejecutar_VModel instance)
    }
}
