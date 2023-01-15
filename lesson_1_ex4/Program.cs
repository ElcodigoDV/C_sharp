// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int [] numbers1 = {2, 3, 7};
int [] numbers2 = {44, 5, 78};
int [] numbers3 = {22, 3, 9};

var [] array_numbers = {numbers1, numbers2, numbers3}; // делаем массив из массивов
Console.WriteLine(array_numbers);

foreach (int element in array_numbers)
{
    int length1 = element.Length; //определяем длину м-ва

    Console.WriteLine("ищем макс. для " + element + ". Размер массива " + length1 +" элементов" );//выводим в консоль длину массива

    int i = 0;
    int max1 = element[0]; //numbers1 заменен на element
    while (i < length1)
{
//    int max = numbers1[0];
    if (numbers1[i] > max1)
    {
        max1 = numbers1[i];
    }
    else
    {
        //max = numbers1[]
    }
    i++;
}

    Console.WriteLine(max1);
    Console.WriteLine(""); //строка-разделитель
}
