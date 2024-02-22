using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        private static int DoubleInt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
        static void Main(string[] args)
        {
            int[] numbers = {1, 5, 3, 6, 10, 12, 8 };

            var query = numbers
                        .Select(n => DoubleInt(n));

            Console.WriteLine("Before the foreach loop");
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
