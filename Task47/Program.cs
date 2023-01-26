// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] matr = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(matr);

//метод создания двумерного массива из псевдочисел
double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	double[,] matrix = new double[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max + 1) + Math.Round(rnd.NextDouble(), 2, MidpointRounding.ToZero);
		}
	}
	return matrix;
}

//метод вывода двумерного массива в консоль
void PrintMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],7},");
			else Console.Write($"{matrix[i, j],7}  ");
		}
		Console.WriteLine("]");
	}
}