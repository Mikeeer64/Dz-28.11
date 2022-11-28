Console.Write("Введите первое число:");
int namber1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
int namber2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число:");
int namber3 = int.Parse(Console.ReadLine());

int max = namber1;

if (namber2 > max)
    max = namber2;
if (namber3 > max) 
    max = namber3;

Console.Write($"Самое большое число: {max}");
    






