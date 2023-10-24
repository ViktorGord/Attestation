//Аттестация: Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N<=0) {
//     Console.WriteLine("Введите число больше ноля");
// }
// else {
//     Console.WriteLine("Результат выполнения кода представлен ниже:");
//     Console.WriteLine(PossitiveNumbers(1, N));
// }
// string PossitiveNumbers(int start, int N) {
//     if(N == start) {
//         return start.ToString();
//     }
//     return N + " " + PossitiveNumbers(start, N-1);
// }

// Аттестация: Задача 66
// Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// void SumPositive(int start, int end)
// {
//     //System.Console.Write(start);
//     sum = sum + start;
//     //sum += start;
//     if(start == end)
//     {
//         Console.WriteLine("Результат выполнения кода представлен ниже:");
//         Console.WriteLine(sum);
//         return;
//     }
//     else
//     {
//         SumPositive(start+1, end);
//     }
// }
// SumPositive (M, N);


// Аттестация: Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
 
// Console.Write("Введите число m: "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
 
// Console.Write("Введите число n: "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
 
// bool CheckNum (int first, int second) 
// { 
//     if (first > 0 && second > 0) return true; 
//     return false; 
// } 
// int AkkermanFunction(int m, int n) 
// { 
//     if (m == 0) return n + 1; 
//     else 
//     { 
//         if(m != 0 && n == 0) return AkkermanFunction(m - 1, 1); 
//         else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)); 
//     } 
// } 
// if (CheckNum(m, n)) 
// { 
//     int result = AkkermanFunction(m, n); 
//     Console.WriteLine($"Результат вычисления функции Аккермана: A({m},{n}) = {result}"); 
// }