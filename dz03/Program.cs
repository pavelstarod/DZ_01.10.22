Console.WriteLine("Введите x, y, z: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if ((x > y) && (x > z))
 Console.WriteLine("max= " + x);
if ((y > x) && (y > z))
 Console.WriteLine("max= " + y);
if ((z > y) && (x < z))
 Console.WriteLine("max= " + z);
