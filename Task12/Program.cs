// 11. Напишите программу, которая будет принимать на ход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не картно числу 2& 
// то программа выводит остаток от деления.ъ


Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

bool DivCheck(int number1, int number2)
{
	return number1 % number2 == 0;
}

if (DivCheck(userNumber, userNumber2))
{
	Console.WriteLine($"{userNumber}, {userNumber2} -> кратно");
}
else
{
	Console.WriteLine($"{userNumber}, {userNumber2} -> не кратно, остаток " + (userNumber % userNumber2));
}