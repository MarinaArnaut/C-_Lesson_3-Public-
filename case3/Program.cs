// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;

Console.WriteLine($"Таблица кубов числа {N}, от 1 до {N} ");
while (i <= N)
{
    double result = Math.Pow(i, 3);
    Console.Write(result + " ");
    i++;
}
