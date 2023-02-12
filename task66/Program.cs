// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromMToN(int m, int n)
{
    int result = 0;
    if (n >= m) return result = n + SumFromMToN(m, n - 1);
    else return result;
}
Console.Write("Введите первое число: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (m < n) Console.Write($"M = {m}; N = {n} -> {SumFromMToN(m, n)}");
else Console.Write($"M = {m}; N = {n} -> {SumFromMToN(n, m)}");