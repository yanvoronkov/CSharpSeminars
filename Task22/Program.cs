// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Numb(int n1)
{
	int counter = 1;
	while (counter <= n1)
	{
		Console.WriteLine($"{counter,3} {counter * counter,3}");
		counter++;
	}
}

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
	System.Console.WriteLine("Введите положительное, целое число");
	number = Convert.ToInt32(Console.ReadLine());
}

Numb(number);