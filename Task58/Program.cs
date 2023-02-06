// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

//метод создания двумерного массива из псевдочисел

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

//метод вывода двумерного массива в консоль
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
			else Console.Write($"{matrix[i, j],3} ");
		}
		Console.WriteLine("]");
	}
}

//метод перемножения двух матриц
int[,] ProductOfTwoMatrix(int[,] matrixA, int[,] matrixB)
{
	int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			for (int n = 0; n < matrixA.GetLength(1); n++)
			{
				resultMatrix[i, j] += matrixA[i, n] * matrixB[n, j];
			}
		}
	}
	return resultMatrix;
}

int[,] array2DA = CreateMatrixRndInt(3, 2, 1, 3);
PrintMatrix(array2DA);
Console.WriteLine();

int[,] array2DB = CreateMatrixRndInt(2, 2, 1, 3);
PrintMatrix(array2DB);
Console.WriteLine();

//проверка возможности перемножения двух матриц
if (array2DA.GetLength(1) == array2DB.GetLength(0))
{
	int[,] array2DResult = ProductOfTwoMatrix(array2DA, array2DB);
	PrintMatrix(array2DResult);
}
else
{
	Console.WriteLine("Перемножение массивов невозможно!");
}

// using System;

// namespace ArrayProduct
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			int[,] array1 = new int[,] { { 1, 2 }, { 3, 4 } };
// 			int[,] array2 = new int[,] { { 2, 0 }, { 1, 2 } };

// 			int[,] product = MultiplyArrays(array1, array2);

// 			Console.WriteLine("Product of the arrays:");
// 			for (int i = 0; i < product.GetLength(0); i++)
// 			{
// 				for (int j = 0; j < product.GetLength(1); j++)
// 				{
// 					Console.Write(product[i, j] + " ");
// 				}
// 				Console.WriteLine();
// 			}
// 		}

// 		static int[,] MultiplyArrays(int[,] a, int[,] b)
// 		{
// 			int rows = a.GetLength(0);
// 			int columns = b.GetLength(1);
// 			int common = a.GetLength(1);

// 			int[,] result = new int[rows, columns];

// 			for (int i = 0; i < rows; i++)
// 			{
// 				for (int j = 0; j < columns; j++)
// 				{
// 					for (int k = 0; k < common; k++)
// 					{
// 						result[i, j] += a[i, k] * b[k, j];
// 					}
// 				}
// 			}

// 			return result;
// 		}
// 	}
// }
