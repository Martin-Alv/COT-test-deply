using System;
using System.Data;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;
//using System.Web;
//using System.Web.Security;
using eaton.Data;
using eaton.Models;
//using iTextSharp.text.pdf;
//using iTextSharp.text;
//using System.Data.Common;
//using System.IO;
//using System.Drawing;
//using iTextSharp.text.html.simpleparser;
//using Image = iTextSharp.text.Image;
//using BarcodeLib;
//using System.Globalization;

namespace eaton.Rules   //A aqui 
{
    public partial class Etiqueta_Embarque_Detalle1BusinessRules : eaton.Rules.SharedBusinessRules
    {

        /// <summary>Rule "GenerarEtiquetas" implementation:
        /// This method will execute in any view for an action
        /// with a command name that matches "ReportAsPdf".
        /// </summary>
        [Rule("r105")]
        public void r105Implementation(Etiqueta_Embarque_Detalle1Model instance)
        {
            PreventDefault();
            ActionArgs ag = this.Arguments;
            string argumen = ag.CommandArgument;

            int Tipo_Operacion_Id = 0; 
            int Etiqueta_Embarque_Detalle_Id = 0;

            if (instance.Etiqueta_Embarque_Detalle_Id != null)
            {
				// imprimir de un detalle en especifico
                Tipo_Operacion_Id = 2;
                Etiqueta_Embarque_Detalle_Id = instance.Etiqueta_Embarque_Detalle_Id ?? 0;
            }
            else if (instance.Etiqueta_Embarque_Detalle_Id == null && ag.ExternalFilter[0].Value != null)
            {
				// Imprimir de todos los detalles
                Tipo_Operacion_Id = 1;
				Etiqueta_Embarque_Detalle_Id = 0;

            }

			string mensajeSistema;
			int mensajeSistemaId = 0;
			int procesoSistemaId = 0;

			// int Etiqueta_Embarque_Id = instance.Etiqueta_Embarque_Id ?? 0;
			int Etiqueta_Embarque_Id = Convert.ToInt32(ag.ExternalFilter[0].Value);


			//int Tipo_Etiqueta_Id = Convert.ToInt32(SelectFieldValue("Parameters_Tipo_Etiqueta_Id") ?? 0);
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
			string LayoutHtmlGenerado = "";


			obtenerLayoutHtml = GenerarLayoutEtiquetaEmbarque(Tipo_Operacion_Id, Etiqueta_Embarque_Id, Etiqueta_Embarque_Detalle_Id, Tamanio_Etiqueta_Id, out Layout_HTML_Generado, out Page_Size, out PageWidth, out PageHeight, out Landscape, out mensajeSistema, out mensajeSistemaId);//PRUEBAS
			if (!obtenerLayoutHtml || Layout_HTML_Generado == "")
			{
				//Result.ShowAlert("No se pudo generar la Etiqueta de embarque");
				errorResponse(mensajeSistema);
			}
			else
			{
				try
				{
					GenerarReportesHtml gpdf = new GenerarReportesHtml();

					if (Landscape.Equals("false"))
					{
						byte[] reportData = gpdf.GenerarReporteDinamicosnLandscape(Layout_HTML_Generado, PageWidth, PageHeight, Landscape);

						Context.Response.Clear();
						Context.Response.ContentType = "application/pdf";
						Context.Response.AddHeader("content-disposition", "attachment; filename=EtiquetaEmbarque.pdf");
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
						Context.Response.AddHeader("content-disposition", "attachment; filename=EtiquetaEmbarque.pdf");
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

