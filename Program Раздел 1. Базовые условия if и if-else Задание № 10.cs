using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ваш возраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 18)
                    Console.WriteLine("Доступ разрешен");
                else
                    Console.WriteLine("Доступ запрещен");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}