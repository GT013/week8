using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "Desember" };

            string value1 = Array.Find(month, m => m.Length<=3);
            string value2 = Array.Find(month, m => m.Length > 10);
            string[] value3 = Array.FindAll(month, m => m.StartsWith("J", StringComparison.Ordinal));

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(string.Join(",", value3));

        }
    }
}
