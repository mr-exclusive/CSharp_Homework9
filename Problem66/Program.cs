//Задача 66: Задайте значения M и N.
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

int SumIntegersBetween2Numbers(int m, int n)
{
    if (m == n) return n;

    return m + SumIntegersBetween2Numbers(m + 1, n);
}


Console.Clear();

Console.Write("Enter M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter N (where N > M): ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Summa of integers between {m} and {n} equals {SumIntegersBetween2Numbers(m, n)}");