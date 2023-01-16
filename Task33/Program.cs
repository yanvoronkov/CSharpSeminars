﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool FindArrElem(int[] array, int num)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == num) return true;
	}
	return false;
}

int[] arr = CreateArray(10, 1, 10);
PrintArray(arr);
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
FindArrElem(arr, num);
if (FindArrElem(arr, num)) Console.WriteLine($"Да");
else Console.WriteLine($"Нет");