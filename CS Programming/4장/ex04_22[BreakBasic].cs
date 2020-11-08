using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_22_BreakBasic_
    {
        // 코드 4-22 : break 키워드
        static void ex04_22(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }
            }
        }
    }
}
