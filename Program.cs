﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] CreateArray(int size)
// {
//     return new int[size];
// }
// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(100, 1000);
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//         res += array[i] + " ";
//     return res;
// }
// int CountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }
// int size = InputNum("Введите размер массива: ");
// int [] myArray = CreateArray(size);
// FillArray(myArray);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// Console.WriteLine("");
// int res = CountNumbers(myArray);
// Console.WriteLine(res);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] CreateArray(int size)
// {
//     return new int[size];
// }
// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1);
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//         res += array[i] + " ";
//     return res;
// }
// int CountSumNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i];
//     return sum;
// }
// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// int result = CountSumNumbers(myArray);
// Console.WriteLine($"Сумма элементов на нечетных позициях равна {result}.");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double[] CreateArray(int size)
{
    return new double[size];
}
void FillArray(double[] array, int num)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = Math.Round(rnd.NextDouble() * num, 2);
}
string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i ++)
        if (array[i] > max) max = array[i];
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i ++)
        if (array[i] < min) min = array[i];
    return min;
}
int size = InputNum("Введите размер массива: ");
int number = InputNum("Введите максимальное число для создания массива: ");
double[] myArray = CreateArray(size);
FillArray(myArray, number);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
double minNum = FindMin(myArray);
double maxNum = FindMax(myArray);
double result = maxNum - minNum;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {result}.");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1);
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//         res += array[i] + " ";
//     return res;
// }
// int[] ChangeArray(int[] array)
// {
//     int length = array.Length;
//     int[] changedArray = new int[length / 2 + length % 2];
//     for (int i = 0; i < length / 2; i++)
//     {
//         changedArray[i] = array[i] * array[length - i - 1];
//     }
//     if (length % 2 == 1)
//         changedArray[length / 2 - 1] = array[length / 2];
//     return changedArray;
// }
// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// int[] resultArray = ChangeArray(myArray);
// string txt2 = PrintArray(resultArray);
// Console.WriteLine(txt2);

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
// return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
// Random rnd = new Random(); // создание экземпляра класса Random
// for (int i = 0; i < array.Length; i++)
// array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
// // array[i] = new Random().Next(min, max + 1)
// }
// string PrintArray(int[] array)
// {
// string res = String.Empty;
// for (int i = 0; i < array.Length; i++)
// res += array[i] + " ";
// return res;
// }
// int CountNum(int[] array)
// {
// int index = 0;
// int length = array.Length;
// for (int i = 0; i < length; i++)
// {
// if (array[i] >= 10 && array[i] <= 99)
// {
// index++;
// }
// }
// return index;
// }
// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);
// int ind = CountNum(myArray);
// Console.WriteLine(ind);

// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
// return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
// Random rnd = new Random(); 
// for (int i = 0; i < array.Length; i++)
// array[i] = rnd.Next(min, max + 1);
// }

// string PrintArray(int[] array1)
// {
// string res = String.Empty;
// for (int i = 0; i < array1.Length; i++)
// res += array1[i] + " ";
// return res;
// }

// int[] ChancedArray (int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = -array[i];
// return array;
// }

// int length = InputNum ("Enter massive size ");
// int maxValue = InputNum("Enter maximum ");
// int minValue = InputNum("Enter minimum ");
// int [] newArray = CreateArray(length);
// FillArray(newArray, minValue, maxValue);
// string myArray = PrintArray(newArray);
// Console.WriteLine(myArray);
// int [] changedArray = ChancedArray(newArray);
// string result = PrintArray(changedArray);
// Console.WriteLine(result);



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(-100, 100);
// }

// string PrintArray(int[] array1)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array1.Length; i++)
//         res += array1[i] + " ";
//     return res;
// }

// bool FindNumber(int num, int[] array1)
// {
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i] == num) return true;
//     }
//     return false;

// }
// int len = InputNum("Введите длину массива ");
// int[] newArray = CreateArray(len);
// FillArray(newArray);
// string arraytxt = PrintArray(newArray);
// Console.WriteLine(arraytxt);
// int n = InputNum("ВВедите число для поиска ");
// bool answer = FindNumber(n, newArray);
// Console.WriteLine(answer);

// Использование FOREACH:
// void PrintArray(int[] array)
// {
// foreach (int item in array)
// {
// Console.Write($"{item} ");
// }
// Console.WriteLine();
// }

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.
// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
// return new int[size];
// }
// Создаем массив как ячейку памяти, далее метод заполняет массив рандомными числами.
// При этом используется функция void, как ссылка на ранее созданный массив с 0ыми значениями.
// Сам массив находится в переменной myArray.
// void FillArray(int[] array, int min, int max)
// {
// Random rnd = new Random(); // создание экземпляра класса Random
// for (int i = 0; i < array.Length; i++)
// array[i] = rnd.Next(min, max + 1);
// }
// // [min, max) полуинтервал
// // array[i] = new Random().Next(min, max + 1)
// Один из вариантов печати (вывода массива) на экран для пользователя.
// string PrintArray(int[] array)
// {
// string res = String.Empty;
// for (int i = 0; i < array.Length; i++)
// res += array[i] + " ";
// return res;
// }
// Метод ищет сумму положительных элементов массива. Затем отрицательных.
// int SumPositiveNums(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if (array[i] > 0)
// sum += array[i];
// return sum;
// }
// int SumNegativeNums(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if (array[i] < 0)
// sum += array[i];
// return sum;
// }

// int size = InputNum("Введите размер массива: ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);

// int pos = SumPositiveNums(myArray);
// int neg = SumNegativeNums(myArray);

// Console.WriteLine($"Сумма положительных элементов равна {pos}");
// Console.WriteLine($"Сумма отрицательных элементов равна {neg}");
