using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_14_KoreanCharacters_
    {
        // 코드 4-14 : 한글 전부 출력하기
        static void ex04_14(string[] args)
        {
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
