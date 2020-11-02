using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_01_IfBasic_
    {
        // 코드 3-1 : 홀수 짝수 구분(1)
        static void ex03_01(string[] args)
        {
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());
            
            if(input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }

            if(input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }
        }
    }
}
