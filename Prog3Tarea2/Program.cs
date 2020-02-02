using System;
using System.Linq;

namespace Prog3Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = new int[10];
            int num;
            for (int i = 0; i <z.Length; i++)
            {
                Console.Write("Escribe tus 10 numeros: ");
                num = int.Parse(Console.ReadLine());
                z[i] = num;

            }

            Console.WriteLine("El numero mayor es: " + z.Max());
            Console.WriteLine("El numero mayor es: " + z.Min());
        }
    }
}
