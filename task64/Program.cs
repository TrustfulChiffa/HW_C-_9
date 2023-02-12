﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersFromNTo1(int n)
{
    if (n >= 1) return NumbersFromNTo1(n - 1) + $" {n}";
    else return string.Empty;
}

Console.Clear();

Console.Write("Введите натуральное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.WriteLine($" N = {number} -> {NumbersFromNTo1(number)}");
}

else Console.WriteLine("Вы ввели не натуральное число, повторите попытку.");