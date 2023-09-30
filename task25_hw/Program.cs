/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void Cicl(int a, int b)
{
    int proizv = 1;
    for (int i = 1; i <= b; i++)
    {
        proizv = proizv * a;
    }
    Console.WriteLine(proizv);
}

Cicl(2, 4);