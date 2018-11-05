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

            foreach (int n in name.Keys)
            {

                if (n == i)
                
                    Console.WriteLine(name[60030049]); 
                else if (n == i)
                    Console.WriteLine(name[60030007]);
                
            }
        }
    }
}
