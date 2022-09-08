// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNatural(int n1)
{
    if (n1 == 1)       // Условие выхода из рекурсии
    {
        Console.Write($"{n1}"); // Печать последнего числа (Первого в стеке)
        return;
    }
    Console.Write($"{n1}, ");   // Вывод элементов стека

    if (n1 > 1)
        PrintNatural(n1 - 1);
    else if (n1 < 1)
        PrintNatural(n1 + 1);
}

PrintNatural(n);