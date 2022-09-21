Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
PrintNumber(N);

void PrintNumber(int N)
{
    if (N > M) return;
    Console.Write($"{N} ");
    PrintNumber(N + 1);
}