using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randNum = r.Next(100) + 1;
            Console.WriteLine("1~100까지 값을 입력하여 알아맞추세요!");

            while (true)
            {
                int i = int.Parse(Console.ReadLine());
                if (i > randNum)
                {
                    Console.WriteLine("DOWN 다시 입력하세요!");
                }
                else if (i < randNum)
                {
                    Console.WriteLine("UP 다시 입력하세요!");
                }
                else
                    break;
            }
            Console.WriteLine($"정답 {randNum}! 알아맞히셨습니다.");
        }
    }
}
