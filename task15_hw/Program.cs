/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

void findHoliday (int num)
{
    Console.Write($"{num} -> ");
    if (num == 6 || num == 7) Console.Write("да");
    else Console.WriteLine("нет");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8 && number > 0) findHoliday(number);
else Console.WriteLine("Нет такого дня недели");

/*
int Quater(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xCoordinate, yCoordinate);

string result = quater > 0 
                ? $"Указанные координаты соответствуют четверти {quater}" 
                : "Введены некорректные координаты";

Console.WriteLine(result);

*/

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($" {count,3} {count * count,5}");
        count++;
    }
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);
