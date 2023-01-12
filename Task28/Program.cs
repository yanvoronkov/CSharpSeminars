// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Multiply(int num)
{
	int result = 1;
	for (int i = 1; i <= num; i++)
	{
		result = result * i;
	}
	return result;
}

int InsertDigit(string text) //Метод пользовательского ввода
{
	Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

int number = InsertDigit("Введите число: ");
int mult = Multiply(number);
System.Console.WriteLine(mult);