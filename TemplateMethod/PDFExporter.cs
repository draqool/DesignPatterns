using System;

namespace TemplateMethod
{
    class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}