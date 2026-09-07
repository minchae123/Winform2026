using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 2; i <= 9; i++)
            //{
            //    Console.WriteLine(i + "단 출력");
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine(i + " X " + j + " = " + i * j);
            //    }
            //    Console.WriteLine();
            //}

            Console.Write("inch 단위입력 : ");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는" + (inch * 2.54) + "cm입니다.");

            Console.Write("kg 단위입력 : ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(kg + "kg는" + (kg * 2.20462262) + "pound입니다.");

            Console.Write("원의 반지름 입력 : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레 : " + (2 * 3.14 * radius));
            Console.WriteLine("원의 넓이 : " + (radius * radius * 3.14));
        }
    }
}
