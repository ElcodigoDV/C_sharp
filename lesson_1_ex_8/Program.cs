// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("insert number");
goto_insert: string str = Console.ReadLine(); //сюда возвращает go to, если не число

if (Int32.TryParse(str, out int x) == true)
    {
     int num = Int32.Parse(str);
    
    for (int i = 1; i < num+1; i++) //"num+1", чтобы число последнее также попало в проверку
         {
         if ((i % 2) == 0)
             {
            Console.Write(i + " ");
             }
         else
             {
             //  nothing   
                  
             }
         }
    }
