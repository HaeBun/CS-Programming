using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_36_StringVariable_
    {
        // 코드 2-36 : 문자열 변수 생성
        static void ex02_36(string[] args)
        {
            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);
        }
    }
}
