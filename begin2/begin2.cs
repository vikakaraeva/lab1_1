using System;

namespace begin2
{
    class begin2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            double A, S; // объявление переменных типа double
            Console.WriteLine("программа нахождения площади квадрата;"); //вывод на экран
            Console.Write("введите A="); //ввод данных
            A = Convert.ToDouble(Console.ReadLine());
            S = A * A; //cчитаем площадь
            Console.WriteLine("площадь=" + S); //вывод результата
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
