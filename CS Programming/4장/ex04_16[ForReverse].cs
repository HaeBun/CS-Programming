using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_16_ForReverse_
    {
        // 코드 4-16 : 역 for 반복문
        static void ex04_16(string[] args)
        {
            // 배열을 생성합니다.
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            // 요소의 길이를 출력합니다.
            for(int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
