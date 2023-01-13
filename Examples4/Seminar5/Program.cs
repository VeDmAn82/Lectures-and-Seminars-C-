// Поиск числа в массиве

// Random random = new Random();
// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(-10, 10);
// }
// printArray(array);
// System.Console.WriteLine();

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(HasNumber(array, number));

// bool HasNumber(int[] array, int number)
// {
//     foreach (var item in array)
//     {
//         if (number == item)
//         {
//             return true;
//         }
//     }

//     return false;
// }

// void printArray(int[] array) {
    
//     foreach(int elem in array)
//     {
//         System.Console.Write($"{elem}, ");
//     }
// }



// Замена положительных на отрицательные числа

// Random random = new Random();
// int[] array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(-10, 10);
// }
// printArray(array);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
// }
// System.Console.WriteLine();
// printArray(array);

// void printArray(int[] array) {
    
//     foreach(int elem in array)
//     {
//         System.Console.Write($"{elem}, ");
//     }
// }


//Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.WriteLine("Enter length - ");

// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = FillArray(length);
// PrintArray(array);

// int sumPositiveNumber = GetSumPositiveNumberInArray(array);

// Console.WriteLine($"sum Positive Number - {sumPositiveNumber}");

// int sumNegativeNumber = GetSumNegativeNumberInArray(array);

// Console.WriteLine($"sum negative Number - {sumNegativeNumber}");

// int GetSumNegativeNumberInArray(int[] array)
// {
//     int sumNegativeNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             sumNegativeNumber += array[i];
//         }
//     }

//     return sumNegativeNumber;
// }

// int GetSumPositiveNumberInArray(int[] array)
// {
//     int sumPositiveNumber = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0)
//         {
//          sumPositiveNumber += array[i];
//         }
//     }

//     return sumPositiveNumber;
// }

// void PrintArray(int[] array)
// {
//     if(array.Length == 0)
//     {
//         Console.WriteLine("Что-то пошло не так");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }

//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }

// int[] FillArray(int length)
// {
//     int[] array = new int[length];
    
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(-9, 10);
//     }
//     return array;
// }


// Задать одномерный массив из 123 случайных чисел. Найти количество элементов массива, значения которых лежат в отрезке [10, 99]

// Random random = new Random();
// int[] array123 = new int[10];
// for (int i = 0; i < array123.Length; i++)
// {
//     array123[i] = random.Next(1, 200);
// }
// printArray(array123);
// System.Console.WriteLine();

// System.Console.WriteLine(GetCount(array123));

// int GetCount(int[] array)
// {
//     int counter = 0;
//     foreach (var item in array)
//     {
//         if (item >= 10 && item <= 99)
//         {
//             counter++;
//         }
//     }

//     return counter;
// }

// void printArray(int[] array) {
    
//     foreach(int elem in array)
//     {
//         System.Console.Write($"{elem}, ");
//     }
// }



// Найти произведение пар чисел в одномерном массиве. Пара - первое и последнее, второе и предпоследнее и т.д. Результат в новый массив

// Random random = new Random();
// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next(1, 10);
// }
// printArray(array);
// System.Console.WriteLine();

// printArray(GetMultiPair(array));

// int[] GetMultiPair(int[] array)
// {
//     int[] arr;

//     if (array.Length % 2 == 0)
//     {
//         arr = new int[array.Length / 2];
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             arr[i] = array[i] * array[array.Length - 1 - i];

//         }
//     }
//     else
//     {
//         arr = new int[array.Length / 2 + 1];
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             arr[i] = array[i] * array[array.Length - 1 - i];

//         }
//         arr[arr.Length - 1] = array[array.Length / 2 + 1];
//     }

//     return arr;
// }

// void printArray(int[] array)
// {

//     foreach (int elem in array)
//     {
//         System.Console.Write($"{elem}, ");
//     }
// }