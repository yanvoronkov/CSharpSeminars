// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
			else Console.Write($"{matrix[i, j],2}");
		}
		Console.WriteLine(" ]");
	}
}

double[] AverageOfColumnsElements(int[,] matr)
{
	double[] averageArray = new double[matr.GetLength(1)];
	double sumElementsColumns = 0;
	for (int i = 0; i < matr.GetLength(1); i++)
	{
		for (int j = 0; j < matr.GetLength(0); j++)
		{
			sumElementsColumns = sumElementsColumns + matr[j, i];
		}
		averageArray[i] = Math.Round(sumElementsColumns / matr.GetLength(0), 1, MidpointRounding.AwayFromZero);
		sumElementsColumns = 0;
	}
	return averageArray;
}

//метод вывода массива в консоль
void PrintArray(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + "; ");
		else Console.Write(array[i] + ".");
	}
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
double[] average = AverageOfColumnsElements(array2D);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(average);