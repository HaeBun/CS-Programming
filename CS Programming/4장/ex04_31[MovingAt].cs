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
    class ex04_31_MovingAt_
    {
        // 코드 4-31 : Thread.Sleep() 메서드
        static void ex04_31(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }
}
