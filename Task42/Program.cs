// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

string DecToBin(int num)
{
	string result = string.Empty;
	while (num > 0)
	{
		result = num % 2 + result;
		num /= 2;
	}
	return result;
}

int number = InsertDigit("Введите число: ");
Console.WriteLine(DecToBin(number));

// Решение 2 через int

// int ParseIn2(int num)
// {
//     if (num == 0) return 0;
//     int result = num % 2;
//     num /= 2;
//     result += ParseIn2(num) * 10;
//     return result;
// }
// //Console.WriteLine(ParseIn2(Convert.ToInt32(Console.ReadLine())));
// Console.WriteLine("Введите чило");
// var num =Console.ReadLine();
// Console.WriteLine(ParseIn2(Convert.ToInt32(num)));