﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Programming._3장
{
    class ex03_11_SwitchBasic_
    {
        // 코드 3-11 : switch 조건문
        static void ex03_11(string[] args)
        {
            // 변수를 선언합니다.
            Console.WriteLine("숫자를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            // 조건문
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
        }
    }
}
