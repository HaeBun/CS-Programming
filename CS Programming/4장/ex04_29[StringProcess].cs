using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_29_StringProcess_
    {
        // 코드 4-29 : 배열을 문자열로 변환
        static void ex04_29(string[] args)
        {
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
    }
}
