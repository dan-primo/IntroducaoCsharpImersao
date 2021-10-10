using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IntroducaoCsharpImersaoDotnet
{
    public class Dates
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                DateTime date = new DateTime(2021, 10, 10);

                Console.WriteLine(date.ToLongDateString());
                // Print complete date

                Console.WriteLine(date.ToString("dd . yyyy . MM - hh:mm:ss"));
                // Print custom date and hour

                Console.WriteLine(DateTime.Now);
                //print update date and time

                Console.WriteLine(DateTime.Today.AddDays(2));
                // print date adding 2 days. To decrease, just add the minus sin -2

                Console.Write((DateTime.Today - new DateTime(2021, 10, 10)).Days);
                // day count

                var formatingDate = DateTime.Today - TimeSpan.FromDays(2);
                Console.WriteLine(formatingDate);
                //represents a time interval
                Console.ReadLine();
            }
        }
    }
}
