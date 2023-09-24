/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите 3х значное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) Console.WriteLine("Введено НЕ 3х значное число");
else 
{
    Console.WriteLine($"{number} -> {(number % 100) / 10}");
}