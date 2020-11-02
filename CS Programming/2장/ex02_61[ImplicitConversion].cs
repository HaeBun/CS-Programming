using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_61_ImplicitConversion_
    {
        // 코드 2-61 : 자동 자료형 변환
        static void ex02_61(string[] args)
        {
            // int 자료형의 숫자를 생성합니다.
            int intNumber = 2147483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
    }
}
