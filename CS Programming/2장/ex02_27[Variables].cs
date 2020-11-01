using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_27_Variables_
    {
        // 코드 2-27 : uint와 ulong 자료형
        static void ex02_27(string[] args)
        {
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
        }
    }
}
