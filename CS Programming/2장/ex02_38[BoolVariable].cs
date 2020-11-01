using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_38_BoolVariable_
    {
        // 코드 2-38 : 불 변수 생성
        static void ex02_38(string[] args)
        {
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
        }
    }
}
