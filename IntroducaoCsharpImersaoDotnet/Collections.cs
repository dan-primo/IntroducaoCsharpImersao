using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroducaoCsharpImersaoDotnet
{
    public class Collections
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var names = new string[]
                {
                    "Ana",
                    "Marie",
                    "John",
                    "Willian",
                    "Robert"

                };

                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }

                var citys = new List<string>
                {
                    "Berlin",
                    "New York",
                    "São Paulo",
                    "Dublin",
                    "Paris",
                    "London",
                    "San Francisco"
                };

                citys.Add("Cork");

                var filter = from c in citys where c.StartsWith("S") select c;

                foreach (var city in filter)
                {
                    Console.WriteLine(city);
                }

                //lambda expression

                var filterLambda = citys.Where(x => x.StartsWith("L"));

                foreach (var city in citys)
                {
                    Console.WriteLine(city);
                }

                Console.ReadLine();
            }
        }
    }
}
