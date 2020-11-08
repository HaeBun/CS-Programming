using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_15_Loops_
    {
        // 코드 4-15 : 시간을 사용한 반복문 이탈
        static void ex04_15(string[] args)
        {
            // 변수를 선언합니다.
            long start = DateTime.Now.Ticks;
            long count = 0;

            // 반복을 수행합니다 : 10000000Tick = 1초
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            // 출력합니다.
            Console.WriteLine(count + "만큼 반복했습니다.");
        }
    }
}
