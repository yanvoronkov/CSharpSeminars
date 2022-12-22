// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
	Numb(number);
}
else
{
	System.Console.WriteLine("Введите целое положительное число");
}

void Numb(int n1)
{
	int counter = 1;
	while (counter <= n1)
	{
		Console.WriteLine($"{counter} -> {counter * counter}");
		counter++;
	}
}
