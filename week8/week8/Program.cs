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

            string[][] md1 = new string[2][];
            md1[0] = new string[] { "Sunday", "Monday", "Tyesday", "Wendsday", "Thursday", "Friday", "Saterday" };
            md1[1] = new string[] { "Jan", "Feb", "Mar", "April", "May", "June",
                "July", "August", "Sep", "Oc", "November", "December" };

            for (int row=0;row<md1.Length;row++)
            {
               for(int col = 0;col<md1[row].Length;col++)
                
                    Console.Write(md1[row][col]+" ");
                    Console.WriteLine();
                

            }

        }
    }
}
