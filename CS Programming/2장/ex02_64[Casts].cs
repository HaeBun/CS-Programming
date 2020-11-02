using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_64_Casts_
    {
        // 코드 2-64 : 숫자로 변환할 수 없는 문자열을 변환하는 경우
        static void ex02_64(string[] args)
        {
            Console.WriteLine(int.Parse("52.273"));
            Console.WriteLine(int.Parse("abc"));
        }
    }
}
