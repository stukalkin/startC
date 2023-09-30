/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(20);
    }
    return array;
}

void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != 0) Console.Write(", ");
        Console.Write(arr[i]);
    }
}

int[] array = CreateArray(8);
ShowArray(array);
Console.Write(" -> [");
ShowArray(array);
Console.Write("]");