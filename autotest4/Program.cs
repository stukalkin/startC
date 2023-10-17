/*Напишите программу для работы с матрицей целых чисел.

Реализуйте класс MatrixOperations, который содержит следующие статические методы:

PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. 
Он принимает на вход двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.

SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так, 
чтобы элементы в каждой строке шли по убыванию.*/


using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
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


    public static void SortRowsDescending(int[,] matrix)
    {
// Введите свое решение ниже
    int max;
    int temp;
    int [] eer = new int [2];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i,j]; 
                max = matrix[i,j];
                for (int k = j; k < matrix.GetLength(1); k++)
                    {
                            if (max < matrix[i, k])
                            {
                                max = matrix[i, k];
                                eer[0]=i;
                                eer[1]=k;
                            }
                    } 
                if (temp != max)
                {
                    matrix[eer[0],eer[1]]=temp;
                    matrix[i,j] = max;
                }
            }
        }
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {9, 1, 7},
                {1, 2, 3},
                {4, 5, 6}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}