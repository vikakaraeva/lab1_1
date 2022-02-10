using System;

namespace boolean7
{
    class boolean7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            //Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C». 

            Console.WriteLine("программа проверка истинности высказывания:");
            byte a, b, c; // объявление переменных типа byte
            Console.Write("введите a:"); //ввод данных
            a = byte.Parse(Console.ReadLine()); //преобразуем строковое представление числа в нужный тип
            Console.Write("введите b:");
            b = byte.Parse(Console.ReadLine());
            Console.Write("введите c:");
            c = byte.Parse(Console.ReadLine());
            if (a < b && b < c || a > b && b > c) //проверка на истинность
            {
                Console.WriteLine("Число B стоит между числами A и C");
            }
            else if (a < b && b > c || a > b && b < c) //проверка на ложь
            {
                Console.WriteLine("Число B не стоит между числами A и C");
            }
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
