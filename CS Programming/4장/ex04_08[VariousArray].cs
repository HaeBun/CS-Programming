using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_08_VariousArray_
    {
        // 코드 4-8 : 특정한 크기의 배열 생성
        static void ex04_08(string[] args)
        {
            // 배열을 생성합니다.
            int[] intArray = new int[100];

            // 배열의 처음과 마지막 요소를 출력합니다.
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
        }
    }
}
