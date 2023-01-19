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