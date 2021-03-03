using System;
using System.Linq;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите фигуру: 1- прямоугольник, 2 - круг, 3 - треугольник");
                var selectedIndex = int.Parse(Console.ReadLine());

                IFigure figure;
                switch (selectedIndex)
                {
                    case 1:
                        figure = new Rectangle();
                        break;
                    case 2:
                        figure = new Circle();
                        break;
                    case 3:
                        figure = new Triangle();
                        break;

                    default:
                        Console.WriteLine("Такой фигуры нет");
                        return;
                }
                
                //Вот отсюда мы работаем только с выбранной фигурой
                Console.WriteLine(figure.EnterParamsTitle);
                var argsStrings = Console.ReadLine().Split(',');

                float[] floatArray = new float[argsStrings.Length];
                for (var i = 0; i < argsStrings.Length; i++)
                {
                    floatArray[i] = float.Parse(argsStrings[i]);
                }
                figure.Init(floatArray);
                //figure.Init(argsStrings.Select(x => float.Parse(x)).ToArray());

                Console.WriteLine($"{figure.OutputTitle} {figure.CalcArea()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Во время работы произошла ошибка: {e}");
            }
        }
    }
}
