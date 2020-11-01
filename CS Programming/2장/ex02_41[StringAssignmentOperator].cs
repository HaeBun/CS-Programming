using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_41_StringAssignmentOperator_
    {
        // 코드 2-41 : 문자열과 관련된 복합 대입 연산자
        static void ex02_41(string[] args)
        {
            string output = "hello ";
            output += "world ";
            output += "!";

            Console.WriteLine(output);
        }
    }
}
