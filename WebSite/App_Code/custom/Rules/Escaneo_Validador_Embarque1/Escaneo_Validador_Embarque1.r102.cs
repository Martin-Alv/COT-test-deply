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
    public partial class Escaneo_Validador_Embarque1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS001".
        /// </summary>
        [Rule("r102")]
        public void r102Implementation(Escaneo_Validador_Embarque1Model instance)
        {
            // This is the placeholder for method implementation.
            // Result.ShowAlert("prueba de BR cs001");
            bool resultadoEjecucion;
            int MensajeSistemaId = 0;
            string MensajeSistema = "";
            string resultadoValidacion = "";
            string trace = "";
            //Paso 1
            //int Etiqueta_Embarque_Detalle_Id = instance.Etiqueta_Embarque_Detalle_Id ?? 0;
            string Folio_Etiqueta_Embarque = instance.Folio_Etiqueta_Embarque_SeccionUno ?? "";
            string Material_Embarque= instance.Material_Embarque ;
            string SOrde_SItem_Emabarque = instance.SOrde_SItem_Emabarque;
            string Material_Tarima = instance.Material_Tarima;
            string SOrde_SItem_Tarima = instance.SOrde_SItem_Tarima;
            //Paso 2
            //long Delivery_Id = instance.Delivery_Id ?? 0;
            string Delivery = instance.Delivery_Delivery ?? "";
            // int Folio_Etiqueta_Embarque = instance.Folio_Etiqueta_Embarque ?? 0;
            string Material_Tarima_Dos = instance.Material_Tarima_Dos;
            string SOrde_SItem_Tarima_Dos = instance.SOrde_SItem_Tarima_Dos;
            //Paso 3
            string SOrde_SItem_Packing_List = instance.SOrde_SItem_Packing_List;
            string Delivery_Packing_List = instance.Delivery_Packing_List;
            // long Delivery_Dos=instance.Delivery_Dos ?? 0;
            int Folio_Etiqueta_Embarque_Tres=instance.Folio_Etiqueta_Embarque_Tres ?? 0;
            string Material_Tarima_Tres = instance.Material_Tarima_Tres;
            string SOrde_SItem_Tarima_Tres = instance.SOrde_SItem_Tarima_Tres;
            decimal? Cantidad = instance.Cantidad_Material;
            string Delivery_SeccionTres = instance.Delivery_SeccionTres;
            //Datos extras
            int Validar = 1;//Campo que indica al sp que debe registrar a bitacora y a app.Escaneo
            int Seccion_Capturada=instance.Seccion_Capturada ?? 0;
            
            string Transaccion_Escaneo = instance.Transaccion_Escaneo.ToString();
            string Transaccion_Escaneo_Out = Transaccion_Escaneo;


            long Folio_Escaneo_Id = instance.Folio_Escaneo_Id ?? 0;
            long Folio_Escaneo_Id_Out = instance.Folio_Escaneo_Id ?? 0;

            resultadoEjecucion = ValidarEtiquetas(
                Folio_Etiqueta_Embarque
               ,Material_Tarima
               ,SOrde_SItem_Tarima
               ,Delivery
               ,SOrde_SItem_Packing_List
               ,Delivery_Packing_List
               //,Delivery_Dos
               ,Cantidad
               ,Validar
               ,Seccion_Capturada
               ,out resultadoValidacion
               , Folio_Escaneo_Id
               , out Folio_Escaneo_Id_Out
               , Transaccion_Escaneo
               , out Transaccion_Escaneo_Out
               , out MensajeSistema
               ,out MensajeSistemaId
               ,out trace
           );

            if (resultadoEjecucion == false || (resultadoEjecucion == true && MensajeSistemaId != 1))
            {

                // Result.ShowMessage(MensajeSistema);
                UpdateFieldValue("Resultado_Validacion", resultadoValidacion);
                UpdateFieldValue("Folio_Escaneo_Id", Folio_Escaneo_Id_Out);
                UpdateFieldValue("Transaccion_Escaneo", Transaccion_Escaneo_Out);
                UpdateFieldValue("Mensaje_Sistema_Id", MensajeSistemaId);
                Result.RowsAffected = 1;
            }
            else
            {
                if (resultadoEjecucion == true && MensajeSistemaId == 1)
                {
                    //  Result.ExecuteOnClient("window.location.reload();");
                    UpdateFieldValue("Resultado_Validacion",resultadoValidacion);
                    UpdateFieldValue("Folio_Escaneo_Id", Folio_Escaneo_Id_Out);
                    UpdateFieldValue("Transaccion_Escaneo", Transaccion_Escaneo_Out);
                    UpdateFieldValue("Mensaje_Sistema_Id", MensajeSistemaId);
                    Result.RowsAffected = 1;
                }
            }

        }// public void r102Implementation(Escaneo_Validador_Embarque1Model instance)
    }
}
