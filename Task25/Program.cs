// Задача 25: Напишите цикл,
//1. который принимает на вход два числа (A и B)
//2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}
int ExponentNum(int num, int exp) //метод вычисления степени числа путем перемножения числа на себя в цикле
{
	int result = 1;
	for (int i = 0; i < exp; i++)
	{
		result = result * num;
		Console.WriteLine(result);
	}
	return result;
}

int numA = InsertDigit("Введите число A:");
int numB = InsertDigit("Введите число B:");
int exponentNum = ExponentNum(numA, numB);

Console.WriteLine($"{numA}, {numB} -> {exponentNum}");