using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCsharpImersaoDotnet
{
    public class DataDictionary
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var customers = new Dictionary<long, string>();

                customers.Add(50476097070, "John");
                customers.Add(73194413066, "Marie");
                customers.Add(94643098066, "Watson");

                Console.WriteLine(customers[0]);

                var names = customers.Values.Where(x => x.StartsWith("W"));

                foreach (var firstLetter in names)
                {
                    Console.WriteLine(firstLetter);
                }

                Console.Read();
            }
        }
    }
}
