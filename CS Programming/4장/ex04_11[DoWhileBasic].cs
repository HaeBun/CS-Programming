using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_11_DoWhileBasic_
    {
        // 코드 4-11 : do while 반복문 활용하기
        static void ex04_11(string[] args)
        {
            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}
