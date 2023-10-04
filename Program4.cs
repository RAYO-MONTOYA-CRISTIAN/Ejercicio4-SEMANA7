using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                for (int a = 0; a < numero; a++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
        }
    }
}
