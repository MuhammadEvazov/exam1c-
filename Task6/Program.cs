int Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write(Fibonacci(i) + " ");
}