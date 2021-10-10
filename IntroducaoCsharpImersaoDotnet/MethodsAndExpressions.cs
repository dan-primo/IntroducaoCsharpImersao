using System;

namespace IntroducaoCsharpImersaoDotnet
{
    public class MethodsAndExpressions
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                var numbers = NumberCollection();
                Interaction(numbers);

                Console.ReadLine();
            }

            private static int[] NumberCollection()
            {
                return new int[] { 1, 2, 3, 4 };
            }

            private static void Interaction(int[] numbers)
            {
                foreach (var temp in numbers)
                {
                    Console.WriteLine((temp + 1));
                }
            }
        }
    }
}
