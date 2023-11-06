using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Write the size of the array");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Fill the array");
int[] array = new int[N];
int sum = 0;
int num = 0;
for (int i = 0; i < N; i++) 
{
    array[i] = int.Parse(Console.ReadLine());
}

foreach (int j in array)
{
    sum = j > 0 ? sum + j : sum;
    num = j % 2 == 0 ? num + 1 : num;
}
Console.WriteLine(sum + " - sum of positive elements");
Console.WriteLine(num + " - the number of even elements");
Console.ReadLine();
