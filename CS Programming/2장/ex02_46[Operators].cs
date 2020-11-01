using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_46_Operators_
    {
        // 코드 2-46 : 증감 연산자 이해도 확인
        static void ex02_46(string[] args)
        {
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
        }
    }
}
