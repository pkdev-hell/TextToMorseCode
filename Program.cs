using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text to convert to Morse Code:: ");
            string input = Console.ReadLine();

            string output = ConvertToMorseCode(input);

            Console.WriteLine("Morse Code: " + output);
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey(false);
        }

        private static string ConvertToMorseCode(string input)
        {
            char[] characters = input.ToUpper().ToCharArray();            
            MorseCodeDictionary md = new MorseCodeDictionary();
            StringBuilder sb = new StringBuilder();

            foreach (char c in characters)
            {
                if (!c.Equals(' '))
                {
                    if (md.MorseCodes.ContainsKey(c))
                        sb.Append(md.MorseCodes[c].ToString());
                }
                else
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
