using System;

namespace begin9
{
    class begin9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            Console.WriteLine("программа вычисление среднего геометрического значения двух чисел:");
            double A, B; //объявление переменных типа double
            Console.Write("введите A="); // ввод данных
            A = double.Parse(Console.ReadLine()); //преобразуем строковое представление числа в нужный тип
            Console.Write("введите B=");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее геометрическое двух чисел: {Math.Sqrt(A * B)}"); //вывод результата
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); // выходим из программы
        }
    }
}
