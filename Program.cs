using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;
using ClassLibrary1;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Global myClass = new Global();

            // Используем метод PrintMessage
            myClass.PrintMessage("Добро пожаловать в консольное приложение!");

            // Используем метод AddAndPrint
            myClass.AddAndPrint(13, 10);

            // Используем метод GetGreeting
            string greeting = myClass.GetGreeting("Виктория");
            Console.WriteLine(greeting);

            // Используем метод GetSquare
            int number = 8;
            int square = myClass.GetSquare(number);
            Console.WriteLine($"Квадрат числа {number} равен {square}");

            Console.WriteLine($"Через 10 лет тебе будет - {myClass.AgePlusTen(18)}");
            Console.ReadLine();

            

        }
    }
}

