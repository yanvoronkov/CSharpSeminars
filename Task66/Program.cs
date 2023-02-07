// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InsertDigit("Enter natural number m: ");
int n = InsertDigit("Enter natural number n: ");

int sumNumbers = SumNumbers(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sumNumbers}");

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text); //Если пользователь ввел некорректное значение вызываем повтороно метод.
	return result;
}

int SumNumbers(int numM, int numN)
{
	if (numM < numN) return numN + SumNumbers(numM, numN - 1);
	if (numM > numN) return numN + SumNumbers(numM, numN + 1);
	else return numM;
}