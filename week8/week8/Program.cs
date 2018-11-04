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

            var sortDescending = from mo in month
                                 orderby mo descending
                                 select mo;
            var sortAscen = from moo in month orderby moo select moo;
            Console.WriteLine("================Descending================");
            foreach(string m in sortDescending)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("================Ascending================");
            foreach (string m in sortAscen)
            {
                Console.WriteLine(m);
            }
        }
    }
}
