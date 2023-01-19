// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами.
// 2.Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//присваиваем переменным введенные пользователем данные через метод пользовательского ввода числа
int length = InsertDigit("Введите размер массива");
int minimal = InsertDigit("Введите минимально допустимое значение диапазона");
int maximal = InsertDigit("Введите максимально допустимое значение диапазона");

//создаем переменную типа массив и присваиваем ей результат метода создания массива
int[] array = CreateArray(length, minimal, maximal);

PrintArray(array);
int evenNumbers = FindEvenNumbers(array);
Console.WriteLine($" -> {evenNumbers}");

//метод пользовательского ввода числа
int InsertDigit(string text)
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

//метод создания массива из псевдочисел
int[] CreateArray(int len, int min, int max)
{
	int[] array = new int[len];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}

//метод вывода массива в консоль
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.Write(array[i] + "]");
	}
}

int FindEvenNumbers(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) count = count + 1;
	}
	return count;
}