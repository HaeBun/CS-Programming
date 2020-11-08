using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_25_ContinueBasic_
    {
        // 코드 4-25 : [코드 4-24]를 간단하게 변경
        static void ex04_25(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
