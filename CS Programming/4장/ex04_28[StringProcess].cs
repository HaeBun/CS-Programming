using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_28_StringProcess_
    {
        // 코드 4-28 : 문자열 양 옆의 공백 제거
        static void ex04_28(string[] args)
        {
            string input = " test    \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }
    }
}
