using System;

namespace IntroducaoCsharpImersaoDotnet
{
    public class LoopsAndInteraction
    {
        public static void Main(string[] args)
        {
            // var name = "John";
            var age = 12;
            var ofLegalAge = age >= 18;

            var numbers = new int[] {1, 2, 3, 4 };

            foreach (var temp in numbers)
            {
                Console.WriteLine(temp);
            }

            Console.ReadLine();
        }
    }
}