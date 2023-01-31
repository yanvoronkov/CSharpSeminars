// Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[,] array2DSort = SortDescendingRowElements(array2D);
PrintMatrix(array2DSort);

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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2},");
			else Console.Write($"{matrix[i, j],2} ");
		}
		Console.WriteLine("]");
	}
}

int[,] SortDescendingRowElements(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 1; j < matrix.GetLength(1); j++)
		{
			for (int n = 0; n < matrix.GetLength(1) - 1; n++)
			{
				int temp = 0;
				if (matrix[i, n + 1] > matrix[i, n])
				{
					temp = matrix[i, n + 1];
					matrix[i, n + 1] = matrix[i, n];
					matrix[i, n] = temp;
				}
			}
		}
	}
	return matrix;
}