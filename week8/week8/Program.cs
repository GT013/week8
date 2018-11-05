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
            string[][] land = new string[1][];
            land[0] = Asa;
            Console.WriteLine("\n==================Asia=====================");
            for (int row = 0; row < land.Length; row++)
            {
                for (int col = 0; col < land[row].Length; col++)
                {
                    Console.Write(land[row][col] + ", ");
                }
            }

            Console.WriteLine("\n==================Os=====================");
            string[][] land1 = new string[1][];
            land1[0] = Os;
            for (int row = 0; row < land1.Length; row++)
            {
                for (int col = 0; col < land1[row].Length; col++)
                {
                    Console.Write(land1[row][col] + ", ");
                }
            }

            Console.WriteLine("\n==================Ur=====================");
            string[][] land2 = new string[1][];
            land2[0] = Ur;
            for (int row = 0; row < land2.Length; row++)
            {
                for (int col = 0; col < land2[row].Length; col++)
                {
                    Console.Write(land2[row][col] + ", ");
                }
            }

            Console.WriteLine("\n==================Af=====================");
            string[][] land3 = new string[1][];
            land3[0] = Af;
            for (int row = 0; row < land3.Length; row++)
            {
                for (int col = 0; col < land3[row].Length; col++)
                {
                    Console.Write(land3[row][col] + ", ");
                }
            }

            Console.WriteLine("\n==================AmNo=====================");
            string[][] land4 = new string[1][];
            land4[0] = AmNo;
            for (int row = 0; row < land4.Length; row++)
            {
                for (int col = 0; col < land4[row].Length; col++)
                {
                    Console.Write(land4[row][col] + ", ");
                }
            }

            Console.WriteLine("\n==================AmSo=====================");
            string[][] land5 = new string[1][];
            land5[0] = AmSo;
            for (int row = 0; row < land5.Length; row++)
            {
                for (int col = 0; col < land5[row].Length; col++)
                {
                    Console.Write(land5[row][col] + ", ");
                }
            }

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
