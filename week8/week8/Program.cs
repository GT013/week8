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
            p.Add("81000", "Krabee");
            p.Add("17000", "Chinat");
            p.Add("71000", "Kanjanaburi");
            p.Add("40000", "Konkan");
            p.Add("2200", "Janthaburi");
            p.Add("24000", "Chachoengsao");
            p.Add("20000", "Chonburi");

            foreach (DictionaryEntry pp in p)
            {
                Console.WriteLine(pp.Key + "=" + pp.Value);
            }
            Console.WriteLine("==========Post Office=========");
            Console.Write("PostOffice id =  ");
            Console.WriteLine("" + p.ContainsKey(Console.ReadLine()));
 
        }
    }
}
