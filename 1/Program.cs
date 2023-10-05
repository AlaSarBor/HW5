// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
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
int N = num();

int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}


Console.WriteLine(NaturalNumber(N, 1));