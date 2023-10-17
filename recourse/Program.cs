/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintNaturalNumbers(number);

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
}


/*Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"*/


Console.WriteLine("Введитеи первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитеи второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintRangeNaturalNumbers(numberM, numberN);

void PrintRangeNaturalNumbers(int numM, int numN)
{
    if (numM < numN) 
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM + 1, numN);
    }

    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM - 1, numN);
    }
    else Console.Write($"{numM} ");
}


/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/


int SumOfDigits(int n) // 453 45 4 0
{
	if(n == 0) return 0;
	return n % 10 + SumOfDigits(n / 10); //453 45 4 
    // return 0 + 4 % 10 + 45 % 10 + 453 % 10 = 12

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(number)); // 120


/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/


int Pow(int a, int b) // 3,5 - 3,4 - 3,3 -3,2 -3,1 -3,0
{
    if (b == 0) return 1;
    return a * Pow(a, b - 1); //  3,5 - 3,4 -3,3 -3,2 -3,1
    // return (1) * 3 * 3 *3 * 3 * 3 = 243

}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целую степень числа A: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB<0) 
{
    Console.WriteLine(1/(double)Pow(numberA,-numberB)); 
}
else Console.WriteLine(Pow(numberA,numberB));