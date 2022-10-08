// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine () ?? "0");
int number = 1;
double cub = 0;

while (number<=N)
{
    if (number%2==0)
    {
        cub = Math.Pow(number, 3); 
        Console.WriteLine(cub);
        number = number+2;                  
    }
    else
    {
        number++;
    }    
}