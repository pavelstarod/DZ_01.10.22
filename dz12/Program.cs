Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());


if (a>= 100 && a <= 999)
   Console.WriteLine(a%10);
else
   Console.WriteLine("нет третьей цифры в числе");
