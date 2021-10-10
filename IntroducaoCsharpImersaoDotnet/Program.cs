using System;

namespace introducao_csharp_imersao_dotnet
{
    class Program
    {
        public static void Main(string[] args)
        {
            var name = "Yan";
            var age = 0;

            var ofLegalAge = age > 18;

            if (ofLegalAge)
            {
                Console.WriteLine(name + "The person is of legal age.");
            }
            else if (age == 0) {
                Console.WriteLine("Invalid Age");
            }
            else {
                Console.WriteLine(name + "The person is not of legal age.");
            }

            Console.WriteLine("The" + name + "is" + age + "years old.");

            Console.ReadLine();
        }
    }
}
