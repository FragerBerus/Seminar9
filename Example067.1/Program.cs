// Задача 67:
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.Write("Введенное число не соответствует условию задачи.");
    return;
}
int SumDigit(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigit(number / 10);
}
Console.WriteLine("Сумма цифр числа " + number + " равна " + SumDigit(number) + ".");
