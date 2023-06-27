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
