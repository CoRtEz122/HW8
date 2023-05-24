// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите первое число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите первое число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows,columns];


// void GetArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         result[i,j] = new Random().Next(0,10);
//     }
// }
// }

// void PrintArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         Console.Write(result[i,j]);
//     }

//     Console.WriteLine();
// }
// }

// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(1) - 1; k++)
//             {
//                 if (result[i, k] < result[i, k + 1])
//                 {
//                     int temp = result[i, k + 1];
//                     result[i, k + 1] = result[i, k];
//                     result[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// GetArray();
// PrintArray();
// Console.WriteLine();
// ChangeArray(result);
// PrintArray();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите первое число");
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = rows - 1;

// int[,] result = new int[rows,columns];

// void GetArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         result[i,j] = new Random().Next(0,10);
//     }
// }
// }

// void PrintArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         Console.Write(result[i,j]);
//     }

//     Console.WriteLine();
// }
// Console.WriteLine();
// }

// void ChangeArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     int sum = 0;
//     int min = 0;
//     int IndexMinRows = 0;
    
//             for (int j = 0; j < result.GetLength(1); j++)
//             {
//                 sum += result[i,j];
//             }
//     Console.WriteLine(sum);
// }



// }
// GetArray();
// PrintArray();
// ChangeArray();


