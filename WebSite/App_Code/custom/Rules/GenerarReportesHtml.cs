using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using NReco.PdfGenerator;

/// <summary>
/// Descripción breve de GenerarReportesHtml
/// </summary>
public class GenerarReportesHtml
{
    public GenerarReportesHtml()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public byte[] GenerarReporteDinamico(string LayoutHtmlGenerado, string PageWidth, string PageHeight, string Landscape)
    {
        //conversion de valores string float
        float Width_Layout = Convert.ToSingle(PageWidth);
        float Height_Layout = Convert.ToSingle(PageHeight);

        var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
        htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
        htmlToPdf.PageHeight = Height_Layout;
        htmlToPdf.PageWidth = Width_Layout;
        //generamos margenes para documentos
        htmlToPdf.Margins.Top = 2;
        htmlToPdf.Margins.Bottom = 1;
        htmlToPdf.Margins.Left = 1;
        htmlToPdf.Margins.Right = 1;
        //var HtmlMargins = new NReco.PdfGenerator.PageMargins();
        //HtmlMargins.Top = 10;
        //HtmlMargins.Bottom = 10;
        var pdfBytes = htmlToPdf.GeneratePdf(LayoutHtmlGenerado);

        return pdfBytes;

    }

    public byte[] GenerarReporteDinamicosnLandscape(string LayoutHtmlGenerado, string PageWidth, string PageHeight, string Landscape)
    {
        //conversion de valores string float
        float Width_Layout = Convert.ToSingle(PageWidth);
        float Height_Layout = Convert.ToSingle(PageHeight);

        var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
        //htmlToPdf.Orientation = NReco.PdfGenerator.PageOrientation.Landscape;
        htmlToPdf.PageHeight = Height_Layout;
        htmlToPdf.PageWidth = Width_Layout;
        //generamos margenes para documentos
        htmlToPdf.Margins.Top = 2;
        htmlToPdf.Margins.Bottom = 1;
        htmlToPdf.Margins.Left = 0;
        htmlToPdf.Margins.Right = 0;
        //var HtmlMargins = new NReco.PdfGenerator.PageMargins();
        //HtmlMargins.Top = 10;
        //HtmlMargins.Bottom = 10;
        var pdfBytes = htmlToPdf.GeneratePdf(LayoutHtmlGenerado);

        return pdfBytes;
    }
}