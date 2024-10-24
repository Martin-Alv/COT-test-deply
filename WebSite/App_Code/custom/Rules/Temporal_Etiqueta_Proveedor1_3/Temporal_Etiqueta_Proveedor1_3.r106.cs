using System;
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
    public partial class Handler_Ultima_Carga_Usuario_cooper : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Generar_Todas_Ultima_Etiqueta" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "Report" and argument that matches "ExecCS04".
        /// </summary>
        [Rule("r106")]
        public void r106Implementation(Temporal_Etiqueta_Proveedor1_3Model instance)
        {
            // This is the placeholder for method implementation.
            PreventDefault();

            string mensajeSistema;
            int mensajeSistemaId = 0;
            int procesoSistemaId = 0;
            int Tipo_Operacion_Id = 3;
            //int Etiqueta_Proveedor_Id = instance.Etiqueta_Proveedor_Id ?? 0;
            //int Etiqueta_Detalle_Proveedor_Id = instance.Etiqueta_Proveedor_Id ?? 0;
            int Etiqueta_Proveedor_Id = Convert.ToInt32(SelectFieldValue("Parameters_Etiqueta_Proveedor_Id") ?? 0);
            int Etiqueta_Detalle_Proveedor_Id = Convert.ToInt32(SelectFieldValue("Parameters_Etiqueta_Proveedor_Id") ?? 0);
            int Tipo_Etiqueta_Id = Convert.ToInt32(SelectFieldValue("Parameters_Tipo_Etiqueta_Id") ?? 0);
            int Tamanio_Etiqueta_Id = Convert.ToInt32(SelectFieldValue("Parameters_Tamanio_Etiqueta_Id") ?? 0);
            string Layout_HTML_Generado = "";
            string Page_Size = "";
            string PageWidth = "";
            string PageHeight = "";
            string Landscape = "";

            //bool resultadoGenerarPDF;
            //bool obtenerApiKey;
            //string apiKey;
            //string urlPdfRocket;
            //string valorCualitativo;
            //decimal valorCuantitativo;
            bool obtenerLayoutHtml;
            //long RutaOptimaId = instance.Ruta_Optima_Id ?? 0;
            //string TmpRutaOptimaTransaccionId = instance.Tmp_Ruta_Optima_Transaccion_Id.ToString();
            string LayoutHtmlGenerado = "";


            obtenerLayoutHtml = GenerarLayoutEtiquetaProveedor(Tipo_Operacion_Id, Etiqueta_Proveedor_Id, Etiqueta_Detalle_Proveedor_Id, Tipo_Etiqueta_Id, Tamanio_Etiqueta_Id, out Layout_HTML_Generado, out Page_Size, out PageWidth, out PageHeight, out Landscape, out mensajeSistema, out mensajeSistemaId);//PRUEBAS
            if (!obtenerLayoutHtml || Layout_HTML_Generado == "")
            {
                // Result.ShowAlert("No se pudo obtener generar Etiqueta");
                errorResponse(mensajeSistema);
            }
            else
            {
                //Result.ShowAlert("Descargando archivo");
                //obtenerLayoutHtml = ObtenerLayoutHtmlHojaCaptura(tipoHojaId, out LayoutHtmlGenerado, out mensajeSistema, out mensajeSistemaId, out procesoSistemaId);
                //obtenerApiKey = ObtenerConfiguracionSistema(11, 1, out valorCualitativo, 0, out
                //valorCuantitativo);//PROD
                //apiKey = valorCualitativo;
                //obtenerApiKey = ObtenerConfiguracionSistema(1003, 1, out valorCualitativo, 0, out
                //valorCuantitativo); //PROD
                //urlPdfRocket = valorCualitativo;
                PreventDefault();
                //NameValueCollection options = new NameValueCollection();
                //options.Add("apikey", apiKey);
                //options.Add("value", Layout_HTML_Generado);
                //options.Add("UseLandscape", Landscape);
                //options.Add("MarginTop", "3");
                ////options.Add("PageSize", Page_Size);
                //options.Add("PageWidth", PageWidth); // en valores de mm
                //options.Add("PageHeight", PageHeight);// en valores de mm
                ////options.Add("MarginTop", "1");
                //options.Add("MarginBottom", "3");

                var client = new WebClient();
                try
                {
                    GenerarReportesHtml gpdf = new GenerarReportesHtml();

                    //byte[] reportData = client.UploadValues(urlPdfRocket, options);

                    if (Landscape.Equals("false"))
                    {
                        byte[] reportData = gpdf.GenerarReporteDinamicosnLandscape(Layout_HTML_Generado, PageWidth, PageHeight, Landscape);

                        Context.Response.Clear();
                        Context.Response.ContentType = "application/pdf";
                        Context.Response.AddHeader("content-disposition", "attachment; filename=EtiquetaProveedor.pdf");
                        Context.Response.AddHeader("Content-Length", reportData.Length.ToString());
                        Context.Response.OutputStream.Write(reportData, 0, reportData.Length);
                        mensajeSistema = "Ok";
                        //
                        Result.Refresh();
                    }
                    else
                    {
                        byte[] reportData = gpdf.GenerarReporteDinamico(Layout_HTML_Generado, PageWidth, PageHeight, Landscape);

                        Context.Response.Clear();
                        Context.Response.ContentType = "application/pdf";
                        Context.Response.AddHeader("content-disposition", "attachment; filename=EtiquetaProveedor.pdf");
                        Context.Response.AddHeader("Content-Length", reportData.Length.ToString());
                        Context.Response.OutputStream.Write(reportData, 0, reportData.Length);
                        mensajeSistema = "Ok";
                        //
                        Result.Refresh();
                    }

                }
                catch (Exception e)
                {
                    mensajeSistema = e.Message;
                }

                Result.Refresh();
            }
        }
    }
}
