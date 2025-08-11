using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class FileWriter
    {
        private readonly StreamWriter _streamWriter;
        public FileWriter(string filePath)
        {
            _streamWriter = new StreamWriter(filePath, true);
        }
        public void Write (string text)
        {
            _streamWriter.WriteLine(text + Environment.NewLine);
        }
    }
}
