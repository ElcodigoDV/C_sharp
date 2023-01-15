// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("insert number");
goto_insert: string str = Console.ReadLine(); //сюда возвращает go to, если не число
List<int> output = new List<int>();
if (Int32.TryParse(str, out int x) == true)
    {
     int num = Int32.Parse(str);
    //  List<int> output = new List<int>();
     //  int [] array; //объявляем массив размером num
     int j = 0;
     for (int i = 1; i < num +1; i++) //"num+1", чтобы число последнее также попало в проверку
         {
         if ((num % 2) == 0)
             {
              output = output.Add(j);
             }
         else
             {
             //  Console.WriteLine("Число " + num + " нечетное.\n");   
                  
             }
         }
    }
Console.WriteLine(output);
// Console.WriteLine(string.Join(",", arr));//"Твое число " + num + " и оно четное.\n");


//         if ((num % 2) == 0)
//             {
//                 Console.Write("Твое число " + num + " и оно четное.\n");
//             }
//         else
//             {
//                 Console.WriteLine("Число " + num + " нечетное.\n");
//             }
//     }
// else
//     {
//         Console.WriteLine("Непохоже на число. Попробуй еще раз...");
//         goto goto_insert; //просим снова ввести число
//     }
