//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string? number = Console.ReadLine();

if(int.TryParse(number, out int num))
{
   string N = Convert.ToString(Math.Abs(num));
   if(Math.Abs(num) > 99 && Math.Abs(num) < 1000)
   {
    Console.WriteLine($"Третья цифра введенного числа: {N[2]} ");
   }
   else Console.Write("Третьей цифры нет в числе");
}
else Console.WriteLine("Вы ввели не число");