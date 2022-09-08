// Задача 67:
// Напишите программу, которая будет принимать 
//на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitSum(int number)
{

    if (number < 10)
        return number;

    return number % 10 + DigitSum(number / 10);
}

int sum = DigitSum(num);
Console.WriteLine($"Сумма цифр числа {num} -> {sum}");
