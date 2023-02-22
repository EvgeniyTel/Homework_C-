Console.Clear();

/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.Write("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Возведение числа {a} в степень {b} = {GetPowByNumber(b)}");

int GetPowByNumber(int limit)
{
    int result = 1;
    for (int i = 1; i <= limit; i++)
    {
        result *= a;
    }
    return result;
}

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int GetSumNumbToValue(int value)
{
    
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine($"В числе {num} сумма цифр = {GetSumNumbToValue(sum)}");

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
Console.Write("Введите числа ");
int arr = Convert.ToInt32(Console.ReadLine());
void WriteNumbArray(int[] arr)
{
    int arrLenght = arr.Length;
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] =Convert.ToInt32(Console.ReadLine());
    }
    Console.Write($"{arr} ");
}

void PrintArr(int[] arr)
{
    Console.Write($"[");
    int count = 0;
    int arrLenght = arr.Length;
    foreach (int num in arr)
    {
        count++;
        Console.Write($"{num} ");

      if(count == arrLenght)
      {
        Console.Write($"]");
      }
      else{
          Console.Write($"");
      }
    }

    Console.WriteLine($"");
}
int arrLenght = 8;
int[] arrNumArray = new int[arrLenght];

for (int i = 0; i < arrLenght; i++)
{
    arrNumArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Вывод [{string.Join(",", arrNumArray)}]");