Console.WriteLine("Введите конечное число: ");
int N = 1;
int N2 = int.Parse(Console.ReadLine());
Console.Write("Вывод чисел кратных двум: ");

while (N <= N2)
{
    if (N%2 == 0)
    Console.WriteLine(N);
    N++;
}