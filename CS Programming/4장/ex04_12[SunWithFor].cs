using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_12_SunWithFor_
    {
        // 코드 4-12 : for 반복문으로 덧셈하기
        static void ex04_12(string[] args)
        {
            // 변수를 선언합니다.
            int output = 0;

            // 반복을 수행합니다.
            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }

            // 출력합니다.
            Console.WriteLine(output);
        }
    }
}
