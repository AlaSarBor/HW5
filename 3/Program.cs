﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int num()
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1)
    {
        Console.WriteLine("необходимо положительное число");
        return num();
    }
    else return n;

}

int m = num();
int n = num();
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}


Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");