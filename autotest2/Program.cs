/*Напишите программу, которая подсчитывает количество четных элементов в массиве целых 
положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает массив 
целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.*/

/*using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {   
            if (array[i] % 2 == 0) count += 1; 
        }
        return count;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}	");
        }
        Console.WriteLine("");
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 124, 378, 593, 821, 456 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}*/















/*Напишите программу, которая находит сумму элементов с нечетными индексами в 
одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых 
чисел и возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
Аргументы, передаваемые в метод/функцию:

using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
// Введите свое решение ниже
    int count = 0;
        for (int i = 1; i < array.Length; i += 2)
        {   
            count += array[i]; 
        }
        return count;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}	");
        }
        Console.WriteLine("");
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}*/


















/*Напишите программу для работы с массивом вещественных чисел.
Реализуйте класс ArrayOperations, который содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и 
возвращает разницу между максимальным и минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив array
 и выводит его элементы с двумя знаками после запятой через табуляцию.

Аргументы, передаваемые в метод/функцию:*/

using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
return 0;

       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
return 0;


    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
        double min = array[0];
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i]; 
        }

    return max - min;
    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}	");
        }
        Console.WriteLine("");
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78.03 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}