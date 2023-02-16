Console.Clear();
/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трехзначное число:");
int Num = Convert.ToInt32(Console.ReadLine());

int lastNum = Num % 100;

int res = lastNum / 10;

Console.WriteLine($"Вторая цифра в числе {res}" );

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите  число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;
     if (number >= 100)
      {
         while (number > 999)
        {
         number = number / 10;
        }
      result = number % 10;
      Console.WriteLine($"Третья цифра {result}");
      }
      else
      {
        Console.WriteLine($"Третей цифры нет");
      }

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет*/

Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());

if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
{
  Console.WriteLine("да, это выходной!");
}
else
{
  Console.WriteLine("Нет");
}


