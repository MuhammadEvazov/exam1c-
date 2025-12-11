void Swap(ref int a, ref int b)
{
    System.Console.WriteLine($"x = {b}");
    System.Console.WriteLine($"y = {a}");
}
int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine());
Swap(ref a, ref b);