using System;

namespace MyLabWork6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.WriteLine("a="); //просим пользователя ввести число
            a = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            Console.WriteLine("b="); //просим пользователя ввести число
            b = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            Console.WriteLine("c="); //просим пользователя ввести число
            c = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            sum = a + b + c; //присваивание переменной значения по формуле
            Console.WriteLine($"{a}+{b}+{c}={sum}"); //вывод на экран суммы чисел
        }
    }
}
