Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int x = ((a/10)%10);
Console.WriteLine("Вывод второй цифры в числе: " + x);