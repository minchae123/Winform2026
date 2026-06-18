using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUpDownConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rdNum = new Random();

            int resultNum = rdNum.Next(60);
            Console.WriteLine("1~60 까지 값을 입력하여 알아맞추세요!");

            while (true)
            {
                int inputValue = int.Parse(Console.ReadLine());
                if (resultNum == inputValue)
                {
                    Console.WriteLine("정답 " + resultNum + " ! 알아맞히셨습니다.");
                    break;
                }
                else if (resultNum > inputValue)
                {
                    Console.WriteLine("땡! " + inputValue + " UP!");
                }
                else
                {
                    Console.WriteLine("땡! " + inputValue + " DOWN!");
                }
            }
            Console.WriteLine("프로그램을 종료합니다. - 202530416 이민채 -");
        }
    }
}
