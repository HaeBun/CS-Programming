using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_12_SwitchWithoutBreak_
    {
        // 코드 3-12 : break 키워드를 사용하지 않는 switch 조건문
        static void ex03_12(string[] args)
        {
            // 변수를 선언합니다.
            Console.Write("이번 달은 몇 월인가요: ");
            int input = int.Parse(Console.ReadLine());

            // 조건문
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
            }
        }
    }
}
