using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_24_ContinueBasic_
    {
        // 코드 4-24 : continue 키워드
        static void ex04_24(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
