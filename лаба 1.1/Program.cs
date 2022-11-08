//Горлачев высокий уровень 
Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите a: ");
double a = double.Parse(Console.ReadLine());
double G = 0;
G = Math.Pow(Math.Cos(Math.Abs(y + x)), 2) - (x + y) / Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5);
Console.WriteLine("G равен:"+G);    