Console.Clear();

void Zadacha1()
{
    Console.WriteLine("Задайте значения N и M. Программа \nкоторая выведет все чётные натуральные числа \nв промежутке от M до N с помощью рекурсии");
    Console.Write("введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int Recurs(int m)
    {
        if (m <= n)
        {
            if (m % 2 == 1)
            { return Recurs(m + 1); }

            if (m % 2 == 0)
            {
                Console.WriteLine(m);
                return Recurs(m + 2);
            }

        }
        return m;
    }
    Recurs(m);
}

void Zadacha2()
{
    Console.WriteLine("программа, которая найдёт сумму натуральных \nэлементов  в промежутке от M до N с помощью рекурсии.");
    Console.Write("введите m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int summ = 0;
    int Recurs(int m, int n)
    {
        if (m <= n)
        {
            summ += m + Recurs(m + 1, n);
        }
        return summ;
    }
    Console.WriteLine(Recurs(m, n));
}

void Zadacha3()
{
Console.WriteLine("программа,найдёт наибольший общий делитель \n(НОД) этих чисел с помощью рекурсии.");
Console.Write("введите m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите n:");
int n = Convert.ToInt32(Console.ReadLine());
int Recurs(int m, int n)
{
    if (m != n)
    {
        if (m > n)
            return Recurs(m - n, n);

        else
            return Recurs(m, n - m);
    }
    else
        return m;
}
Console.WriteLine(Recurs(m, n));
}

Zadacha1();
Zadacha2();
Zadacha3();