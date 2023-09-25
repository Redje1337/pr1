using System;

class Calculator
{
    static void Main()
    {
        int choice = 0;
        double num1, num2;

        while (choice != 9)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выйти");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine("Введите число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    int exponent = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + Math.Pow(num1, exponent));
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + Math.Sqrt(num1));
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (num1 / 100));
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    num1 = double.Parse(Console.ReadLine());
                    double factorial = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("Результат: " + factorial);
                    break;
                case 9:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор операции.");
                    break;
            }
        }
    }
}