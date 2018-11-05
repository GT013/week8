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
           
            Hashtable name = new Hashtable();
           
            name.Add("60030049", "Nantikan Tippawan");
            name.Add("60030007", "Kasina");
            name.Add("60030037", "Thanapol");
            name.Add("60030029", "Natthapat");
            name.Add("60030014", "Jarudet");
            name.Add("60030031", "Thanakamon");
            name.Add("60030098", "Sittinon");
            name.Add("60030015", "Jinnapat");
            name.Add("60030112", "Avirut");
            name.Add("60030016", "Jirawat");
            name.Add("60030089", "Sarun");
            name.Add("60030041", "Thanakorn");


            Console.WriteLine("---- Computer Class ----");
            foreach (DictionaryEntry day in name)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }
            Console.WriteLine("---------------ID Student-----------");

            Console.WriteLine(" "+name.ContainsKey(Console.ReadLine()));

        }
    }
}
