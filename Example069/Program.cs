// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();
Console.Write("Введите число А - основание степени: ");
int basis = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число В - показатель степени: ");
int indicator = Convert.ToInt32(Console.ReadLine());
if (indicator < 0) return;
int Exponentiation (int basis, int indicator)
{
    if(indicator == 0) return 1;
    return basis * Exponentiation(basis, indicator - 1);
}
Console.Write(basis + " в степени " + indicator + " равно " + Exponentiation(basis, indicator) + ".");