using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_60_NumberLost_
    {
        // 코드 2-60 : 숫자 손상
        static void ex02_60(string[] args)
        {
            // long 자료형을 int 자료형으로 변환
            long longNumber = 2147483647L + 2147483647L;
            int longToInt = (int)longNumber;
            Console.WriteLine(longToInt);

            // double 자료형을 int 자료형으로 변환
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
    }
}
