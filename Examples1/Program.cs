Console.Write("Введите первое число:");
int namber1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
int namber2 = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (namber1 > namber2)
    {
        max = namber1;
        min = namber2;   
    }

else 
    {
        max = namber2; 
        min = namber1;
    }    

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
