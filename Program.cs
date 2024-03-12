int[] arr = { 2, 3, 5, 6, 34, 1 };
int cem = 0;
foreach (int i in arr)
{
    cem += i;
}
double average = (double)cem / arr.Length;
Console.WriteLine("Ededi orta: " + average); 
Console.WriteLine("Cemi: " + cem);