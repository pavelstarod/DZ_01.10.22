Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 100;
int a2 = ((a / 10) % 10);
int a3 = a % 10;
Console.WriteLine("Вывод числа без второй цифры: ");
Console.Write(a1);
Console.Write(a3);
