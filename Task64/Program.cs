// Задача 64: Задайте значение N. Напишите программу, которая
//выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
	return result;
}

string OutputDigits(int n)
{
	if (n < 0)
	{
		if (n == 0) return String.Empty;
		else return $"{n}, " + OutputDigits(n + 1);
	}
	else
		if (n == 0) return String.Empty;
	else return $"{n}, " + OutputDigits(n - 1);
}


int num = InsertDigit("Введите число");
Console.Write($"N = {num} -> ");
Console.WriteLine(OutputDigits(num));

