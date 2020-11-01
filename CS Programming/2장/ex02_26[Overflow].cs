using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_26_Overflow_
    {
        // 코드 2-26 : 자료형 변환을 사용한 해결 방법 3가지
        static void ex02_26(string[] args)
        {
            int a = 2000000000;
            int b = 2000000000;

            Console.WriteLine((long)a + b);
            Console.WriteLine(a + (long)b);
            Console.WriteLine((long)a + (long)b);
        }
    }
}
