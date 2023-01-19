// Задача 27: Напишите программу, которая:
// 1. принимает на вход число
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int InsertNumber(string text) //Метод пользовательского ввода числа
// {
// 	System.Console.WriteLine(text);
// 	int result = Convert.ToInt32(Console.ReadLine());
// 	return result;
// }

// int SumDigits(int num)
// {}
int num = 452;
int sum = 0;
while (num > 0)
{
	sum = sum + num % 10;
	num = num / 10;
}

Console.WriteLine(sum);
