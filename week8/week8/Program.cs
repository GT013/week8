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
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            Console.WriteLine("======before======");
            foreach (int n in list1)
            {
                Console.WriteLine(n);
            }
            list1.RemoveAt(3);
            Console.WriteLine("======After=======");
            foreach(int n in list1)
            {
                Console.WriteLine(n);
            }

        }
    }
}
