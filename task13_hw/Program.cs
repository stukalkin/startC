/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void findThree (int num)
{
    Console.Write($"{num} -> ");
    if (num > 999) 
    {
        while (num > 999)
        {
            num = num / 10;
        }
    }
    Console.WriteLine($"{num % 10}");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99) findThree(number);
else Console.WriteLine("Нет третьего числа");