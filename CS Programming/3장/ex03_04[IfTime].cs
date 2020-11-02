using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_04_IfTime_
    {
        // 코드 3-4 : 오전과 오후 구분(1)
        static void ex03_04(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            
            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
