// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int InsertDigit(string text) //Метод пользовательского ввода числа
{
	System.Console.WriteLine(text);
	int result = Convert.ToInt32(Console.ReadLine());
	return result;
}

bool IsExistTriangle(int s1, int s2, int s3)
{
	return ((s1 < s2 + s3) && (s2 < s1 + s3) && (s3 < s1 + s2)); //это выражение сразу принимат значение true или false
}

int side1 = InsertDigit("Введите первую сторону треугольника");
int side2 = InsertDigit("Введите вторую сторону треугольника");
int side3 = InsertDigit("Введите третью сторону треугольника");

bool triangle = IsExistTriangle(side1, side2, side3);

Console.WriteLine(triangle ? "Треугольник существует" : "Треугольник не существует");

