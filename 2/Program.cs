int num()
{
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Sum(int n, int m)
{
    if (n == m) return n;
    else return Sum(n + 1, m) + n;
}

int n = num();
int m = num();

Console.WriteLine(Sum(n, m));
