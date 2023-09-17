// See https://aka.ms/new-console-template for more information
using static System.Math;
int sifra;
int a;
int b;

do
{
    Console.WriteLine("Выберите операцию");
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить превое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    sifra = Convert.ToInt32(Console.ReadLine());
    if (sifra == 1)
    {
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);
    }
    else if (sifra == 2)
    {
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a - b);
    }
    else if (sifra == 3)
    {
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a * b);
    }
    else if (sifra == 4)
    {
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a / b);
    }
    else if (sifra == 5)
    {
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Math.Pow(a, b);
        Console.WriteLine(Math.Pow(a, b));
    }
    else if (sifra == 6)
    {
        Console.WriteLine("введите число");
        double d = Convert.ToInt32(Console.ReadLine());
        d = Sqrt(d);
        Console.WriteLine(d); 
    }
    else if (sifra == 7)
    {
        Console.WriteLine("введите число");
        float n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n / 100);
    }
    else if (sifra == 8)
    {
        Console.WriteLine("введите число");
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i=1; i <= num; i++)
      {
            factorial *= i;
      }
        Console.WriteLine(factorial);
    }
} while (sifra != 9);
