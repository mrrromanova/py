Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
int number = 1;
while (number<num1)
{
int Y = number % 2;
if (Y==0)
{
    Console.Write($"{number}, ");
}
}

while (number==num1)
{
int Y = number % 2;
if (Y==0)
{
    Console.Write($"{number}.");
}
}

number = number + 1;
