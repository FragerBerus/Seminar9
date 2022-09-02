// Задача 63:
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
Console.Write("Введите значение, до которого нужно вывести числа: ");
int number = int.Parse(Console.ReadLine());
// Переделывает строку в число. Переделывает только в целое число,
// Convert. со монгоими типами. При этом, если в int.Parse будет
// ссылка на "null" метод выдаст ошибку, метод Convert. выдаст
// исключение
string PrintNumbers(int start, int end)
// Метод с начальным значением start и конечным end
{
    // Следующий случай - базовыЙ, который возвращает число
    // start, когда оно достигнет end, в строковом виде
    if (start == end) return start.ToString();  
    // Следующий - рекурсивный случай
    return(start + ", " + PrintNumbers(start + 1, end));    
}
Console.WriteLine(PrintNumbers(1, number));