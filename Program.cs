//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int say = 0;
//foreach (int i in arr)
//{
//    if (i % 2 != 0)
//    {
//        say++;
//    }
//}
//Console.WriteLine(say);

//int[] arr = { 3, 8, 2, 10, 5 };
//int enBoyuk = arr[0];
//int enKicik = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (enBoyuk < arr[i])
//    {
//        enBoyuk = arr[i];
//    }
//};
//for (int i = 1; i < arr.Length; i++)
//{
//    if (enKicik > arr[i])
//    {
//        enKicik = arr[i];
//    }    
//}

//Console.WriteLine(enBoyuk + enKicik);

//int[] arr = { 5, 8,15, 3, 7 };
//int enBoyuk = arr[0];
//int enKicik = arr[0];
//for (int i = 1; i < arr.Length; i++)
//{
//    if (enBoyuk < arr[i])
//    {
//        enBoyuk = arr[i];
//    }
//};
//for (int i = 1; i < arr.Length; i++)
//{
//    if (enKicik > arr[i])
//    {
//        enKicik = arr[i];
//    }
//}
//Console.WriteLine(enBoyuk - enKicik);

//int[] arr = { 3, 1, 5, 4, 2 };
//for(int i = 0; i < arr.Length; i++)
//{
//    int a;
//    for (int j = 0; j < i; j++)
//    {
//        if (arr[i] < arr[j])
//        {
//            a = arr[j];
//            arr[j] = arr[i];
//            arr[i] = a;
//        }
//    }

//}
//foreach (int i in arr)
//{
//Console.WriteLine(i);
//}

int[] arr = { 1, 2, 3, 4, 5 };
int tek = 0;
int cut = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]%2==0)
    {
        cut++;
    }
    else
    {
        tek++;
    }
}
Console.WriteLine(tek);
Console.WriteLine(cut);


