﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());   
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3) Console.WriteLine($"max = {num1}");
else if (num2 > num1 && num2 > num3) Console.WriteLine($"max = {num2}");
else Console.WriteLine($"max = {num3}");