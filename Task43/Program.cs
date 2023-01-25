// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//1. Метод ввода пользователем значений
//2. Метод проверки условия на паралельность или слияние
//3. Метод вычисления координаты x, y (x = (b1 - b2)/(k2 - k1))
//4. Вывод на печать результата по образцу, как в примере



double b1 = InsertDigit("Введите значение b1: ");
double k1 = InsertDigit("Введите значение k1: ");
double b2 = InsertDigit("Введите значение b2: ");
double k2 = InsertDigit("Введите значение k2: ");

if (k1 == k2)
{
	Console.WriteLine("Точки пересечения нет, так как прямые параллельны");
}
else
{
	double x = Math.Round(CheckIntersectionOfTwoLineSegmentsX(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
	double y = Math.Round(CheckIntersectionOfTwoLineSegmentsY(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
	Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y}))");
}


//метод пользовательского ввода числа

double InsertDigit(string text)
{
	System.Console.WriteLine(text);
	double result = Convert.ToDouble(Console.ReadLine());
	return result;
}


//Метод вычисления координаты x
double CheckIntersectionOfTwoLineSegmentsX(double b1, double k1, double b2, double k2)
{
	double x = (b1 - b2) / (k2 - k1);
	return x;
}
//Метод вычисления координаты x
double CheckIntersectionOfTwoLineSegmentsY(double b1, double k1, double b2, double k2)
{
	double y = k1 * ((b1 - b2) / (k2 - k1)) + b1;
	return y;
}



