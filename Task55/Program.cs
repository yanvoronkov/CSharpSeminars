// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
			else Console.Write($"{matrix[i, j],5}  ");
		}
		Console.WriteLine("]");
	}
}

void ReplaceRowsColumns(int[,] matr)
{
	int temp = 0;
	for (int i = 1; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < i; j++)
		{
			temp = matr[i, j];
			matr[i, j] = matr[j, i];
			matr[j, i] = temp;
		}
	}
}

int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();

if (array2D.GetLength(0) == array2D.GetLength(1))
{
	ReplaceRowsColumns(array2D);
	PrintMatrix(array2D);
}
else Console.WriteLine("невозможно");