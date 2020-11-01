using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_45_Operators_
    {
        // 코드 2-45 : 후위 증감 증산자
        static void ex02_45(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number); number += 1;
            Console.WriteLine(number); number -= 1;
            Console.WriteLine(number);
        }
    }
}
