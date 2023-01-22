﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// int n = ReadInt("Введите количество строк: ");
// int colums = ReadInt("Введите количество столбцов: ");
// double[,] numbers = new double[n, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// // Заполнение массива рандомными вещественными числами
// void FillArray2D(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(-99, 99) / 10.0;
//     }
//   }
// }

// //  Функция вывода массива в терминал
// void PrintArray2D(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }

// // Функция ввода 
// int ReadInt(string message)
// {
//   Console.Write(message);
//   return Convert.ToInt32(Console.ReadLine());
// }





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет

// Console.WriteLine("Введите индекс строки: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (n < numbers.GetLength(0) && m < numbers.GetLength(1)) Console.WriteLine(numbers[n, m]);
// else Console.WriteLine($"{n}{m} -> такого числа в массиве нет");


// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(1, 10);
//     }
//   }
// }

// //  Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
//   Console.WriteLine();
// }







// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int[,] array = new int[2, 2];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 100);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// (double, double) SaySum(int[,] array)
// {
//     double sum = (array[0, 0] + array[1, 0]) / 2;
//     double sum1 = (array[0, 1] + array[1, 1]) / 2;
//     return (sum, sum1);

// }
// double sum, sum1 = 0;
// (sum, sum1)= SaySum(array);
// Console.WriteLine((sum, sum1));
