// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

(int row, int column, int minValue) IndexMinValueMatrix(int[,] matr)
{
	int minValueRow = 0;
	int minValueColumn = 0;
	int minValue = matr[0, 0];
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			if (minValue > matr[i, j])
			{
				minValue = matr[i, j];
				minValueRow = i;
				minValueColumn = j;
			}
		}
	}
	return (minValueRow, minValueColumn, minValue);
}

int[,] RemoveRowColumnCross(int[,] matrix, int iMin, int jMin)
{
	int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
	int m = 0;
	int n = 0;
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		if (m == iMin) m++;
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			if (n == jMin) n++;
			resultMatrix[i, j] = matrix[m, n];
			n++;
		}
		m++;
		n = 0;
	}
	return resultMatrix;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 5, 9);
PrintMatrix(array2D);
var indexMinValue = IndexMinValueMatrix(array2D);
Console.WriteLine(indexMinValue.row + "\n" + indexMinValue.column + "\n" + indexMinValue.minValue);
int[,] resMatrix = RemoveRowColumnCross(array2D, indexMinValue.row, indexMinValue.column);
Console.WriteLine();
PrintMatrix(resMatrix);
