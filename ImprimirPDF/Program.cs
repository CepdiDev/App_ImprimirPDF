using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Controls.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimirPDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                var doc = PdfDocument.Load(@"C:\ITC_CFDI\fappeal\Infra\OutFilePDF\SAT\FACTURA\2022\06\FFA529_PP_250693.pdf");                        
                var printDoc = new PdfPrintDocument(doc);
            PrintController printController = new StandardPrintController() ;
            printDoc.PrinterSettings= new PrinterSettings() { PrinterName= "OneNote for Windows 10" };
            printDoc.DocumentName = "Documento911";
                printDoc.PrintController = printController;
                printDoc.Print(); // Print PDF document
                printDoc.Dispose();  
            //PrintDocument
            //using (IOStream = new FileStream(@"C:\ITC_CFDI\fappeal\Infra\OutFilePDF\SAT\FACTURA\2022\06\FFA529_PP_250693.pdf", FileMode.Open, FileAccess.Read))
            //{
            //    using (PrintDocument pd = new PrintDocument())
            //    {
            //        _qu = new PagingImage(path);

            //        pd.PrintPage += new PrintPageEventHandler((sender, ev) =>
            //        {
            //            var img = _qu.GetPage(page);
            //            if (img == null)
            //            {
            //                ev.HasMorePages = false;
            //                return;
            //            }
            //            ev.Graphics.DrawImage(img, ev.Graphics.VisibleClipBounds);
            //            page++;
            //            ev.HasMorePages = _qu.Max >= page;
            //        });
            //        pd.PrinterSettings.PrinterName = pname;
            //        pd.Print();

            //    }
            //}

            //Process p = new Process();
            //p.StartInfo = new ProcessStartInfo()
            //{
            //    CreateNoWindow = true,
            //    Verb = "print",
            //    FileName = @"C:\ITC_CFDI\fappeal\Infra\OutFilePDF\SAT\FACTURA\2022\06\FFA529_PP_250693.pdf"
            //};
            //p.Start();
        
        }
    }
}
