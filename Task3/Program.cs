// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine() ?? "0");
int index = 1;
long result = 1;

while (index<=N)
{
    result = result*index;
    index++;    
}
Console.Write(result);