/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), 
а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

Также, задайте метод PrintArray, который выводил бы массив на экран.

Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] 
с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. 

Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10
0,5    7    -2    -0,2
1    -3,3    8    -9,9
8    7,8    -7,1    9

using System;

public class Answer {
  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
      double[,] matrix = new double[m, n];
      Random rnd = new Random();

      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
             matrix[i, j] = rnd.Next(minLimitRandom, maxLimitRandom + 1);
             matrix[i,j] += 0.1;
          }
      }
    return matrix;
  }

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F2}\t");
        }
        //Console.WriteLine("  |");
        Console.WriteLine();
    }
  }

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}*/





















/*Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - 
количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в 
указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из 
метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". 
Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

void PrintArray (int [,] matrix)
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
  
    int[,] CreateIncreasingMatrix(int n, int m, int k)
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
  
    int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
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

     void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
          if (results[0] != 0) Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
          else Console.WriteLine("There is no such index");
        }
    

           int d = 3;
           int m = 4;
           int k = 2;
           int x = 2;
           int y = 6;
        

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(d, m, k);
        PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);*/




















/*Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
с каждым новым элементом увеличивающимся на определенное число. 
Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот 
список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних 
значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через 
точку, см. формат вывода), разделенные знаком табуляции.*/


using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
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
                a = a + k;
            }
        }
        return matrix;

    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"{list[i]:F2}\t");
        }
        Console.WriteLine("");

    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        double[] array = new double[matrix.GetLength(1)];
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          for (int i = 0; i < matrix.GetLength(0); i++)
          {
            sum += matrix[i, j]; 
            //Console.WriteLine(matrix[i, j]);
          }
          sum = sum/matrix.GetLength(0);
          array[j] = sum;
          sum = 0;
        }
        return array;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}