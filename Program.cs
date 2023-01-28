// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int RecNumber(int n)
// {
//     if (n == 0) return 0;
//     else
//     {
//         Console.Write(n);
//         return RecNumber(n-1);
//     }
// }
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// RecNumber(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SumNumbers(int m, int n)
// {int result= 0;
//     if (m <= n)
//     {
//         result = m + SumNumbers(m+1, n);//result = n + SumNumbers(m, n-1)
//         Console.Write(m);
//         return result;
//     }
//     else return 0;
// }
// Console.WriteLine("Введите первое чиcло m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число n ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumNumbers(m,n);
// Console.WriteLine(SumNumbers(m,n));





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkRec(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AkkRec(n - 1, 1);
    else
        return AkkRec(n - 1, AkkRec(n, m - 1));
}

Console.WriteLine("Введите первое чиcло m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число n ");
int n = Convert.ToInt32(Console.ReadLine());
AkkRec(m,n);
Console.WriteLine(AkkRec(m,n));