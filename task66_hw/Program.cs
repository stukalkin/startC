/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введитеи первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = PrintRangeNaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных чисел между M = {numberM}; N = {numberN} -> {result}");

int PrintRangeNaturalNumbers(int numM, int numN, int sum = 0)
{
    if (numM < numN) 
    {
        if (numM < 0) numM = 1;
        return numM + PrintRangeNaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        if (numN < 0) numN = 1;
        return numM + PrintRangeNaturalNumbers(numM - 1, numN);
    }
    else return numM;
}