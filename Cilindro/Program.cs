using System;
using System.Text;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ola! Vou gerar um cilindro!");
            Console.WriteLine("Insira uma altura");
            /// <summary>
            /// Keeps user inserted value
            /// </summary>
            /// <returns></returns>
            string a = Console.ReadLine();//altura
            /// <summary>
            /// Converts user inserted value
            /// </summary>
            /// <returns></returns>
            int A = Convert.ToInt32(a);
            Console.WriteLine("Insira um raio");
            /// <summary>
            /// Keeps user inserted value
            /// </summary>
            /// <returns></returns>
            string r = Console.ReadLine();//raio
            /// <summary>
            /// Converts user inserted value
            /// </summary>
            /// <returns></returns>
            int R = Convert.ToInt32(r);
            /// <summary>
            /// Calculates value
            /// </summary>
            double volume = Math.PI * R * R *A ;//calcula o volume
            /// <summary>
            /// calculates value
            /// </summary>
            /// <param name="A"></param>
            /// <returns></returns>
            double area = 2*Math.PI*R*(R + A);//calcula a area
            /// <summary>
            /// Shows value with 1 decimal
            /// </summary>
            /// <value></value>
            string resultadoVolume = $"Volume do cilindro = \u03C0 * raio^2 * altura = {volume:f1}";
            /// <summary>
            /// shows value with 2 decimal
            /// </summary>
            /// <param name="altura"></param>
            /// <returns></returns>
            string resultadoArea = $"Area da superficie do cilindro = 2\u03C0 * raio + (raio + altura) = {area:f2}";
            Console.WriteLine(resultadoVolume);
            Console.WriteLine(resultadoArea);
            Console.WriteLine();
        }
    }
}
