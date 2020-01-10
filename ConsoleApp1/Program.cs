using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IT STEP");

            Console.WriteLine("искандербони");

            string name = "ЧИКИБОМБОНИ";

            Console.WriteLine($"menya zovut {name}");
            Console.Write("Введите хобби");
            string hobby = Console.ReadLine();

            dfint age  = Convert.ToInt32( Console.ReadLine()  );

            Console.ReadKey();
        }
    }

}
