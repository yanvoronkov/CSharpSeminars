// Задача 25: Напишите цикл,
//  который принимает на вход два числа (A и B)
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ExponentNum(int num, int exp)
{
	int result = 1;
	for (int i = 0; i < exp; i++)
	{
		result = result * num;
		Console.WriteLine(result);
	}
	return result;
}

System.Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа:");
int b = Convert.ToInt32(Console.ReadLine());

int exponentNum = ExponentNum(a, b);
Console.WriteLine($"{a}, {b} -> {exponentNum}");