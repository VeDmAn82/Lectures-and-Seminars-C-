// Проверка треугольника

// Console.WriteLine("Первое число:  ");
// bool isNumber1 = int.TryParse(Console.ReadLine(), out int x);
// Console.WriteLine("Второе число:  ");
// bool isNumber2 = int.TryParse(Console.ReadLine(), out int y);
// Console.WriteLine("Третье число:  ");
// bool isNumber3 = int.TryParse(Console.ReadLine(), out int z);

// if (!isNumber1 || !isNumber2 || !isNumber2)
// {
//     Console.WriteLine("Invalid number");
//     return;
// }

// bool result = CheckTriangle(x, y, z);
// Console.WriteLine(result);
// bool CheckTriangle(int a, int b, int c)
// {
//     if(x >= y + z)
//     {
//         return false;
//     }
//     if(y >= x + z)
//     {
//         return false;
//     }
//     if(z >= x + y)
//     {
//         return false;
//     }
//     return true;
// }


// Получить двоичное число из десятичного

// Console.WriteLine("Введите десятичное число:");
// int i = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(i, 2);
// Console.WriteLine("В двоичной системе счисления это: " + s);




// string str = ConvertNumber(x);
// string ConvertNumber(int x)
// {
//     string result = "";
//     while(x > 0)
//     {
//         int y = x % 2;
//         result = Convert.ToString(y) + result;
//         x = x / 2;
//     }
//     return result;
// }
// Console.WriteLine(str);



//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] array = new int[] {1,2,3,4,5}; 
// PrintArray(array);
// int [] reverseArray = ReverseArray(array);
// Console.WriteLine();
// PrintArray(reverseArray);

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }


// int[] ReverseArray(int[] array)
// {
    

//     int[] reverseArray = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         reverseArray[i] = array[array.Length - 1 - i];
//     }

//     return reverseArray;
// }



// Числа Фибоначчи

// double FibonacciBad(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return FibonacciBad(n-1) + FibonacciBad(n-2);
// }

// double FibonacciR(double[] f, int n)
// {
//     if (n == 1 || n == 2)
//     {
//         return f[n - 1] = 1;
//     }

//     if (f[n - 2] != 0)
//     {
//         if (f[n - 1] != 0)
//         {
//             return f[n - 1] = f[n - 2] + f[n - 3];
//         }

//         return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
//     }

//     return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
// }

// double FibonacciGood(int n)
// {
    
//     double[] f = new double[n];
//     return FibonacciR(f, n);
// }


// int countTests = 40;


// DateTime saveTime;

// Console.WriteLine($"Цикл for: ");
// saveTime = DateTime.Now;
// int fibonacci1 = 1;
// int fibonacci2 = 1;
// for (int i = 1; i <= countTests; i++)
// {
//     Console.WriteLine($"f({i}) = {fibonacci2}");
//     int temporary = fibonacci2;
//     fibonacci2 += fibonacci1;
//     fibonacci1 = temporary; 
// }
// Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");


// Console.WriteLine($"FibonacciBad: ");
// saveTime = DateTime.Now;
// for (int i = 0; i <= countTests; i++)
// {

//     Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
// }
// Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");


// Console.WriteLine($"FibonacciGood: ");
// saveTime = DateTime.Now;
// for (int i = 1; i <= countTests; i++)
// {

//     Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
// }
// Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");
