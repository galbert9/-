// Определить разряд числа с прмощью логарифма

Console.WriteLine("Введите число");  
int n = Convert.ToInt32 (Console.ReadLine());

double exp = Math.Log10(n);

int digit = 0;
while (digit < exp)
{
    if (digit > exp) break;
    digit++;
    
}
Console.WriteLine(digit);
