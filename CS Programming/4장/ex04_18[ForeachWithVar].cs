using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_18_ForeachWithVar_
    {
        // 코드 4-18 : foreach 반복문과 var 키워드
        static void ex04_18(string[] args)
        {
            // 변수를 선언합니다.
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            // 반복을 수행합니다.
            foreach (var item in array)
            {
                // 출력합니다.
                Console.WriteLine(item);
            }
        }
    }
}
