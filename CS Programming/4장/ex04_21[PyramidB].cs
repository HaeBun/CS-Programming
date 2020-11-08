using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_21_PyramidB_
    {
        // 코드 4-21 : 별 피라미드(2)
        static void ex04_21(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}
