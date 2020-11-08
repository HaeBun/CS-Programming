using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_17_ForeachBasic_
    {
        // 코드 4-17 : foreach 반복문과 배열
        static void ex04_17(string[] args)
        {
            // 변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복을 수행합니다.
            foreach (string item in array)
            {
                // 출력합니다.
                Console.WriteLine(item);
            }
        }
    }
}
