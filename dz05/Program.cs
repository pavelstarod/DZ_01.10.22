Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Вывод списка: ");
int N2 = (N* -1);

if (N > 0)
{
    while (N2 <= N)
    {
        Console.WriteLine(N2);
        N2++;
    }
}
else while (N2 >= N)
{
  Console.WriteLine(N);
  N++;
}