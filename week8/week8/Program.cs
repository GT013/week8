using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Hashtable name = new Hashtable();
            Console.WriteLine("Enter id = ");
            i = int.Parse(Console.ReadLine());

            name.Add(60030049, "Nantikan Tippawan");
            name.Add(60030007, "Kasina");
            name.Add(60030037, "Thanapol");

            if (i == 60030049)
                Console.WriteLine(name[60030049]);
            else if (i == 60030007)
                Console.WriteLine(name[60030007]);
            else if (i == 60030037)
                Console.WriteLine(name[60030037]);

        }
    }
}
