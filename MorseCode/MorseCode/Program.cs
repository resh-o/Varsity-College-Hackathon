using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] TranslatedMorse = { "    |", " . - |", " - . . . |", " - . - . |", " - . . |", " . |", " . . - . |"
                    , " - - . |", " . . . . |", " . . |", " . - - - |", " - . - |", " . - . . |", " - - |",
                " - . |", " - - - |", " . - - . |", " - - . - |", " . - . |", " . . . |", " _ |", " . . - |",
                " . . . - |", " . - - |", " - . . - |", " - . - - |", " - - . . |", " . - - - - |",
                " . . - - - |", " . . . - - |", " . . . . - |", " . . . . . |", " - . . . . |", " - - . . . |",
                " - - - . . |", " - - - - . |", " - - - - - |" };
            const string filePath = "file.txt";
            var reader = new SpecifLinfromTextReader(filePath);
            Console.WriteLine("Enter the line number you want to read:");
            if (int.TryParse(Console.ReadLine(), out int lineNumber))
            {
                string line = reader.ReadLine(lineNumber);
                if (line != null)
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                }
                else
                {
                    Console.WriteLine($"Line {lineNumber} does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid line number.");
            }
            string ToTranslate = Convert.ToString(lineNumber);
            string TranslatedText = "";
        
                for (int i = 0; i < ToTranslate.Length; i++)
                {
                    for (int j = 0; j < 37; j++)
                    {
                        if (ToTranslate[i] == text[j])
                        {
                            TranslatedText += TranslatedMorse[j];
                            break;
                        }
                    }
                }
                Console.WriteLine($"Translated text: {TranslatedText}");
            var writer = new FileWriter(filePath);
            writer.Write(TranslatedText);
            Console.WriteLine("Enter morse code using '.' or '-', split each letter by space, whole words split by two spaces");
            ToTranslate = Console.ReadLine();

            Console.ReadLine();
        }
        

        }
    }
