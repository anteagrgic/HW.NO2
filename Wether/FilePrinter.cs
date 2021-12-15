using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WeatherLibrary
{
    public class FilePrinter: IPrinter
    {
        private string FileName;

        public FilePrinter(string fileName)
        {
            FileName = fileName;
        }

        public void Print(string text)
        {
            using (StreamWriter writer = File.AppendText(FileName))
            {
                writer.WriteLine(text);
            }
              
        }

    }
}
