// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // 1, 7 -> такого элемента в массиве нет

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

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
	return result;
}

int[,] array2D = CreateMatrixRndInt(4, 5, 10, 99);
PrintMatrix(array2D);
int rowIndex = InsertDigit("Введите индекс строки массива: ");
if (rowIndex < 0)
{
	rowIndex = InsertDigit("Введите целое положительное число: ");
}

int сolumnIndex = InsertDigit("Введите индекс столбца массива: ");
if (сolumnIndex < 0)
{
	сolumnIndex = InsertDigit("Введите целое положительное число: ");
}

if (rowIndex <= array2D.GetLength(0) && сolumnIndex <= array2D.GetLength(1))
{
	int arrayItem = array2D[rowIndex, сolumnIndex];
	Console.WriteLine($"Искомое значение c индексами {rowIndex}, {сolumnIndex} -> {arrayItem}");
}
else
{
	Console.WriteLine($"{rowIndex}, {сolumnIndex} - > такого элемента в массиве нет");
}
