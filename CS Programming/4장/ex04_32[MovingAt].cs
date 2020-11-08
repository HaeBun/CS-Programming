using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*  Thread 클래스를 사용하려면 입력해야 하는 코드입니다. 
    이를 자동으로 입력하는 방법은 이후에 살펴보는데요. 
    일단 지금은 직접 입력해보도록 합시다.                */

namespace CS_Programming._4장
{
    class ex04_32_MovingAt_
    {
        // 코드 4-32 : 이동하는 달팽이
        static void ex04_32(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다.
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
