// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
	int tempSum = 0;
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			for (int n = 0; n < matrixA.GetLength(1); n++)
			{
				tempSum = tempSum + matrixA[i, n] * matrixB[n, j];
			}
			resultMatrix[i, j] = tempSum;
			tempSum = 0;
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