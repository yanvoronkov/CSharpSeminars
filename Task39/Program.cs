// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6] 

int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
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

// Array.Reverse(array);

void ReverseArray(int[] arr)
{
	for (int i = 0; i < arr.Length / 2; i++)
	{
		int temp = arr[i];
		arr[i] = arr[arr.Length - 1 - i];
		arr[arr.Length - 1 - i] = temp;
	}
}

int[] array = CreateArray(5, 1, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);