// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int read = int.Parse(Console.ReadLine());
int[] arr = new int[read];
int sum = 0;

for(int i = 0; i < arr.Length; i++)
{
    int read2 = int.Parse(Console.ReadLine());
    arr[i] = read2;
    Console.WriteLine(arr);
}

// SUM OF ARRAYS:
int[] a = { 2, 5, 6, 8, 23 };
int[] b = { 99, 34, -2, 3, 4, 7, 8 };
int[] c = new int[b.Length];

for(int i = 0; i < c.Length; i++)
{
    if (i < a.Length)
    {
        c[i] = a[i] + b[i];
    }
    else
    {
        c[i] = b[i];
    }
}
