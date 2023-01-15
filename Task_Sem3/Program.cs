// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.WriteLine("Введите число: ");
//   int num = Convert.ToInt32(Console.ReadLine());
//   if (((num/10000) ==(num%10)) && ((num/1000%10) == (num/10%10)))
// {
//   Console.Write("Yes");
// }
// else
// {
//   Console.Write("No");
// }


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит 
// // расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X первой точки: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z третьей точки: ");
// int Z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату X1 первой точки: ");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y2 второй точки: ");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z третьей точки: ");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// double res = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2)+ Math.Pow(Z1 - Z, 2) );
// Console.Write(Math.Round(res, 2));



// // //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // // 3 -> 1, 8, 27
// // // // 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
//  int num = Convert.ToInt32(Console.ReadLine());
//  for (int i = 1; i <= num; i++)
//  {
//   Console.WriteLine(Math.Pow(i, 3));
//  } 