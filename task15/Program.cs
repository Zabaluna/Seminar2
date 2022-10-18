// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n > 0 && n <= 7)
{
    if (n == 1)
    {
     Console.Write("Рабочий день ");
    }


    if (n == 2) 
    {
    Console.Write("Рабочий день: ");
    }

    if (n == 3) 
    {
    Console.Write("Рабочий день: ");
    }

    if (n == 4)
    {
     Console.Write("Рабочий день: ");
    }

    if (n == 5) 
    {
    Console.Write("Рабочий день  ");
    }

    if (n == 6) 
    {
    Console.Write("Ура!!! Выходной:-) ");
    }

    if (n == 7)
    {
     Console.Write("Ура!!! Выходной:-)" );
    }
}
else 
   {
    Console.WriteLine("Попробуйте еще раз, введите число от 1 до 7: ");
   }
