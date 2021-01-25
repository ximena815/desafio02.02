using System;

namespace Desafio02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            Console.WriteLine("ingrese t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese aGrados: ");
            double aGrados = double.Parse(Console.ReadLine());

            //Proceso
            double a = aGrados * (Math.PI / 180.0);

            double z = ((Math.Cos(a)) * t);

            Console.WriteLine("z: " + z);

            double y = Math.Sqrt(((t) * (t)) - ((z) * (z)));
            Console.WriteLine("y: " + y);

            double c = 180 - 90 - aGrados;
            Console.WriteLine("c: " + c);

        }
    }
}
