using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_40_AssignmentOperator_
    {
        // 코드 2-40 : 숫자와 관련된 복합 대입 연산자 예제 풀어쓰기
        static void ex02_40(string[] args)
        {
            int output = 0;
            output = output + 52;
            output = output + 273;
            output = output + 103;

            Console.WriteLine(output);
        }
    }
}
