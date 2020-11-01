using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_24_Variables_
    {
        // 코드 2-24 : 오버플로우
        static void ex02_24(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a + b);
        }
    }
}
