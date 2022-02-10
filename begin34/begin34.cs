using System;

namespace begin34
{
    class begin34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            Console.WriteLine("программа расчёта цены за килограмм");
            double candy_mass, iris_mass, candy_price, iris_price; // нам нужны неотрицательные числа, используем переменные типа double

            Console.Write("Введите массу шоколадных конфет: "); // ввод данных
            candy_mass = double.Parse(Console.ReadLine()); // преобразуем строковое представление числа в нужный тип
            Console.Write("Введите массу ирисок: ");
            iris_mass = double.Parse(Console.ReadLine());
            Console.Write("Введите цену шоколадных конфет за 1 кг: ");
            candy_price = double.Parse(Console.ReadLine());
            Console.Write("Введите цену ирисок за 1 кг: ");
            iris_price = double.Parse(Console.ReadLine());
            Console.WriteLine($"Килограмм шоколадных конфет стоит: {candy_price / candy_mass} руб., " +
                $"килограмм ирисок стоит: {iris_price / iris_mass} руб.," +
                $" в {(candy_price / candy_mass) / (iris_price / iris_mass)} раз(а) конфеты дороже ирисок");
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); // выходим из программы
        }
    }
}
