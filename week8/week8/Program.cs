using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add("1");
            list1.Add("2");
            list1.Add("3");
            list1.Add("4");
            list1.Add("5");
            list1.Add("6");
            list1.Add("7");
           // Console.WriteLine("======before======");
            foreach (string n in list1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Indexof : {0}",list1.IndexOf("5",3));



           // Console.WriteLine("======After=======");

            //foreach(string n in list1)
            //{
            //    Console.WriteLine(n);
            //}

        }
    }
}
