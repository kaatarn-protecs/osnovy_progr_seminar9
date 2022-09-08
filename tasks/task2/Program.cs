

Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNatural(int m1, int n1)
{
    if (m1 == n1)       // Условие выхода из рекурсии
    {
        Console.Write($"{m1}"); // Печать последнего числа (Первого в стеке)
        return;
    }
    Console.Write($"{m1}, ");   // Вывод элементов стека

    if (m1 > n1)
        PrintNatural(m1 - 1, n1);
    else if (m1 < n1)
        PrintNatural(m1 + 1, n1);
}

PrintNatural(m, n);