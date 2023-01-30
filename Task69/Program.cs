﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Enter natural number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter natural number: ");
int b = Convert.ToInt32(Console.ReadLine());

int pow = PowerNumbers(a, b);
System.Console.WriteLine($"Power = {pow}");

int PowerNumbers(int num, int power)
{
	if (power == 0) return 1;
	return PowerNumbers(num, power - 1) * num;
}