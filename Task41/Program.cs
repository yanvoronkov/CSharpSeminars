// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int arrayLength = InsertDigit("Введите размер массива: ");
int[] arr = FillArray(arrayLength);
PrintArray(arr);
int count = HowNumbersGreaterZero(arr);
Console.WriteLine($" -> {count}");

//метод, определяющий количество чисел больше ноля, которые ввел пользователь
int HowNumbersGreaterZero(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) count++;
	}
	return count;
}

//метод, заполняющий массив введенными пользователем числами
int[] FillArray(int value)
{
	int[] array = new int[arrayLength];
	for (int i = 0; i < arrayLength; i++)
	{
		int result = InsertDigit($"Введите {i + 1}-е число массива из {arrayLength}: ");
		array[i] = result;
	}
	return array;
}

//метод пользовательского ввода числа
int InsertDigit(string text)
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

//вывод на печать массива
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.Write(array[i] + "]");
	}
}

