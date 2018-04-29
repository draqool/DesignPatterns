using System;

namespace TemplateMethod
{
    abstract class DataExporter
    {
        public abstract void ExportData();

        public void ReadData()
        {
            Console.WriteLine("Reading the data from SqlServer");
        }

        public void FormatData()
        {
            Console.WriteLine("Formating the data as per requriements.");
        }
        
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }
    }
}