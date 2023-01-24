// Задача 51 Вывести сумму элементов диагонали массива


// Создание рандомного двумерного массива int
int[,] CreatMatrixNM(int rows, int columns, int min, int max)
{
	Random rnd = new Random();
	int[,] matrix = new int[rows, columns];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max);
		}
	}
	return matrix;
}

// Печать массива int
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (j < matrix.GetLength(1) - 1) Console.Write(matrix[i, j] + ", ");
			else Console.Write(matrix[i, j]);
		}
		Console.WriteLine("]");
	}
}

int SummMatrix(int[,] matrix)
{
	int summMatr = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i == j) summMatr += matrix[i, j];
		}
	}
	return summMatr;
}

int[,] arr1 = CreatMatrixNM(5, 4, 1, 10);
int summ = SummMatrix(arr1);
PrintMatrix(arr1);
System.Console.WriteLine($"Сумма элементов главной диагонали: {summ}");

// int GetSum(int[,] matrix)
// {
//     int sum=0;
//     int size=matrix.GetLength(0)<matrix.GetLength(1)
//         ?matrix.GetLength(0)
//         :matrix.GetLength(1);
//         for (int j = 0; j < size; j++)
//         {
//             sum+=matrix[j,j];
//         }
//         return sum;
// }

// int[,] array2D = CreateMatrixRndInt(4, 3, -100, 100);
// PrintMatrix(array2D);
// int sum=GetSum(array2D);
// Console.WriteLine(sum);