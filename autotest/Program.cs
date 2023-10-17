/*Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, 
является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и 
False в следующей строке.
Для остальных чисел вернуть True или False.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
                     False

using System;

public class Answer
{
    static bool IsPalindrome(int number){
      string num = Convert.ToString(number);
      if (number < 100000 && number > 9999)
      {
        if (num[0] == num[4] && num[1] == num[3])
        {
            //Console.Write($"{number} -> ");
            return true;
        }
        else
        {
            //Console.Write($"{number} -> ");
            return false;
        }
      }
      else 
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6454;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}*/







/*Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.


A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        int leg1 = pointA[0]-pointB[0];
        int leg2 = pointA[1]-pointB[1];
        int leg3 = pointA[2]-pointB[2];
        double distance = Math.Sqrt((leg1 * leg1) + (leg2 * leg2) + (leg3 * leg3));
        return distance;
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 7;
            x2 = -5;
            x3 = 0;
            y1 = 1;
            y2 = -1;
            y3 = 9;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}*/











/*Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
N = 3 

1
8
27


N = 5

1
8
27
64
125


using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
        int count = 1;
        while (count <= N)
        {
            Console.WriteLine(count * count * count);
            count++;
        }
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}

int SumNumbers(int num)
{
    int sum = 0;
    
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i;
        }
    }
    
    return sum;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");










int CountDigit(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigit(number);
Console.WriteLine($"Колличество цифр в числе {result}");












int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);*/

//using System;
static void Main (string[] args)
{
    int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
}


public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
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
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n, m];
      int a = 1;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
             matrix[i, j] += a;
            a = a+k;
          }
      }
    return matrix;

    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      int[] mtrx = new int[2];
      if (matrix.GetLength(0)<rowPosition || matrix.GetLength(1)<columnPosition)
      {
        return mtrx;
      }
      else
      {
        mtrx[0] = matrix[rowPosition-1, columnPosition-1];
        return mtrx;
      }

    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
          if (results[0] != 0) Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
          else Console.WriteLine("There is no such index");

        }
    }

    // Не удаляйте и не меняйте метод Main! 

