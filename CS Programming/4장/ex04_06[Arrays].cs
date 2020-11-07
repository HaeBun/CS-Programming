using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_06_Arrays_
    {
        // 코드 4-6 : 배열의 범위를 벗어나는 인덱스에 접근
        static void ex04_06(string[] args)
        {
            // 배열을 생성합니다
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 요소의 길이를 출력합니다.
            Console.WriteLine(intArray[5]);
        }
    }
}
