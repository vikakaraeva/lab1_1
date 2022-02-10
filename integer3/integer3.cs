using System;

namespace integer3
{
    class integer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            //Дан размер файла в байтах. Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл

            Console.WriteLine("программа нахождения полных килобайтов:");
            Console.Write("введите размер файла в байтах A=");//ввод данных
            double A; // килобайты не могут быть отрицательными, используем тип переменных double
            A = double.Parse(Console.ReadLine()); //преобразуем число, введённое с клавиатуры в 32-битное целое число
            Console.WriteLine($"Кол-во полных килобайт: {Math.Round(A / 1024)}"); // выводим результат
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey();//выходим из программы
        }
    }
}
