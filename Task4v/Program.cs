// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int digit = a%10;
int cub = a*a*a;

if (digit%2==0)
{
   Console.WriteLine("Число в кубе = " + cub); 
}
else 
{
   Console.WriteLine("Последняя цифра в числе нечетная"); 
}
