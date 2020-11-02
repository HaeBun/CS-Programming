using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_67_StringPlusNumber_
    {
        // 코드 2-67 : 숫자와 문자열 덧셈
        static void ex02_67(string[] args)
        {
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
        }
    }
}
