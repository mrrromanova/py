Console.Clear();
Console.WriteLine("Введите число");
int X = int.Parse(Console.ReadLine());
int number = 1;
while (number<X)
{
int Y = number % 2;
if (Y==0)
{
    Console.Write($"{number}, ");
}
}

while (number==X)
{
int Y = number % 2;
if (Y==0)
{
    Console.Write($"{number}.");
}
}

number = number + 1;
