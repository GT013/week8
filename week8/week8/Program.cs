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
            string[][] land = new string[6][];
            land[0] = Asa;
            Console.WriteLine("=========Asia=========");
            Console.WriteLine();

        }
        static string[] Asa = new string[]
        {
            "Cambodia","Qatar","South Korea","North Korea","Kazakhstan","Kyrgyzstan","Japan","Timor-Leste"
        };
        static string[] Os = new string[]
        {
            "Kiribati","Samoa","Tonga","Tuvalu","Nauru","New Zealand","Papua New Guinea","Fiji","Palau","Micronesia"
        };
        static string[] Ur = new string[]
        {
            "Greece","Kosovo","Croatia","Czechia","Vatican City State","Norway"
        };
        static string[] Af = new string[]
        {
            "Ghana","Gabon","Guinea-Bissau","Djibouti"
        };
        static string[] AmNo = new string[]
        {
            "Guatemala","Grenada","Saint Vincent and the Grenadines"
        };
        static string[] AmSo = new string[]
        {
            "Guyana","Colombia","Chile","Suriname"
        };
    }
}
