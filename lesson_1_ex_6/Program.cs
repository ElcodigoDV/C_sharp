// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Привет! Давай сыграем в игру");
Console.WriteLine("Ты будешь вводить число, а я буду говорить, четное число или нечетное");
Console.WriteLine("Show must go on! Вводи число: ");
goto_link: string str = Console.ReadLine();

if (Int32.TryParse(str, out int x) == true)
    {
        int num = Int32.Parse(str);
        if ((num % 2) == 0)
            {
                Console.Write("Твое число " + num + " и оно четное.\n");
            }
        else
            {
                Console.WriteLine("Число " + num + " нечетное.\n");
            }
    }
else
    {
        Console.WriteLine("Непохоже на число. Попробуй еще раз...");
        goto goto_link; //просим снова ввести число
    }
