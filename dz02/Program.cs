Console.WriteLine("введите номер недели: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("вывод дня недели: ");

if (x < 1)
 Console.WriteLine("неккоректные вводные данные");
else if (x == 1)
 Console.WriteLine("понедельник");
else if (x == 2)
 Console.WriteLine("вторник");
else if (x == 3)
 Console.WriteLine("среда");
else if (x == 4)
 Console.WriteLine("четверг");
else if (x == 5)
 Console.WriteLine("пятница");
else if (x == 6)
 Console.WriteLine("суббота");
else if (x == 7)
 Console.WriteLine("воскресенье");
else
 Console.WriteLine("неккоректные вводные данные");
