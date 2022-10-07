Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100)
{
           Console.WriteLine("нет третьей цифры в числе");
}
else
{
     while (a >= 1000)
      {
          a = a/10;
      }
           Console.WriteLine("Вывод третьей цифры в числе: " + a%10);
}