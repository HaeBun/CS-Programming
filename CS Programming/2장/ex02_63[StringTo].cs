using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_63_StringTo_
    {
        // 코드 2-63 : 문자열을 숫자로 변환
        static void ex02_63(string[] args)
        {
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());
        }
    }
}
