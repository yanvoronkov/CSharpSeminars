// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void Random(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = new Random().Next(0, 2);
	}
}
Random(array);

void PrintArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.WriteLine(arr[i]);
	}
}
PrintArray(array);
