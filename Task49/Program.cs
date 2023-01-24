﻿// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// Создание рандомного двумерного массива int
int[,] CreatMatrixNM(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = i + j;
		}
	}
	return matrix;
}

// Печать массива int
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + ",");
			else Console.Write(matrix[i, j]);
		}
		Console.WriteLine("]");
	}
}

void MatrixChanged(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i += 2)
	{
		for (int j = 0; j < matrix.GetLength(1); j += 2)
		{
			matrix[i, j] = matrix[i, j] * matrix[i, j];
		}
	}
}

int[,] arr1 = CreatMatrixNM(3, 4, 1, 10);
PrintMatrix(arr1);
System.Console.WriteLine();
MatrixChanged(arr1);
PrintMatrix(arr1);
