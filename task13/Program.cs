//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите номер: ");
int number = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(number) > 99)
{
    while(Math.Abs(number) > 999)
    {
        number = number / 10;
    }
    int thirdNum = number % 10;
    Console.WriteLine(thirdNum);
}
else
{
    Console.WriteLine("Третьей цифры нет в числе");
}