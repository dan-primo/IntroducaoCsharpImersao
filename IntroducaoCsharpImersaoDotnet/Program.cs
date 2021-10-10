using System;

namespace introducao_csharp_imersao_dotnet
{
    class Program
    {
        public static void Main(string[] args)
        {
            var name = "Marie";
            var age = 18;

            var ofLegalAge = age >= 18;

            try
            {
                if (age == 0)
                    throw new Exception("Invalid Age");

                if (ofLegalAge)
                    Console.WriteLine(name + " is of legal age.");

                else
                    Console.WriteLine(name + " is not of legal age.");

                Console.WriteLine(name + " is " + age + " years old.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred in the system: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
