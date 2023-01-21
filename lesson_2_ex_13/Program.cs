// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
int num = Int32.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("3-го числа не содержит");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}