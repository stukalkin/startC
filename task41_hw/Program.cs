/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] ArrAdd(int num)
{
    int[] arr = new int[num];
    Console.WriteLine("Пришло время заполнить массив");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
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


Console.WriteLine("Введите число элементов");
int colElem = Convert.ToInt32(Console.ReadLine());
int[] array = ArrAdd(colElem);
int result = CountArr(array);
PrintArray(array);
Console.WriteLine($"Колличество положительных элементов - {result}");