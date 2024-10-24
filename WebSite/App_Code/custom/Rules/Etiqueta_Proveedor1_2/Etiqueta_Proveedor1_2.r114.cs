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
    public partial class Etiqueta_Proveedor1_2BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "Generar_Recivos" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Report" and argument that matches "ExecCS08".
        /// </summary>
        [Rule("r114")]
        public void r114Implementation(Etiqueta_Proveedor1_2Model instance)
        {
            // This is the placeholder for method implementation.
            string mensajeSistema;
            int mensajeSistemaId = 0;
            int procesoSistemaId = 0;
            int Tipo_Operacion_Id = 1;

            string[] valoresseleccionados;

            valoresseleccionados = Arguments.SelectedValues;
            string Etiqueta_Proveedor = "";

            Etiqueta_Proveedor = String.Join(",", valoresseleccionados);

            int Etiqueta_Proveedor_Id = 0;//instance.Etiqueta_Proveedor_Id ?? 0;

            string Layout_HTML_Generado = "";


            //bool obtenerApiKey;
            //string apiKey;
            //string urlPdfRocket;
            //string valorCualitativo;
            //decimal valorCuantitativo;
            bool obtenerLayoutHtml;



            obtenerLayoutHtml = GenerarLayoutCapturaRecivosEtiquetas(Tipo_Operacion_Id, Etiqueta_Proveedor, Etiqueta_Proveedor_Id, out Layout_HTML_Generado, out mensajeSistema, out mensajeSistemaId, out procesoSistemaId);//PRUEBAS
            if (!obtenerLayoutHtml || Layout_HTML_Generado == "")
            {
                Result.ShowAlert("No se pudo obtener generar Captura de Recivos Etiqueta");
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
                //options.Add("UseLandscape", "true");


                var client = new WebClient();
                try
                {
                    //byte[] reportData = client.UploadValues(urlPdfRocket, options);
                    GenerarPdfEtiquetaCapturista report = new GenerarPdfEtiquetaCapturista();
                    byte[] reportData = report.GenerarHojaCapturaSurtidor(Layout_HTML_Generado);

                    Context.Response.Clear();
                    Context.Response.ContentType = "application/pdf";
                    Context.Response.AddHeader("content-disposition", "attachment; filename=EtiquetaCapturaRecivos.pdf");
                    Context.Response.AddHeader("Content-Length", reportData.Length.ToString());
                    Context.Response.OutputStream.Write(reportData, 0, reportData.Length);
                    mensajeSistema = "Ok";

                    Result.Refresh();
                }
                catch (Exception e)
                {
                    mensajeSistema = e.Message;
                }

                //Result.Refresh();
            }
        }
    }
}
