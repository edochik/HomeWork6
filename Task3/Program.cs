int PascalTria(int k)
{
    if (k == 0 || n == k) return 1;
    else return PascalTria(n - k, k - 1) + С(n - 1, k);

}

int b = 5;

Console.WriteLine(PascalTria(b));