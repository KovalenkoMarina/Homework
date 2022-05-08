Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int n = 1;
while (n<=a)
{
    if (n%2 ==0)
    {
        Console.Write(" " + n); 
    }
    else 
    {
        Console.Write(" "); 
    }
    n++;
}



