//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

// int x1 = number/100;
// Console.WriteLine($"{x1}");
int x2 = number/10;
// Console.WriteLine($"{x2}");

int x3 = x2 % 10;
Console.WriteLine($"{x3}");

