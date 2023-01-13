// string ReverseString(string str) 
// { 
//     string result = String.Empty; 
 
//     for (int i = 0; i < str.Length; i++) 
//     { 
//         result += str[str.Length - 1 - i]; 
//     } 
 
//     return result; 
// } 
 
// var input = Console.ReadLine(); 
 
// bool result = CheckPalindrom(input); 
 
// if(result) 
// { 
//     Console.WriteLine("It is palindrom"); 
// } 
// else{ 
//     Console.WriteLine("It is not palindrom"); 
// } 
 
// bool CheckPalindrom(string str) 
// { 
//     string reversString = ReverseString(str); 
//     return str == reversString; 
// }
 
// bool isNumber = int.TryParse(Console.ReadLine(), out int number); 
 
// if(isNumber == false) 
// { 
//     Console.WriteLine("Is not valid"); 
//     return; 
// } 
 
// int result = GetSumNumber(number); 
 
// Console.WriteLine(result); 
 
 
// int GetSumNumber(int number) 
// { 
//     int sum = 0; 
//     for(int i = 1; i <= number; i++) 
//     { 
//         sum+= i; 
//     } 
 
//     return sum; 
// }

//Задача1 "Определить количество цифр в числе" 
// int FindDigit(int number)
// {
//     int count = 0;
//     while(number != 0)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine(FindDigit(number: 100));


//Задача2 "Найти произведение всех чисел из которого состоит заданное число (факториал)"
// int GetFactorial(int number) 
// { 
//     int product = 1; 
//     for(int i = 2; i <= number; i++) 
//     { 
//         product *= i; 
//     } 
 
//     return product; 
// }
// Console.WriteLine(GetFactorial(number: 3));


//Задача3 "Создать и вывести массив из 0 и 1, длиной 8 символов"
// int[] GetRandomNumbers(int count)
// {
//     Random rnd = new Random();
//     string str = String.Empty;
//     int[] result = new int[count];
//     for (int i = 0; i < count - 1; i++)
//     {
//         result[i] = rnd.Next(0, 2);
//         str += result[i];
//     }
//     return result;
// }
// PrintArray(GetRandomNumbers(8));

// void PrintArray(int[]array)
// {
//     string str = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         str += array[i];
//     }
//     Console.WriteLine(str);
// }