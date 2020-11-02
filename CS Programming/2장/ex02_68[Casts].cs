using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_68_Casts_
    {
        // 코드 2-68 : 간단한 문자열 변환
        static void ex02_68(string[] args)
        {
            int number = 52273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char character = 'a';
            string outputB = character + ""; // 문자는 문자열과 비슷하니까 그냥 변환된다고도 생각할 수 있는데요, 아쉽게도 불가능하답니다.
            Console.WriteLine(outputB);
        }
    }
}
