/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

/*int[] FiboArray(int num)
{
    int[] fibonacci= new int[num];
    //fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < fibonacci.Length; i++)
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
    }  
    return fibonacci;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Введите число цифр Фибоначчи");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2) 
{
    Console.WriteLine("Введите число более 1");
    return;
}

int[] result = FiboArray(number);
Console.Write($"Если N = {number} -> ");
PrintArray(result);*/


/*Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.*/

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    //Console.Write("]");
    Console.WriteLine();
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}

int[] firstArray = CreateArrayRndInt(8, 1, 11);
PrintArray(firstArray);
int[] second = CopyArray(firstArray);
second[0] = -1;
PrintArray(second);
int[] third = firstArray;
PrintArray(third);
firstArray[0] = -2;
PrintArray(third);