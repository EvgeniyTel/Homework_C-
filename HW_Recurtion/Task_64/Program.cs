/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8*/
Console.Clear();

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} -> ");
PrintValue(m, n);

void PrintValue(int val, int max)
{
    for (int i = 0; i < max; i++)
    {
        if (val % 2 == 0)
        {
            if (val > max)
                return;
        }
        else
            val += 1;
    }
    Console.Write($" {val} | ");
    PrintValue(val + 1, max);
}
