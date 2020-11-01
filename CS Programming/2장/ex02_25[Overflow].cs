using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_25_Overflow_
    {
        // 코드 2-25 : 오버플로우
        static void ex02_25(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);
        }
    }
}
