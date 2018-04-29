using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            exporter = new PDFExporter();
            exporter.ExportFormatedData();

            Console.Read();
        }
    }
}