// Урок 1. Знакомство с языком программирования С# (семинар)
//Задание 2

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 5;
int b = 7;

Console.WriteLine("Ищем max из " + a + " и " + b);
Console.WriteLine("Максимальное значение " + Math.Max(a, b));
Console.WriteLine("");//разделяем пустой строкой

int c = 2;
int d = 10;

Console.WriteLine("Ищем max из " + c + " и " + d);
Console.WriteLine("Максимальное значение " + Math.Max(a, b));
Console.WriteLine("");//разделяем пустой строкой

int e = -Math.Abs(9); // abc = -Math.Abs(abc);
int f = -Math.Abs(3);

Console.WriteLine("Ищем max из " + e + " и " + f);
Console.WriteLine("Максимальное значение " + Math.Max(e, f));
