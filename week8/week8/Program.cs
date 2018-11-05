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
            int[,] multiplyTable = new int[12, 12];
            for (int i = 0,j=1; i <= 12&&j<=12; i++,j++)
            {
                
                
                    multiplyTable[0, i] = j * 1;
                    multiplyTable[1, i] = j * 2;
                    multiplyTable[2, i] = j * 3;
                    multiplyTable[3, i] = j * 4;
                    multiplyTable[4, i] = j * 5;
                    multiplyTable[5, i] = j * 6;
                    multiplyTable[6, i] = j * 7;
                    multiplyTable[7, i] = j * 8;
                    multiplyTable[8, i] = j * 9;
                    multiplyTable[9, i] = j * 10;
                    multiplyTable[10, i] = j * 11;
                    multiplyTable[11, i] = j * 12;
                
            }
            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                    Console.Write("{0,5}", multiplyTable[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
