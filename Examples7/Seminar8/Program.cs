// int a = 5;
// int b = 10;
// int tmp = b;
// b = a;
// a = tmp;

// Console.WriteLine(a);
// Console.WriteLine(b);



// Задача 53. Написать программу, которая поменяет первую и последнюю строки двумерного массива

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);
// Console.WriteLine();
// SwapLines(result);
// Print2DArray(result);

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void SwapLines(int[,] array)
// {
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = array[0, j];
//         array[0, j] = array[array.GetLength(1) - 1, j];
//         array[array.GetLength(1) - 1, j] = temp;
//     }
//     return;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача55. Написать программу, которая меняет строки на столбцы в двумерном массиве

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);
// Console.WriteLine();
// if(result.GetLength(1) == result.GetLength(0))
// {
//     RotateMatrix(result);
//     PrintNew2DArray(result);
// }
// else
// {
//     Console.WriteLine("Не возможно поменять"); 
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void RotateMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int tmp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             tmp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = tmp;
//         }
//     }
//     return;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintNew2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[j, i]} ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача57. Составить частотный словарь элементов двумерного массива. 
// Словарь содержит информацию сколько раз встречаются элементы в массиве.

// Console.Write("Введите размерность m: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите размерность n: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// Console.WriteLine();
// int[,] result = CreateRandomArray(m, n);
// Print2DArray(result);
// Console.WriteLine();
// int[,] FindArray = FindRepeats(result);
// PrintCuontArray(FindArray);

// int[,] FindRepeats(int[,] array)
// {
//     int[,] arrayCount = new int[2, array.GetLength(0) * array.GetLength(1)];

//     int numCount = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             bool isExist = false;
//             for (int y = 0; y < arrayCount.GetLength(1); y++)
//             {
//                 if (arrayCount[0, y] == array[i, j])
//                 {
//                     arrayCount[1, y] = arrayCount[1, y] + 1;
//                     isExist = true;
//                     break;
//                 }
//             }
//             if (!isExist)
//             {
//                 arrayCount[0, numCount] = array[i, j];
//                 arrayCount[1, numCount] = 1;
//                 numCount++;
//             }
//         }
//     }
//     return arrayCount;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintCuontArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {

//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             if (array[1, i] == 0)
//             {
//                 return;
//             }
//             Console.Write($"{array[j, i]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(0, 10);
//         }
//     }

//     return array;
// }

