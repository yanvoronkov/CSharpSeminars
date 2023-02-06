// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter natural number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter natural number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sumNumbers}");

int SumNumbers(int numM, int numN)
{
	if (numM < numN) return numN + SumNumbers(numM, numN - 1);
	if (numM > numN) return numN + SumNumbers(numM, numN + 1);
	else return numM;
}