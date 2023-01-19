// Задача 29: Напишите программу, которая
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int length = InsertDigit("Введите размер массива");
int minimal = InsertDigit("Введите минимально допустимое значение диапазона");
int maximal = InsertDigit("Введите максимально допустимое значение диапазона");

int[] array = CreateArray(length, minimal, maximal); //создаем переменную и присваиваем ей результат метода создания массива

string strArr = string.Join(", ", array); //Выводим массив в одну строку с разделителем и преобразованием в тип string
Console.Write($"{strArr} -> ");
PrintArray(array);

// int[] a = { 1, 2, 3 };
// string s = string.Join(",", a);

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

int[] CreateArray(int len, int min, int max)//метод создания массива из псевдочисел
{
	int[] array = new int[len];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.Write(array[i] + "]");
	}
}
