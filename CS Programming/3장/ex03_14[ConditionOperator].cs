using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_14_ConditionOperator_
    {
        // 코드 3-14 : 삼항 연산자
        static void ex03_14(string[] args)
        {
            // 변수를 선언합니다
            string input = Console.ReadLine();
            int number = int.Parse(input);

            // 조건을 구분합니다
            Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");
        }
        
    }
}
