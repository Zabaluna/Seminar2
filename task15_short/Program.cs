// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n > 0 && n <= 7)
{   
    if (n == 6 | n == 7) Console.WriteLine("Ура!!! Выходной:-) ");
    else Console.WriteLine("Рабочий день");
}
    else Console.WriteLine("Попробуйте еще раз, введите число от 1 до 7: ");
   