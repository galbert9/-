// Разряд числа с помощью цикла
 
Console.WriteLine("Введите число");  
int n = Convert.ToInt32 (Console.ReadLine());
int digit = 0;
while (n % 10 > 0)
{
    digit++;
    n/=10;
}
Console.WriteLine(digit);
Console.WriteLine("");