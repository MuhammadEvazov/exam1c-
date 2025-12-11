// Task6
void PrintEven(int n, int m)
{ 
    if (n > m) return;
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
    }
    PrintEven(n + 1, m);
}
void PrintOdd(int n, int m)
{ 
    if (n > m) return;
    if (n % 2 == 1)
    {
        Console.Write(n + " ");
    }
    PrintOdd(n + 1, m);
}
int n, m;
n = Convert.ToInt32(Console.ReadLine());
m = Convert.ToInt32(Console.ReadLine());

PrintEven(n, m);
Console.WriteLine();
PrintOdd(n, m);