// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] arr1 = CreateArrayRndInt(7, 1, 9);
int[] arr2 = CopyArray(arr1);
PrintArray(arr1);
PrintArray(arr2);

// Создание рандомного массива int
int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}

// Печать массива int
void PrintArray(int[] array)
{
	System.Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) System.Console.Write(array[i] + ",");
		else System.Console.Write(array[i]);
	}
	System.Console.WriteLine("]");
}

// Копия массива int
int[] CopyArray(int[] input)
{
	int[] result = new int[input.Length];
	for (int i = 0; i < input.Length; i++)
	{
		result[i] = input[i];
	}
	return result;
}