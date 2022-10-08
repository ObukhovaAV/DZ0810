// Найти кубы чисел от 1 до N
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine() ?? "0");
int n = 1;


Console.WriteLine("Кубы чисел от 1 до " + N);
while (n<=N)
{
    int cub = n*n*n;    
    Console.WriteLine(cub);
    n++;
}
