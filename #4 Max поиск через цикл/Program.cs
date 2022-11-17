 // Поиск Max 
int Max = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] > Max)
    Max = array[i];
}
Console.WriteLine(Max);
