﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

using System.Collections.Specialized;
using System.Net;

namespace eaton.Rules
{
	public partial class Grid_Prueba_Hoja_Pdf_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>
        /// Rule "Imprimir_PDF" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Report" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r100")]
        public void r100Implementation(Grid_Prueba_Hoja_Pdf_VModel instance)
        {
            // This is the placeholder for method implementation.            
            int tipoHojaId = 0; // 0: layout  ruta optima para pruebas
            string mensajeSistema;
            int mensajeSistemaId = 0;
            int procesoSistemaId = 0;
            //string layoutHtml;

            //bool resultadoGenerarPDF;
            bool obtenerApiKey;
            string apiKey;
            string urlPdfRocket;
            string valorCualitativo;
            decimal valorCuantitativo;
            bool obtenerLayoutHtml;
            //long RutaOptimaId = instance.Ruta_Optima_Id ?? 0;
            //string TmpRutaOptimaTransaccionId = instance.Tmp_Ruta_Optima_Transaccion_Id.ToString();
            string LayoutHtmlGenerado = "";

            //obtenerApiKey = ObtenerConfiguracionSistema(11, 1, out valorCualitativo, 0, out valorCuantitativo);//PROD
            obtenerApiKey = ObtenerConfiguracionSistema(12, 1, out valorCualitativo, 0, out valorCuantitativo);//PRUEBAS
            apiKey = valorCualitativo;
            obtenerApiKey = ObtenerConfiguracionSistema(1003, 1, out valorCualitativo, 0, out
            valorCuantitativo); //PROD
            urlPdfRocket = valorCualitativo;
            if (!obtenerApiKey || valorCualitativo == "")
            {
                Result.ShowAlert("No se pudo obtener el API Key!");
            }
            else
            {
                obtenerLayoutHtml = ObtenerLayoutHtmlHojaRutaOptimaPrueba(tipoHojaId, out LayoutHtmlGenerado, out mensajeSistema, out mensajeSistemaId, out procesoSistemaId);

                PreventDefault();
                NameValueCollection options = new NameValueCollection();
                options.Add("apikey", apiKey);
                options.Add("value", LayoutHtmlGenerado);
                options.Add("UseLandscape", "true");

                var client = new WebClient();
                try
                {
                    byte[] reportData = client.UploadValues(urlPdfRocket, options);

                    Context.Response.Clear();
                    Context.Response.ContentType = "application/pdf";
                    Context.Response.AddHeader("content-disposition", "attachment; filename=myfilenamedeprueba.pdf");
                    Context.Response.AddHeader("Content-Length", reportData.Length.ToString());
                    Context.Response.OutputStream.Write(reportData, 0, reportData.Length);
                    mensajeSistema = "Ok";
                }
                catch (Exception e)
                {
                    mensajeSistema = e.Message;
                }

                /* resultadoGenerarPDF = GenerarPDF(valorCualitativo, layoutHtml, out mensajeSistema);
                 if (!resultadoGenerarPDF)
                 {
                     errorResponse(mensajeSistema);
                 }
                 else
                     errorResponse(mensajeSistema);*/
                //string apiKey = "52ae72cc-de0c-4e79-b7ed-82617e634029";
                //Result.Refresh();

            }
            //Result.ExecuteOnClient("window.location.reload();");
        }
    }
}