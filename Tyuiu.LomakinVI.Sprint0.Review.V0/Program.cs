using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint0.Review.V0.Lib;


namespace Tyuiu.LomakinVI.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число:  ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int z = int.Parse(Console.ReadLine());

            int result = (int)DataService.Calc(x, y, z);

            Console.WriteLine();

            Console.Write($"Ответ: {result}");

            Console.ReadKey();
        }
    }
}
