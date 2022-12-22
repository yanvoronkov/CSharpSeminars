// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = 5.09986564;
// double dRes = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRes);
// double d = Math.Sqrt(456);

int InsertPositon(string text)
{
	Console.WriteLine(text);
	int pos = Convert.ToInt32(Console.ReadLine());
	return pos;
}

int x1 = InsertPositon("Введите координату Х первой точки:");
int y1 = InsertPositon("Введите координату Y первой точки:");

int x2 = InsertPositon("Введите координату Х второй точки:");
int y2 = InsertPositon("Введите координату Y второй точки:");

double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2)
{
	int temp = (xpos1 - xpos2) * (xpos1 - xpos2) + (ypos1 - ypos2) * (ypos1 - ypos2);
	return Math.Sqrt(temp);
}

double res = LenghtLine(x1, x2, y1, y2);

double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Растояние между точками равно: {resRound}");