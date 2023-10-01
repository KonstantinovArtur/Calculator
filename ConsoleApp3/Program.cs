using static System.Math;
int sifra;
int a;
int b;

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
while (sifra != 9)
{
    if (sifra > 9)
    {
        Console.WriteLine("Недопустимое значение");
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    }
    if (sifra < 1)
    {
        Console.WriteLine("Недопустимое значение");
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    }
    do
    {
        if (sifra != 1)
        {
            break;
        }
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 1);
    do
    {
        if (sifra != 2)
        {
            break;
        }
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a - b);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 2);
    do
    {
        if (sifra != 3)
        {
            break;
        }
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a * b);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 3);
    do
    {
        if (sifra != 4)
        {
            break;
        }
        Console.WriteLine("введите 1 число");
        float c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        float d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(c / d);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 4);
    do
    {
        if (sifra != 5)
        {
            break;
        }
        Console.WriteLine("введите 1 число");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите 2 число");
        b = Convert.ToInt32(Console.ReadLine());
        Math.Pow(a, b);
        Console.WriteLine(Math.Pow(a, b));
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 5);
    do
    {
        if (sifra != 6)
        {
            break;
        }
        Console.WriteLine("введите число");
        double d = Convert.ToInt32(Console.ReadLine());
        d = Sqrt(d);
        Console.WriteLine(d);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 6);
    do
    {
        if (sifra != 7)
        {
            break;
        }
        Console.WriteLine("введите число");
        float n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n / 100);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 7);
    do
    {
        if (sifra != 8)
        {
            break;
        }
        Console.WriteLine("введите число");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
        Console.WriteLine("Выберите операцию ещё раз");
        sifra = Convert.ToInt32(Console.ReadLine());
    } while (sifra == 8);
}