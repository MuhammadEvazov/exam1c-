using System.ComponentModel.DataAnnotations;

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int min = 9999;
int max = -9999;
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n - 1; i++)
{
    if (arr[i] < min)
    {
        min = i;
    }
    if (arr[i] > max)
    {
        max = i;
    }

}
System.Console.WriteLine(arr[min]);
System.Console.WriteLine(arr[max]);
