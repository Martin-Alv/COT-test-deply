using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;
using NReco.PdfGenerator;
//
using System.Collections.Specialized;
using System.Net;
namespace eaton.Rules
{
    public partial class GeneradorPdf : eaton.Rules.SharedBusinessRules
    {
        /// <summary>
        /// Descripción breve de GeneradorPdf
        /// </summary>
        ///
        public byte[] GenerarHojaCapturaSurtidor(string LayoutHtmlGenerado)
        {
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
            var HtmlMargins = new NReco.PdfGenerator.PageMargins();
            HtmlMargins.Top = 10;
            HtmlMargins.Bottom = 10;
            var pdfBytes = htmlToPdf.GeneratePdf(LayoutHtmlGenerado);

            return pdfBytes;
        }

    }
    public partial class GenerarPdfEtiquetaCapturista : eaton.Rules.SharedBusinessRules
    {
        public byte[] GenerarHojaCapturaSurtidor(string LayoutHtmlGenerado)
        {
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
            var HtmlMargins = new NReco.PdfGenerator.PageMargins();
            HtmlMargins.Top = 10;
            HtmlMargins.Bottom = 10;
            var pdfBytes = htmlToPdf.GeneratePdf(LayoutHtmlGenerado);

            return pdfBytes;
        }

    }

    public partial class GenerarPdfEtiquetaCapturistaBR2 : eaton.Rules.SharedBusinessRules
    {
        public byte[] GenerarHojaCapturaSurtidor(string LayoutHtmlGenerado)
        {
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
            var HtmlMargins = new NReco.PdfGenerator.PageMargins();
            HtmlMargins.Top = 10;
            HtmlMargins.Bottom = 10;
            var pdfBytes = htmlToPdf.GeneratePdf(LayoutHtmlGenerado);

            return pdfBytes;
        }

    }


}


