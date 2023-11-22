using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11_Практика_Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Возраст");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
            Console.ReadKey();

        }
    }
}