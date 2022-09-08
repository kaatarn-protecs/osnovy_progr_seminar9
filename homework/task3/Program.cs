// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите М ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m1, int n1)
{
    if (m1 == 0) return n1 + 1;
    if (n1 == 0)
        return AkkermanFunc(m1 - 1, 1);
    return AkkermanFunc(m1 - 1, AkkermanFunc(m1, n1 - 1));
}

int res = AkkermanFunc(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {res}");