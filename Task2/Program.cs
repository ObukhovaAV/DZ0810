// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;

if (number<0)
    {
        number = -number;
    }

while (number>0)    
{
    int result = number%10;
    sum = sum + result;
    number = number/10;   
}

Console.WriteLine("Сумма цифр числа = " + sum);
