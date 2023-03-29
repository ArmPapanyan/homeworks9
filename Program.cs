// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumbers(int n)
// {
//     if(n>=1)
//     {
//         Console.Write(n+" ");
//         ShowNumbers(n-1);
//         
//     }
// }

// ShowNumbers(5);


// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// System.Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumMtoN(m, n));

// int SumMtoN(int m, int n)
// {
//     if (m == n)
//         return n;
//     else
//         return m + SumMtoN(m + 1, n);
// }

// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.Write("Input M: ");
 int m = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Input N: ");
 int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Akkerman(m,n));

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}