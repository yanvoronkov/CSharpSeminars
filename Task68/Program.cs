// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InsertDigit("Enter natural number m: ");
int n = InsertDigit("Enter natural number n: ");

int akkermanFunResult = AkkermanFun(m, n);
Console.WriteLine($"m = {m}, n = {n} -> {akkermanFunResult}");

int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
	int result; bool parse;
	Console.WriteLine(text);
	parse = Int32.TryParse(Console.ReadLine(), out result);
	if (!parse) result = InsertDigit(text); //Если пользователь ввел некорректное значение вызываем повтороно метод.
	if (result < 0) result = InsertDigit(text); //Проверка на положительные числа 
	return result;
}

int AkkermanFun(int m, int n)
{
	if (m > 0 && n == 0) return AkkermanFun(m - 1, 1);
	if (m > 0 && n > 0) return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
	else return n + 1;
}

