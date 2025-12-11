int SumDigits(int n)
{
    if (n < 10) return n;
    else
    {
        return SumDigits(n / 10) + SumDigits(n % 10);
    }
}
int n;
n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(n));