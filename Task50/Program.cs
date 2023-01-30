// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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

//метод пользовательского ввода числа
int InsertDigit(string text)
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

int[,] array2D = CreateMatrixRndInt(4, 5, 10, 99);
PrintMatrix(array2D);
int rowIndex = InsertDigit("Введите индекс строки массива: ");
int сolumnIndex = InsertDigit("Введите индекс столбца массива: ");

if (rowIndex <= array2D.GetLength(0) && сolumnIndex <= array2D.GetLength(1))
{
	int arrayItem = array2D[rowIndex, сolumnIndex];
	Console.WriteLine($"Искомое значение -> {arrayItem}");
}
else
{
	Console.WriteLine($"{rowIndex}, {сolumnIndex} - > такого элемента в массиве нет");
}
