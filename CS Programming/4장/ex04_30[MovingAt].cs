using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_30_MovingAt_
    {
        // 코드 4-30 : Console.SetCursorPosition() 메서드
        static void ex04_30(string[] args)
        {
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }
    }
}
