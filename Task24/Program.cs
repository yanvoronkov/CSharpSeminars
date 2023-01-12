// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А)
//2. выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
//преобразование в int строки, только для строк
int number = int.Parse(Console.ReadLine());
//преобразование в int универсальное
// int number1 = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);

int SumNumbers(int num) //num = number
{
	int sum = 0;
	for (int i = 1; i <= num; i++)
	{
		sum = sum + i;
	}
	return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");