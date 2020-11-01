using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_47_Operators_
    {
        // 코드 2-47 : 여러 줄로 나누어 적은 증감 연산자
        static void ex02_47(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            number++;
            number++;
            Console.WriteLine(number);
            Console.WriteLine(number);
            number--;
            number--;
            Console.WriteLine(number);
        }
    }
}
