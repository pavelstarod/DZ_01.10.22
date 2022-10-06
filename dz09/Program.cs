Console.WriteLine("Введите число из отрезка 10-99: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10;
int a2 = a % 10;

if (a1>a2)
 Console.WriteLine("max: " + a1);
else
 Console.WriteLine("max: " + a2);
  