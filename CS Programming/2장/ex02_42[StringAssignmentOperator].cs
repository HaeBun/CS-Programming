using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_42_StringAssignmentOperator_
    {
        // 코드 2-42 : 문자열과 관련된 복합 대입 연산자 예제 풀어쓰기
        static void Main(string[] args)
        {
            string output = "hello ";
            output = output + "world ";
            output = output + "!";

            Console.WriteLine(output);
        }
    }
}
