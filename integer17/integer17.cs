﻿using System;

namespace integer17
{
    class integer17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            // Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
            // найти цифру, соответствующую разряду сотен в записи этого числа.

            Console.WriteLine("программа поиска цифры, соответствующей разряду сотен в записи числа");
            int number;
            Console.Write("Введите число:"); // ввод данных
            number = int.Parse(Console.ReadLine()); // преобразуем строковое представление числа в нужный тип
            if (number > 999) // проверка на истинность: число больше 999
                Console.WriteLine($"Цифра, соответствующая разряду сотен в записи числа: {(number % 1000) / 100}"); // если проверка истинна, то пользователю показывается число
            else
                Console.WriteLine("Введено число меньше 999. Введите число больше 999"); // если проверка - ложь, то программа выдаст ошибку
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
