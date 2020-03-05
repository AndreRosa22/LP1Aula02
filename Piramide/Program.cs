using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insere o número de andares");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            int i, spaces;

            for (i = 0; i <= n; i++)//Executado enquanto i for menor ou igual a n
            {
                for (spaces = 1; spaces <= n - i; spaces++)//Executado enquanto spaces for menor ou igual a i - n
                    Console.Write(" ");
                for (spaces = 1; spaces <= 2 * i - 1; spaces++)//Executado enquanto spaces for menor  ou igual a (2*i) - 1
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}