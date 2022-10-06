Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int k = 7;
int ostatok = a % k;
if (a % k ==0)
  Console.WriteLine("число a кратно числу к");
else 
  Console.WriteLine(ostatok);
  