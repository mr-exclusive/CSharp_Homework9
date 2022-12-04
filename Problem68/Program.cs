//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

int FuncAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FuncAckermann(m - 1, 1);

    return FuncAckermann(m - 1, FuncAckermann(m, n - 1));
}


Console.Clear();

Console.Write("Enter 1st positive number: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter 2nd positive number: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Result of the Ackermann Function: A({m}, {n}) = {FuncAckermann(m, n)}");