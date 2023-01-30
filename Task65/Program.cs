﻿// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
	return result;
}

void IntegerNumbers(int n, int m)
{
	if (n == m)
	{
		Console.Write($"{n} ");
		return;
	}
	if (n > m)
		IntegerNumbers(n - 1, m);
	else
		IntegerNumbers(n + 1, m);
	Console.Write($"{n} ");
}

int mUser = InsertDigit("Введите число M:");
int nUser = InsertDigit("Введите число N:");

IntegerNumbers(nUser, mUser);

Console.WriteLine("Please, enter number N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter number M");
int numberM = Convert.ToInt32(Console.ReadLine());
while (numberN == numberM)
{
	Console.WriteLine("Your numbers are equal! Please, reenter neumber M");
	numberM = Convert.ToInt32(Console.ReadLine());
}


// int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
// {
//     int result; bool parse;
//     Console.WriteLine(text);
//     parse = Int32.TryParse(Console.ReadLine(), out result);
//     if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
//     return result;
// }


// void IntegerNumbers(int n, int m, int s)
// {
//     if (n == m)
//     {
//         Console.Write($"{n} ");
//         return;
//     }
//     IntegerNumbers(n + s, m, s);

//     Console.Write($"{n} ");
// }

// int mUser = InsertDigit("Введите число N:");
// int nUser = InsertDigit("Введите число M:");

// int sign=Math.Sign((mUser-nUser));
// Console.WriteLine($"sign = {sign}");

// IntegerNumbers(nUser, mUser, sign);