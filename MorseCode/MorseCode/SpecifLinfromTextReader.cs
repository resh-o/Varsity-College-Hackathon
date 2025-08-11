using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class SpecifLinfromTextReader
    {
       
        private readonly StreamReader _reader;
        public SpecifLinfromTextReader(string filePath)
        {
            _reader = new StreamReader(filePath);
        }
        public string ReadLine(int lineNumber)
        {
            for (int i = 0; i < lineNumber - 1; i++)
            {

                _reader.ReadLine();
            }
            return _reader.ReadLine();


        }

    }
}
