// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(6, 4, 1, 9);
PrintMatrix(array2D);

Console.WriteLine("---------------------------------");
int[,] array2DSumROwElements = CreateMatrixSumRowElements(array2D);

PrintMatrixSumRowElements(array2DSumROwElements);
int numberMinSumRowElements = NumberMinSumRowElements(array2DSumROwElements);

Console.WriteLine("---------------------------------");
Console.WriteLine($"Строка с наименьшей суммой элементов: {numberMinSumRowElements} строка ");

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

void PrintMatrixSumRowElements(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("Сумма элементов строки ");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} равна ");
			else Console.Write($"{matrix[i, j],1} ");
		}
		Console.WriteLine();
	}
}

//метод расчета суммы элементов строк двумерного массива
int[,] CreateMatrixSumRowElements(int[,] matrix)
{
	int[,] matrixSumRowElements = new int[matrix.GetLength(0), 2];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sumRowElements = 0;
		for (int j = 0; j < matrix.GetLength(1); j++)
		{

			sumRowElements = sumRowElements + matrix[i, j];
		}
		matrixSumRowElements[i, 1] = sumRowElements;
		matrixSumRowElements[i, 0] = i + 1;
	}
	return matrixSumRowElements;
}

int NumberMinSumRowElements(int[,] matrix)
{
	int minSumRowElements = matrix[0, 1];
	int numberMinSumRowElements = 1;
	for (int i = 1; i < matrix.GetLength(0); i++)
	{

		if (matrix[i, 1] < minSumRowElements)
		{
			numberMinSumRowElements = i + 1;
			minSumRowElements = matrix[i, 1];
		}
	}
	return numberMinSumRowElements;
}