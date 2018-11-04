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
            string t;
            Dictionary<string, string> d1 = new Dictionary<string, string>();

            Console.Write("Type File = ");
            t = Console.ReadLine();
            d1.Add("txt", "Notepad.exe");
            d1.Add("bmp", "paint.exe");
            d1.Add("rtf", "wordpad.exe");
            d1.Add("pdf", "acrobat.exe");
            
          
            if (t=="pdf")
            {
                Console.WriteLine(d1["pdf"]);
            }
            else if (t=="txt")
            {
                Console.WriteLine(d1["txt"]);
            }
            else if (t=="bmp")
            {
                Console.WriteLine(d1["bmp"]);
            }
            else if (t == "rtf")
            {
                Console.WriteLine(d1["rtf"]);
            }
            else
            {
                Console.WriteLine("No Program!!!");
            }

        }
    }
}
