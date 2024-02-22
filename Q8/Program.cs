using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query1a = from name in names
                          where name.Length > 4 && name[0] == 'M'
                          orderby name
                          select name;

            var query1b = names
                          .Where(name => name.Length > 4 && name[0] == 'M')
                          .OrderBy(name => name)
                          .Select(name => name);

            foreach (var item in query1b)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
