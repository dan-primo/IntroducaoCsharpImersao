using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharpImersaoDotnet
{
    public class Numbers
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                float a = 3.12341234f * 2;
                double b = 3.1234123d * 2;
                decimal c = 3.12341234m * 2;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

                Console.Read();
            }
        }
    }
}
