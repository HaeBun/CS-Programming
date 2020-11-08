using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._4장
{
    class ex04_27_StringProcess_
    {
        // 코드 4-27 : 문자열 자르기
        static void ex04_27(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
