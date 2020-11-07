using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_10_WhileBasic_
    {
        // 코드 4-10 : while 반복문 이용하기
        static void ex04_10(string[] args)
        {
            // 변수를 선언합니다.
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };
            
            // 반복을 수행합니다
            while(i < intArray.Length)
            {
                // 출력합니다.
                Console.WriteLine(i + "번째 출력:" + intArray[i]);

                // 탈출을 위해 변수를 더합니다.
                i++;
            }
        }
    }
}
