/*Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД)
этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7*/

Console.Clear();

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} -> {GCDValue(m, n)} ");

int GCDValue(int val, int lav)
{
    int min;
    if (val > lav)
        min = lav;
    else
        min = val;
    int i = min;
    if ((val % i == 0) && (lav % i == 0)) return i;
    else return i = GCDValue(val - 1, lav -1);   
}
