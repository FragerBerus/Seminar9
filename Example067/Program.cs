// Задача 67:
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigits = 0;
int SumDigit (int number, int sumDigits)
{
    if (number / 10 == 0) return number;
    return sumDigits + number % 10 + SumDigit(number / 10, sumDigits);
}
Console.WriteLine("Сумма цифр числа " + number + " равна " + SumDigit(number, sumDigits) + ".");