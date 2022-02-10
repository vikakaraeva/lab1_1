using System;

namespace boolean16
{
    class boolean16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("программа Караевой Вики 2-1 ИС");
            //Дано целое положительное число. Проверить истинность высказывания: «Данное число является четным двузначным».
           
            Console.WriteLine("программа проверки истинности высказывания:");
            Console.Write("введите число:");  //ввод данных
            int x = Convert.ToInt32(Console.ReadLine());
            if ((x % 2) == 0) //проверка условия
            {
                if ((x / 100) == 0)
                {
                    Console.WriteLine("число целое и двузначное.");
                }
                else
                {
                    Console.WriteLine("число не является двузначным.");
                }
            }
            else
            {
                Console.WriteLine("число не является четным.");
            }
            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
