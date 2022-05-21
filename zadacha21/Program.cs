int n = 8;
int a = 1;
Console.WriteLine("Наш массив");
while (a<=n)
{
    int numberA = new Random().Next(0,2);
    Console.Write(numberA + " ");
    a++;
}
