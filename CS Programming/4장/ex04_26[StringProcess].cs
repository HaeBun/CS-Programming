using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_26_StringProcess_
    {
        // 코드 4-26 : 대문자화와 소문자화
        static void ex04_26(string[] args)
        {
            string input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
        }
    }
}
