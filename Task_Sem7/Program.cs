// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// Console.WriteLine("Ведите количество строк:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите количество столбцов:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double result = new Random().NextDouble() + new Random().Next(-10, 10);

//         array[i,j]= Math.Round(result, 2);
//         Console.Write($"{array[i, j]} ");
        
//     }
//     Console.WriteLine();
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
