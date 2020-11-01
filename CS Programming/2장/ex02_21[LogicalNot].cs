using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_21_LogicalNot_
    {
        // 코드 2-21 : 논리 부정 연산자
        static void ex02_21(string[] args)
        {
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
        }
    }
}
