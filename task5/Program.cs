//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b || b*b == a)  
{
    Console.Write("Число является квадратом другого числа: " );
}
else
{
    Console.Write("Число не является квадратом другого числа: " );
}




