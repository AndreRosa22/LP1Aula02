using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = Int32.MinValue;
            int b = Int32.MaxValue;
            double c = double.MinValue;
            double d = double.MaxValue;
            float e = float.MinValue;
            float f = float.MaxValue;
            short g = short.MinValue;
            short h = short.MaxValue;
            byte i = byte.MinValue;
            byte j = byte.MaxValue;
            long k = long.MinValue;
            long l = long.MaxValue;
            uint m = uint.MinValue;
            uint n = uint.MaxValue;
            ulong o = ulong.MinValue;
            ulong p = ulong.MaxValue;
            double q = double.NegativeInfinity;
            double r = double.PositiveInfinity;
            float s = float.NegativeInfinity;
            float t = float.PositiveInfinity;
            float u = float.NaN;
            int v = short.MaxValue;
            float f1, f2;
            f1 = f2 = 10000.0f;
            int w = 22, x = 6, y, z1 = 3, z2 = 9, z3;
            y = w++ + x++;
            z3 = --z1 + --z2;

            Console.WriteLine("Minimo de int " + a);
            Console.WriteLine("Máximo de int " + b);
            Console.WriteLine("Minimo de double " + c);
            Console.WriteLine("Máximo de double " + d);
            Console.WriteLine("Minimo de float " + e);
            Console.WriteLine("Máximo de float " + f);
            Console.WriteLine("Minimo de short " + g);
            Console.WriteLine("Máximo de short " + h);
            Console.WriteLine("Minimo de byte " + i);
            Console.WriteLine("Máximo de byte " + j);
            Console.WriteLine("Minimo de long " + k);
            Console.WriteLine("Máximo de long " + l);
            Console.WriteLine("Minimo de uint " + m);
            Console.WriteLine("Máximo de uint " + n);
            Console.WriteLine("Minimo de ulong " + o);
            Console.WriteLine("Máximo de ulong " + p);
            Console.WriteLine("Infinito negativo de double " + q);
            Console.WriteLine("Infinito positivo de double " + r);
            Console.WriteLine("Infinito negativo de float " + s);
            Console.WriteLine("Infinito positivo de float " + t);
            Console.WriteLine((short)(v + 1));
            Console.WriteLine("Não é númmero -> " + u);
            Console.WriteLine(f1 == f2 + 0.0001f);
            Console.WriteLine("w = " + w);
            Console.WriteLine("x= " + x);
            Console.WriteLine("y = w + x = " + y);//Resultado é 28 mas é o esperado! sufixos fazem as contas todas primeiro e incrementos depois!
            Console.WriteLine("z1= " + z1);
            Console.WriteLine("z2= " + z2);
            Console.WriteLine("z3 = z1 + z2 = " + z3);
            Console.WriteLine();
            Console.WriteLine("Prime ENTER para sair");
            Console.ReadKey();
        }
    }
}
