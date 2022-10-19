//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

if(int.TryParse(number, out int num))
{
   string N = Convert.ToString(Math.Abs(num));
   if(Math.Abs(num)>99)
   {
    Console.WriteLine($"Третья цифра введенного числа: {N[2]} ");
   }
   else
   Console.WriteLine("Третьей цифры нет в числе");
}
else Console.WriteLine("Вы ввели не число");
