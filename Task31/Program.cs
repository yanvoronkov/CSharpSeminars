// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9].
// 3. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] arr = CreateArray(12, -9, 9);
PrintArray(arr);

int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
		Console.WriteLine(array[i]);
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.WriteLine(array[i] + "]");
	}
}

int GetSumPositiveElem(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) sum += array[i];
	}
	return sum;
}

int GetSumNegativeElem(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < 0) sum += array[i];
	}
	return sum;
}

int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");