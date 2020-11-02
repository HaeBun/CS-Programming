using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_15_ConditionWithString_
    {
        // 코드 3-15 : 입력 받아 조건 분할하기
        static void ex03_15(string[] args)
        {
            Console.Write("입력 : ");
            String line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
