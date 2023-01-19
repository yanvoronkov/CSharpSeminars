// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//присваиваем переменным введенные пользователем данные через метод пользовательского ввода числа
int length = InsertDigit("Введите размер массива");
int minimal = InsertDigit("Введите минимально допустимое значение диапазона");
int maximal = InsertDigit("Введите максимально допустимое значение диапазона");

//создаем переменную типа массив и присваиваем ей результат метода создания массива
int[] array = CreateArray(length, minimal, maximal);

PrintArray(array);
int sumOddNumbers = FindSumOddNumbers(array);
Console.WriteLine($" -> {sumOddNumbers}");

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
//метод поиска суммы чисел массива, стоящих на нечетных позициях индекса
int FindSumOddNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (i % 2 != 0) sum += array[i];
	}
	return sum;
}