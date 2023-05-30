Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int number1 = number % 2;

if (number1 == 0)
{
    Console.WriteLine($"Число {number} является чётным");
}

else
{
    Console.WriteLine($"Число {number} является нечётным");
}