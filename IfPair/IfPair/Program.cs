using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Insert number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " Es par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(num + " Es impar");
                Console.ReadKey();
            }
        }
    }
}