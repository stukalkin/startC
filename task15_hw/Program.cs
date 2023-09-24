/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

void findHoliday (int num)
{
    Console.Write($"{num} -> ");
    if (num == 6 || num == 7) Console.Write("да");
    else Console.WriteLine("нет");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0) findHoliday(number);
else Console.WriteLine("Нет такого дня недели");