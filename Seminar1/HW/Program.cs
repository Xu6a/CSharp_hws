// Задание 1. Большее из двух чисел

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber > secondNumber)
//         {
//           System.Console.WriteLine("первое число больше");
//         }
//         else if (secondNumber > firstNumber)
//         {
//           System.Console.WriteLine("второе число больше");
//         }
//         else 
//         {
//           System.Console.WriteLine("числа равны");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }





// Задание 2. Максимальное из 3 чисел

// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//     int max = a;
//     if (b > max) max = b;
//     if (c > max) max = c;
//     return max;
//     }
    
//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 8;
//            b = 10;
//            c = 10;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }





// Задание 3. Проверка на четность

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//     if ((number % 2) == 0)
//       System.Console.WriteLine("четное");
//     else
//       System.Console.WriteLine("нечетное");
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 7;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }






// Задача 4. Вывод четных чисел до N

// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//       int i = 2;
//       while (number >= i) {
//         System.Console.Write(i + " ");
//         i = i + 2;
//       }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 7;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }