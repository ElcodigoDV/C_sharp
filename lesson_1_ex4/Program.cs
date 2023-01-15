// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[][] numbers = {   //создаем "массив из массивов"
    new int[] {12, 3, 7},   // 2, 3, 7 -> 7
    new int[] {44, 5, 78},  // 44 5 78 -> 78
    new int[] {22, 3, 9}    // 22 3 9 -> 22
};

foreach(int[] row in numbers)
{
    int length1 = numbers.Length; //определяем длину м-ва
    Console.WriteLine("ищем макс. для " + string.Join(", ", row) + ". Размер массива " + length1 +" элементов." );//выводим в консоль справ. информацию
    //Console.WriteLine(length1);
    int i = 0;
    int max = row[0];
    while (i < length1)
        {
        if (row[i] > max)
            {
            max = row[i];
            }
        else
            {
            //max = numbers1[]
            }
        i++;
        }

    Console.WriteLine("Макс. значение  " + max);
    Console.WriteLine(""); //строка-разделитель
}