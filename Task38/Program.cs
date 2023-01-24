// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//присваиваем переменным введенные пользователем данные через метод пользовательского ввода числа
int length = InsertDigit("Введите размер массива");

//создаем переменную типа массив и присваиваем ей результат метода создания массива
double[] array = CreateArray(length);

PrintArray(array);
double maxMinNumbers = FindMaxMinNumbers(array);
Console.WriteLine($" -> {maxMinNumbers}");

//метод пользовательского ввода числа
int InsertDigit(string text)
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

//метод создания массива из псевдочисел
double[] CreateArray(int len)
{
	double[] array = new double[len];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(rnd.NextDouble(), 1);
	}
	return array;
}

//метод вывода массива в консоль
void PrintArray(double[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.Write(array[i] + "]");
	}
}

//Метод поиска разности между максимальным и минимальным значениями массива
double FindMaxMinNumbers(double[] array)
{
	double max = array[0];
	double min = array[0];
	for (int i = 1; i < array.Length; i++)
	{
		if (array[i] > max) max = array[i];
		if (array[i] < min) min = array[i];
	}
	double diffMaxMin = max - min;
	return diffMaxMin;
}

//пользовательский ввод массива в строку через запятую
int[] GetUserNumbers()
{
	Console.Write("Введите числа через запятую: ");
	string str = Console.ReadLine();
	string[] strArr = str.Split(',');
	int[] result = new int[strArr.Length];
	for (int i = 0; i < strArr.Length; i++)
	{
		result[i] = Convert.ToInt32(strArr[i]);
	}
	return result;
}