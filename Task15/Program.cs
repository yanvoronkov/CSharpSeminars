// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели,
// 2. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7:");
string day = Console.ReadLine();

if (day == "1")
{
	Console.WriteLine("День недели не выходной");
}
else if (day == "2")
{
	Console.WriteLine("День недели не выходной");
}
else if (day == "3")
{
	Console.WriteLine("День недели не выходной");
}
else if (day == "4")
{
	Console.WriteLine("День недели не выходной");
}
else if (day == "5")
{
	Console.WriteLine("День недели не выходной");
}
else if (day == "6")
{
	Console.WriteLine("День недели выходной");
}
else if (day == "7")
{
	Console.WriteLine("День недели выходной");
}
else
{
	Console.WriteLine("Проверьте введенные данные");
}