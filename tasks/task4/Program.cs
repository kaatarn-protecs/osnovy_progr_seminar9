// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3 v 5)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int GetPow(int number, int p)
{
    if (p == 0)
        return 1;
    // if (p == 1) НЕОБЯЗАТЕЛЬНОЕ УСЛОВИЕ
    //     return number;
    
    return number * GetPow(number, p - 1);
}

int pow = GetPow(a, b);
Console.WriteLine($"Число {a} в степени {b} -> {pow}");