﻿// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (count < num)
{
	if (count % 2 == 0)
	{
		Console.Write($" {count}");
	}
	count++;
}