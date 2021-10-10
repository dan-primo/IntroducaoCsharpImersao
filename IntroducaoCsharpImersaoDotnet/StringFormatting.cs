using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharpImersaoDotnet
{
    public class StringFormatting
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                object[] parameters = { "Christmas", 2021, 800000, 100000000 };

                String result = String.Format("{0} in {1}: population {2:N0}, area {3:N1} m²", parameters);

                Console.WriteLine(result);

                Console.Read();
            }
        }
    }
}
