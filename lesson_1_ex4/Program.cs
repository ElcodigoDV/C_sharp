// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int [] numbers1 = {2, 3, 7};
int [] numbers2 = {44, 5, 78};
int [] numbers3 = {22, 3, 9};

int length1 = numbers1.Length; //определяем длину м-ва

int length3 = numbers3.Length; //определяем длину м-ва

// ДЛЯ ПЕРВОГО МАССИВА
Console.WriteLine("ищем макс. для " + numbers1 + ". Размер массива " + length1 +" элементов" );//выводим в консоль длину массива


int i = 0;
int max1 = numbers1[0]; //numbers1 заменен на element
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

// ДЛЯ ВТОРОГО МАССИВА
int length2 = numbers2.Length; //определяем длину м-ва
Console.WriteLine("ищем макс. для " + numbers2 + ". Размер массива " + length2 +" элементов" );//выводим в консоль длину массива

//int length2 = numbers2.Length; //определяем длину м-ва
int k = 0;
int max2 = numbers2[0]; //numbers1 заменен на element
while (k < length2)
{
//    int max = numbers1[0];
    if (numbers2[i] > max2)
    {
        max2 = numbers2[i];
    }
    else
    {
        //max = numbers1[]
    }
    k++;
}

Console.WriteLine(max2);
Console.WriteLine(""); //строка-разделитель

// ДЛЯ ТРЕТЬЕГО МАССИВА
Console.WriteLine("ищем макс. для " + numbers3 + ". Размер массива " + length3 +" элементов" );//выводим в консоль длину массива

//int length3 = numbers3.Length; //определяем длину м-ва
int j = 0;
int max3 = numbers3[0]; //numbers1 заменен на element
while (j < length3)
{
//    int max = numbers1[0];
    if (numbers3[i] > max3)
    {
        max3 = numbers3[i];
    }
    else
    {
        //max = numbers1[]
    }
    i++;
}

Console.WriteLine(max3);
Console.WriteLine(""); //строка-разделитель