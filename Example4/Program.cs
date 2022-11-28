Console.Write("Введите число:");
int namber = int.Parse(Console.ReadLine());

for (int i = 2; i <= namber; i+=2)
{
    Console.Write($"{i},");
}