using System;

namespace boolean33
{
    class boolean33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            // Даны целые числа a, b, c. Проверить истинность высказывания: «Существует треугольник со сторонами a, b, c».
            Console.WriteLine("программа проверки  истинности высказывания:");

            byte a, b, c; // объявление переменных типа byte
            Console.Write("введите a:");  //ввод данных
            a = byte.Parse(Console.ReadLine()); //преобразуем строковое представление числа в нужный тип
            Console.Write("введите b:");
            b = byte.Parse(Console.ReadLine());
            Console.Write("введите c:");
            c = byte.Parse(Console.ReadLine());
            if (a <= (b + c) && b <= (a + c) && c <= (a + b)) //проверка условия
                Console.WriteLine("Треугольник существует");
            else
                Console.WriteLine("Треугольника не существует");
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
