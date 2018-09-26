using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool
            bool name = false;
            name = true;
            Console.WriteLine(name);
            if (true)
                Console.WriteLine("true");

            else
                Console.WriteLine(true);


            //float
            float f5 = 2.4f;
            float f6 = 3.4f;

            float Result = f5 * f6;
            Console.WriteLine(f5 * f6);
            

            Console.ReadKey();

        }
    }
}
