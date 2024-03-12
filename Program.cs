int[] arr = { 2, 3, 5, 6, 34, 1 };
int cem = 0;
foreach (int i in arr)
{
    cem += i;
}
double average = (double)cem / arr.Length;
Console.WriteLine("Ededi orta: " + average); 
Console.WriteLine("Cemi: " + cem);

Console.WriteLine("x1 daxil edin: ");
float x1 = float.Parse(Console.ReadLine());

Console.WriteLine("y1 daxil edin: ");
float y1 = float.Parse(Console.ReadLine());

Console.WriteLine("x2 daxil edin: ");
float x2 = float.Parse(Console.ReadLine());

Console.WriteLine("y2 daxil edin: ");
float y2 = float.Parse(Console.ReadLine());

Console.WriteLine("x3 daxil edin: ");
float x3 = float.Parse(Console.ReadLine());

Console.WriteLine("y3 daxil edin: ");
float y3 = float.Parse(Console.ReadLine());

if ((y3 - y2) * (x2 - x1) == (y2 - y1) * (x3 - x2))
    Console.WriteLine("Üç nöqte bir düz xette düşür.");
else
    Console.WriteLine("Üç nöqte bir düz xette düşmür.");