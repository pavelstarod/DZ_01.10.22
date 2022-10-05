
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
    Console.WriteLine("первое число является квадратом второго");
else
    Console.WriteLine("первое число не является квадратом второго");
