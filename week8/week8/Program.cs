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

            Hashtable p = new Hashtable();
            p.Add("61110", "Uthaithani");
            p.Add("72000", "suphan");
            p.Add("81000", "Kabee");

            Console.WriteLine("pls input num: ");
            Console.WriteLine("" + p.ContainsKey(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
