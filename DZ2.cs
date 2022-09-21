Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
PrintSum(N);
Console.Write($"Sum is: {sum}");

void PrintSum(int N)
{
    if (N > M) return;
    PrintSum(N + 1);
    sum += N;
}