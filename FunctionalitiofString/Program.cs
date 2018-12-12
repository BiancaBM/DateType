using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalitiofString
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Numarul 20 e mai MIC ca numarul 30.Numarul 10 e mai mare ca numarul 5.";
            if (!string.IsNullOrEmpty(paragraph))
            {
                string mare = "mare";
                int index = paragraph.IndexOf(mare);
                if (index != -1)
                {
                    string before = paragraph.Substring(0, index);
                    string after = paragraph.Substring(index + mare.Length);
                    paragraph = string.Format("{0}{1}{2}", before, mare.ToUpper(), after);
                }

                string mic = "MIC";
                if (paragraph.Contains(mic))
                {
                    paragraph = paragraph.Replace(mic, mic.ToLower());
                }

                string[] values = paragraph.Split('.');
                foreach (string value in values)
                {
                    Console.WriteLine(value);
                }
            }

        }
    }
}
