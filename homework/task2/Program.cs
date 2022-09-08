// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int DigitSumNaturals(int num1, int num2)
{
    int sum = 0;
    // PrintNatural(m1 - 1, n1);
    if (num1 == num2)
    {
        return num1;
    }

    if (num1 < num2)
    {
        return sum = num1 + DigitSumNaturals(num1 + 1, num2);
    }

    if (num1 > num2)
    {
        return sum = num1 + DigitSumNaturals(num1 - 1, num2);
    }
    return sum;
}

int sum = DigitSumNaturals(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");