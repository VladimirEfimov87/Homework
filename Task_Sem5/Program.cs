// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2
// Console.WriteLine("Введите количество элементов массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(100, 1000);
//   Console.WriteLine($"{array[i]}");
//   if (array[i] % 2 == 0) count++;
// }

// Console.WriteLine($"чётных элементов : {count} ");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
// Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
//
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 99);
//     Console.WriteLine($"{array[i]}");
// }
// int sum=0;
// for (int j = 0; j < array.Length; j+=2) 
// sum = sum + array[j];

// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sum}");







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[num];

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().NextDouble();
//   Console.WriteLine($"{Math.Round(array[i], 2)}");
// }

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//   if (array[i] > max) max = array[i];
//   if (min > array[i]) min = array[i];
// }

// double result = Math.Round(max, 2) - Math.Round(min, 2);
// Console.WriteLine(Math.Round(max, 2) + "-" + Math.Round(min, 2) + "=" + Math.Round(min, 2));
