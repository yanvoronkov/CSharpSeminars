// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

int[] FibArray(int count)
{
	int[] result = new int[count];
	result[1] = 1;
	for (int i = 2; i < count; i++)
	{
		result[i] = result[i - 1] + result[i - 2];
	}
	return result;
}
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ", ");
		else Console.WriteLine(array[i] + "]");
	}
}

int number = InsertDigit("Введите число: ");
int[] arr = FibArray(number);
PrintArray(arr);