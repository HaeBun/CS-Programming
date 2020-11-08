using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_13_MultiplyWithFor_
    {
        // 코드 4-13 : for 반복문으로 곱셈하기
        static void ex04_13(string[] args)
        {
            // 변수를 선언합니다.
            int output = 1;

            // 반복을 수행합니다.
            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }

            // 출력합니다.
            Console.WriteLine(output);
        }
    }
}
