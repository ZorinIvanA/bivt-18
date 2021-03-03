using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите фигуру: 1- прямоугольник, 2 - круг");
                var selectedIndex = int.Parse(Console.ReadLine());

                if (selectedIndex == 1)
                {
                    Console.WriteLine("Введите A и B");
                    var a = float.Parse(Console.ReadLine());
                    var b = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь прямоугольника: {a * b}");
                }

                if (selectedIndex == 2)
                {
                    Console.WriteLine("Введите R");
                    var r = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь круга: {Math.PI * Math.Pow(r, 2)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Во время работы произошла ошибка: {e}");
            }
        }
    }
}
