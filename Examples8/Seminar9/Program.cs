// void Recursive(int a, int n, int i = 0)
// {
//     if(i == n)
//     {
//         return;
//     }
//     Console.WriteLine(a);
//     Recursive(++a, n, ++i);
// }

// void Cycle(int a, int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.WriteLine(a);
//         a++;
//     }
// }

// Recursive(5, 10);
// Cycle(5, 10);

//Задача 65. Вывести все натуральные числа в промежутке от M до N с помощью рекурсии

// Console.Write("Введите число M: ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

// Console.Write("Введите число N: ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

// if (!isNumber1 || !isNumber2 || m <= 0 || n <= 0)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// int[] array = new int[n - m + 1];
// int i = 0;

// int[] GetNumbers(int m, int n)
// {
//     if (m <= n)
//     {
//         array[i] = m;
//         m++;
//         i++;
//         GetNumbers(m, n);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");   
//     }
//     Console.WriteLine();
// }

// PrintArray(GetNumbers(m, n));



// //Задача 67. Выводит сумму цифр введеного числа

// //Проверка вводимого числа 
// Console.Write("Введите число: ");
// bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

// if (!isNum_x)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }

// int sum = 0;

// int GetSumNumber(int number)
// {
//     if (number % 10 > 0)
//     {
//         sum += number % 10;
//         number = number / 10;
//         GetSumNumber(number);
//     }
//     return sum;
// }

// Console.WriteLine(GetSumNumber(x));



//Задача 69. Возводит число А в степень В с помощью рекурсии

//Проверка вводимого числа 
// Console.Write("Введите число: ");
// bool isNum_a = int.TryParse(Console.ReadLine(), out int a);
// Console.Write("Введите число: ");
// bool isNum_b = int.TryParse(Console.ReadLine(), out int b);
// if (!isNum_a || !isNum_b)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }

// int i = 1;
// int sum = 1;
// int GetDegreeNumber(int a, int b)
// {
//     if (i <= b)
//     {
//         sum = sum * a;
//         i++;
//         //Console.WriteLine(sum);
//         GetDegreeNumber(a, b);
//     }
//     return sum;
// }
// Console.WriteLine(GetDegreeNumber(a, b));




string[] array = {"hello", "2", "world", ":-)"}; 
string[] resultArray = new string[array.Length];

FillArray(array);
Console.WriteLine();
Print(resultArray);

void FillArray (string[] array)
{
     int count = 0;
     for (int i=0; i < array.Length; i++)
     {      
        if(array[i].Length <= 3)
        {
        resultArray[count] = array[i];
        count++;
        }
     } 
}

void Print(string[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

