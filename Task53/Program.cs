// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
			else Console.Write($"{matrix[i, j],5}  ");
		}
		Console.WriteLine("]");
	}
}

void ReplaceFirstAndLastRow(int[,] matr)
{
	int firstRow = 0;
	int lastRow = matr.GetLength(0) - 1;
	for (int i = 0; i < matr.GetLength(1); i++)
	{
		int temp = matr[firstRow, i];
		matr[firstRow, i] = matr[lastRow, i];
		matr[lastRow, i] = temp;
	}
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();
ReplaceFirstAndLastRow(array2D);
PrintMatrix(array2D);