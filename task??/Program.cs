/*Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number;

    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
    }
}
else Console.WriteLine("Некорректный ввод");*/










/*int[] CreateArrayRndInt(int size, int min, int max)
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
}

int[] GetSumPositiveNegativElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[] {sumPositive, sumNegative};
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }

    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositiveNegativElem = GetSumPositiveNegativElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPositiveNegativElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов -> {sumPositiveNegativElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов -> {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов -> {sumNegativeElem}");*/






double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArrayDouble(double[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    //Console.Write("]");
}












int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        //Console.WriteLine("  |");
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);