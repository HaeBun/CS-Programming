using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_59_Casts_
    {
        // 코드 2-59 : 강제 자료형 변환의 데이터 손실
        static void ex02_59(string[] args)
        {
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
