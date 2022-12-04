//Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

//N = 5-> "5, 4, 3, 2, 1"
//N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbersDesc(int n)
{
    Console.Write(n);

    if (n > 1)
    {
        Console.Write(", ");
        PrintNumbersDesc(n - 1);
    }
}

Console.Clear();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbersDesc(n);