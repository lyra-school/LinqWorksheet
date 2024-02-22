using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"c:\windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length descending, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime,
                        };
            Console.WriteLine("{0,-40}{1,6} KB {2}", "Filenames", "Size", "Creation Date");
            foreach (MyFileInfo item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
