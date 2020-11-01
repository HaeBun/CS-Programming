using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._2장
{
    class ex02_49_DirectTypeCheck_
    {
        // 코드 2-49 : 직접적인 GetType() 메서드 활용
        static void ex02_49(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('글').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }
}
