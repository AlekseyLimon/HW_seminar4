// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число 
// A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int NumDegree(int first, int second)
// {
//     int res = 1;
//     for (int i = 1; i <= second; i++)
//     {
//         res = first * res;
//     }
// return res;
// }

// int a = InputNum("Введите число A: ");
// int b = InputNum("Введите число B: ");

// int result = NumDegree(a, b);
// Console.Write($"{a} в степени {b} равно {result}");














// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// ПЕРВОЕ РЕШЕНИЕ ЧЕРЕЗ ОГРОМНОЕ КОЛИЧЕСТВО МЕТОДОВ

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int [] ArreyOfNumbers(int number)
// {
//     int temp = number;
//     int count = 0;
//          while (temp != 0)
//      {
//             temp /= 10;
//             count++;
//      }

//     int[] array = new int[count];
//          for (int i = array.Length - 1; i >= 0; i--)
//          {
//              array[i] = number % 10;
//              number /= 10;
//          }
//          return array;
// }

// int SumOfDigits(int [] arr)
// {  
//      int res = 0; 
//      for (int i = 0; i <= arr.Length-1; i++)
//          {
//          res = res + arr[i];
//          }
//      return res;
// }

// int num = InputNum("Введите число: ");
// int [] MyArrey = ArreyOfNumbers(num);
// int result = SumOfDigits(MyArrey);
// Console.WriteLine($"Сумма цифр числа {num} равна {result}");

//ВТОРОЕ РЕШЕНИЕ МАТЕМАТИЧЕСКОЕ

//  Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine()!);
// int result = 0;
//     while (num != 0)
//         {
//             result += num % 10;
//             num /= 10;
//         }
// Console.WriteLine($"Сумма цифр равна {result}");










// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// РЕШЕНИЕ С МИЛЛИОНОМ МЕТОДОВ к семинарскому решению добавил вывод через запятую и диапазон от -99 до 99


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int[] ArrayRand(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-99, 99);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {       int size = array.Length;
//         for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i]);
//         if (i <  size - 1)
//             Console.Write(", ");
//         else
//             Console.Write(" ");
//     }
// }
// int len = InputNum("Введите длину массива: ");
// int[] arr = ArrayRand(len);
// PrintArray(arr);

// РЕШЕНИЕ ЧЕРЕЗ ПРОСТОЙ ЦИКЛ

// int[] array = new int[8];

// for (int i = 0; i < 8; i++)
// {
// array[i] = new Random().Next(-99 ,99);
// Console.Write(array[i] + " ");
// }

