/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} -> {SumValue(m, n)} ");

int SumValue(int val, int max)
{
    if (max == 0)
        return 0;
    else
        return max + SumValue(val, max - 1);
}
