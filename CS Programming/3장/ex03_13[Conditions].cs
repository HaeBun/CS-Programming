using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_13_Conditions_
    {
        // 코드 3-13 : 삼항 연산자
        static void ex03_13(string[] args)
        {
            int number = 0;
            // 참과 거짓 위치에 불 자료형 사용
            Console.WriteLine(number % 2 == 0 ? true : false);

            // 참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
