//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int x1 = number/100;
int x2 = number%10;

Console.WriteLine($"{x1}{x2}");