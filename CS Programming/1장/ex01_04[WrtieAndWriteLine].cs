using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._1장
{
    class WrtieAndWriteLine
    {
        // 코드 1-4 : Write()와 WriteLine() 메서드의 차이
        static void ex01_04(string[] args)
        {
            Console.Write("Write");
            Console.WriteLine("WriteLine");

            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");

            Console.Write("Write");
            Console.Write("Write");
        }
    }
}
