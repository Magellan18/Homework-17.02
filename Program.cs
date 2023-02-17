// Задача 2
// using System;

// class Program {
//     static void Main() {
//         Console.Write("Введите первое число: ");
//         int a = int.TryParse(Console.ReadLine(), out int num1) ? num1 : 0;

//         Console.Write("Введите второе число: ");
//         int b = int.TryParse(Console.ReadLine(), out int num2) ? num2 : 0;

//         int max = a > b ? a : b;
//         int min = a < b ? a : b;

//         Console.WriteLine($"Максимальное число: {max}");
//         Console.WriteLine($"Минимальное число: {min}");

//         Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
//         Console.ReadKey();
//     }
// }


// Задача4
// using System;

// class Program {
//     static void Main() {
//         Console.Write("Введите первое число: ");
//         if (!int.TryParse(Console.ReadLine(), out int num1)) {
//             Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//             return;
//         }

//         Console.Write("Введите второе число: ");
//         if (!int.TryParse(Console.ReadLine(), out int num2)) {
//             Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//             return;
//         }

//         Console.Write("Введите третье число: ");
//         if (!int.TryParse(Console.ReadLine(), out int num3)) {
//             Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//             return;
//         }

//         int max = num1;

//         if (num2 > max) {
//             max = num2;
//         }

//         if (num3 > max) {
//             max = num3;
//         }

//         Console.WriteLine("Максимальное число: " + max);
//         Console.WriteLine("Нажмите любую клавишу для выхода...");
//         Console.ReadKey();
//     }
// }


// Задача 6
// using System;

// class Program {
//     static void Main() {
//         Console.Write("Введите число: ");
//         if (!int.TryParse(Console.ReadLine(), out int num)) {
//             Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//             return;
//         }

//         if (num % 2 == 0) {
//             Console.WriteLine("Да, число четное");
//         } else {
//             Console.WriteLine("Нет, число нечетное");
//         }

//         Console.WriteLine("Нажмите любую клавишу для выхода...");
//         Console.ReadKey();
//     }
// }

// Задача 8
// using System;

// class Program {
//     static void Main() {
//         Console.Write("Введите число: ");
//         int n = GetNumberFromUser();

//         Console.Write("Чётные числа от 1 до " + n + ": ");
//         for (int i = 2; i <= n; i += 2) {
//             Console.Write(i + " ");
//         }
//         Console.WriteLine("\nНажмите любую клавишу для выхода...");
//         Console.ReadKey();
//     }

//     static int GetNumberFromUser() {
//         int result;
//         string input = Console.ReadLine();
//         while (!int.TryParse(input, out result)) {
//             Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
//             input = Console.ReadLine();
//         }
//         return result;
//     }
// }
