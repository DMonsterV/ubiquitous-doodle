while (true)
{
    Console.WriteLine("Выберите операцию: ");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычетание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение числа в степень N");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Найти факториал числа");
    Console.WriteLine("9. Выход");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                double sum = num1 + num2;
                Console.WriteLine($"Результат: {sum}");
                break;

            case 2:
                Console.Write("Введите первое число: ");
                double minuend = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double subtrahend = double.Parse(Console.ReadLine());
                double difference = minuend - subtrahend;
                Console.WriteLine($"Результат: {difference}");
                break;

            case 3:
                Console.Write("Введите первое число: ");
                double factor1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double factor2 = double.Parse(Console.ReadLine());
                double product = factor1 * factor2;
                Console.WriteLine($"Результат: {product}");
                break;

            case 4:
                Console.Write("Введите первое число: ");
                double dividend = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double divisor = double.Parse(Console.ReadLine());
                if (divisor != 0)
                {
                    double quotient = dividend / divisor;
                    Console.WriteLine($"Результат: {quotient}");
                }
                else
                {
                    Console.WriteLine("Деление на ноль невозможно.");
                }
                break;

            case 5:
                Console.Write("Введите число: ");
                double baseNumber = double.Parse(Console.ReadLine());
                Console.Write("Введите степень: ");
                int exponent = int.Parse(Console.ReadLine());
                double result = Math.Pow(baseNumber, exponent);
                Console.WriteLine($"Результат: {result}");
                break;

            case 6:
                Console.Write("Введите число: ");
                double cor = double.Parse(Console.ReadLine());
                if (cor >= 0)
                {
                    double corz = Math.Sqrt(cor);
                    Console.WriteLine($"Результат: {corz}");
                }
                else
                {
                    Console.WriteLine("Квадратный корень из отрицательного числа не существует.");
                }
                break;

            case 7:
                Console.Write("Введите число: ");
                double percentNumber = double.Parse(Console.ReadLine());
                double onePercent = percentNumber / 100;
                Console.WriteLine($"1% от числа {percentNumber} равно {onePercent}");
                break;

            case 8:
                Console.Write("Введите число: ");
                int factorialNumber = int.Parse(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= factorialNumber; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Факториал числа {factorialNumber} равен {factorial}");
                break;

            case 9:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Неверная операция.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Ты дурак? Введите число.");
    }
}