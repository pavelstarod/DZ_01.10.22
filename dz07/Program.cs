Console.WriteLine("Вводим трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int x = (a%10);
Console.WriteLine("Вывод последней цифры в числе: " + x);