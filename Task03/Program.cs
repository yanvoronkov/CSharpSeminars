// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 20 мин

Console.WriteLine("Введите целое число от 1 до 7:");
string day = Console.ReadLine();

if (day == "1")
{
	Console.WriteLine("День недели - понедельник");
}
else if (day == "2")
{
	Console.WriteLine("День недели - вторник");
}
else if (day == "3")
{
	Console.WriteLine("День недели - среда");
}
else if (day == "4")
{
	Console.WriteLine("День недели - четверг");
}
else if (day == "5")
{
	Console.WriteLine("День недели - пятница");
}
else if (day == "6")
{
	Console.WriteLine("День недели - суббота");
}
else if (day == "7")
{
	Console.WriteLine("День недели - воскресенье");
}
else
{
	Console.WriteLine("Проверьте введенные данные");
}
