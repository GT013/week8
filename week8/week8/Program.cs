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
            list1.Add("Nantikan");
            list1.Add("Hello");
            list1.Add("Hi");
            list1.Add("Yeah");
            list1.Add("Ohhhhhh");
            Console.WriteLine("======before======");
            foreach (string n in list1)
            {
                Console.WriteLine(n);
            }
            list1.Remove("Hi");
            Console.WriteLine("======After=======");
            foreach(string n in list1)
            {
                Console.WriteLine(n);
            }

        }
    }
}
